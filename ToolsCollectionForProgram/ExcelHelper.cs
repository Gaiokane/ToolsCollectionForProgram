using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsCollectionForProgram
{
    class ExcelHelper
    {
        /// <summary>
        /// 读取Excel中指定单元格的值
        /// </summary>
        /// <param name="filePath">Excel文件路径</param>
        /// <param name="sheetIndex">sheet页index，0开始</param>
        /// <param name="row">行，0开始</param>
        /// <param name="cell">列，0开始</param>
        /// <returns>返回单元格值</returns>
        public static string ReadExcelByCell(string filePath, int sheetIndex, int row, int cell)
        {
            string result = "";
            IWorkbook wk = null;
            string extension = System.IO.Path.GetExtension(filePath);
            try
            {
                FileStream fs = File.OpenRead(filePath);
                if (extension.Equals(".xls"))
                {
                    //把xls文件中的数据写入wk中
                    wk = new HSSFWorkbook(fs);
                }
                else
                {
                    //把xlsx文件中的数据写入wk中
                    wk = new XSSFWorkbook(fs);
                }

                fs.Close();
                //读取当前表数据
                ISheet sheet = wk.GetSheetAt(sheetIndex);
                result = sheet.GetRow(row).GetCell(cell).ToString();
                return result;
            }

            catch (Exception e)
            {
                //只在Debug模式下才输出
                return e.Message;
            }
        }

        /// <summary>
        /// 读取Excel中全部内容
        /// </summary>
        /// <param name="filePath">Excel文件路径</param>
        /// <param name="sheetIndex">sheet页index，0开始</param>
        /// <returns>返回sheet页内容</returns>
        public static string ReadExcel(string filePath, int sheetIndex)
        {
            string result = "";
            IWorkbook wk = null;
            string extension = System.IO.Path.GetExtension(filePath);
            try
            {
                FileStream fs = File.OpenRead(filePath);
                if (extension.Equals(".xls"))
                {
                    //把xls文件中的数据写入wk中
                    wk = new HSSFWorkbook(fs);
                }
                else
                {
                    //把xlsx文件中的数据写入wk中
                    wk = new XSSFWorkbook(fs);
                }

                fs.Close();
                //读取当前表数据
                ISheet sheet = wk.GetSheetAt(sheetIndex);

                IRow row = sheet.GetRow(0);  //读取当前行数据
                                             //LastRowNum 是当前表的总行数-1（注意）
                for (int i = 0; i <= sheet.LastRowNum; i++)
                {
                    row = sheet.GetRow(i);  //读取当前行数据
                    if (row != null)
                    {
                        //LastCellNum 是当前行的总列数
                        for (int j = 0; j < row.LastCellNum; j++)
                        {
                            //读取该行的第j列数据
                            string value = row.GetCell(j).ToString();
                            result += value.ToString() + " ";
                        }
                        result += "\n";
                    }
                }
                return result;
            }

            catch (Exception e)
            {
                //只在Debug模式下才输出
                return e.Message;
            }
        }

        /// <summary>
        /// 修改Excel中指定单元格的值
        /// </summary>
        /// <param name="filePath">Excel文件路径</param>
        /// <param name="sheetIndex">sheet页index，0开始</param>
        /// <param name="row">行，0开始</param>
        /// <param name="cell">列，0开始</param>
        /// <param name="cellValue">要修改的单元格数据</param>
        /// <returns></returns>
        public static bool ModifyExcelByCell(string filePath, int sheetIndex, int row, int cell, string cellValue)
        {
            IWorkbook wk = null;
            string extension = System.IO.Path.GetExtension(filePath);
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                if (extension.Equals(".xls"))
                {
                    //把xls文件中的数据写入wk中
                    wk = new HSSFWorkbook(fs);
                }
                else
                {
                    //把xlsx文件中的数据写入wk中
                    wk = new XSSFWorkbook(fs);
                }

                fs.Close();

                //修改指定单元格数据
                wk.GetSheetAt(sheetIndex).GetRow(row).GetCell(cell).SetCellValue(cellValue);

                MemoryStream ms = new MemoryStream();
                wk.Write(ms);
                SaveToFile(ms, filePath);

                return true;
            }

            catch (Exception e)
            {
                return false;
                //return e.Message;
            }
        }

        /// <summary>
        /// 保存到文件，如果已存在，则覆盖，否则新建
        /// </summary>
        /// <param name="ms">MemoryStream流</param>
        /// <param name="fileName">文件路径</param>
        static void SaveToFile(MemoryStream ms, string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                byte[] data = ms.ToArray();
                fs.Write(data, 0, data.Length);
                fs.Flush();
                data = null;
            }
        }

        /// <summary>
        /// 读取Excel中指定Sheet的所有批注
        /// </summary>
        /// <param name="filePath">Excel文件路径</param>
        /// <param name="sheetIndex">sheet页index，0开始</param>
        /// <returns>返回指定Sheet页批注，一行一条</returns>
        public static string ReadExcelCommentBySheet(string filePath, int sheetIndex)
        {
            string result = "";
            IWorkbook wk = null;
            string extension = System.IO.Path.GetExtension(filePath);
            try
            {
                FileStream fs = File.OpenRead(filePath);
                if (extension.Equals(".xls"))
                {
                    //把xls文件中的数据写入wk中
                    wk = new HSSFWorkbook(fs);
                }
                else
                {
                    //把xlsx文件中的数据写入wk中
                    wk = new XSSFWorkbook(fs);
                }

                fs.Close();

                //读取当前表数据
                StringBuilder sb = new StringBuilder();
                //打印对应sheet
                sb.AppendLine("Sheet" + sheetIndex + "：" + wk.GetSheetName(sheetIndex) + "\n");
                //实例化row
                IRow irow;

                //实例化sheet
                ISheet sheet = wk.GetSheetAt(sheetIndex);
                //sheet总行数
                for (int i = 0; i < sheet.PhysicalNumberOfRows; i++)
                {
                    irow = sheet.GetRow(i);
                    var s = "";
                    //sheet总列数
                    for (int j = 0; j < irow.PhysicalNumberOfCells; j++)
                    {
                        //判空，不然sheet.GetRow(i).GetCell(j)和sheet.GetRow(i).GetCell(j).CellComment报错
                        //var a = sheet.GetRow(i);
                        //GetCell返回null后无法再进行CellComment
                        //var b = sheet.GetRow(i).GetCell(j);
                        //var c = sheet.GetRow(i).GetCell(j).CellComment;
                        if (sheet.GetRow(i).GetCell(j) != null && sheet.GetRow(i).GetCell(j).CellComment != null)
                        {
                            //遍历sheet每个单元格获取批注，去除批注人后面换行
                            s = getCellLocation(i, j) + ":" + sheet.GetRow(i).GetCell(j).CellComment.String.ToString().Replace("\n", "");
                            //换行
                            sb.AppendLine(s);
                        }
                    }
                }

                result = sb.ToString();

                return result;
            }

            catch (Exception e)
            {
                //只在Debug模式下才输出
                return e.Message;
            }
        }

        /// <summary>
        /// 读取Excel中指定Sheet的所有批注
        /// </summary>
        /// <param name="filePath">Excel文件路径</param>
        /// <returns>返回所有Sheet页批注，一行一条</returns>
        public static string ReadExcelCommentBySheet(string filePath)
        {
            string result = "";
            IWorkbook wk = null;
            string extension = System.IO.Path.GetExtension(filePath);
            try
            {
                FileStream fs = File.OpenRead(filePath);
                if (extension.Equals(".xls"))
                {
                    //把xls文件中的数据写入wk中
                    wk = new HSSFWorkbook(fs);
                }
                else
                {
                    //把xlsx文件中的数据写入wk中
                    wk = new XSSFWorkbook(fs);
                }

                fs.Close();

                //读取当前表数据
                StringBuilder sb = new StringBuilder();
                //实例化row
                IRow irow;

                //总sheet数
                for (int i = 0; i < wk.NumberOfSheets; i++)
                {
                    //sheet0以上多一个换行
                    if (i > 0)
                    {
                        sb.AppendLine();
                    }
                    //打印对应sheet
                    sb.AppendLine("Sheet" + i + "：" + wk.GetSheetName(i) + "\n");
                    //实例化sheet
                    ISheet sheet = wk.GetSheetAt(i);
                    //sheet总行数
                    for (int j = 0; j < sheet.PhysicalNumberOfRows; j++)
                    {
                        irow = sheet.GetRow(i);
                        var s = "";
                        //sheet总列数
                        for (int k = 0; k < irow.PhysicalNumberOfCells; k++)
                        {
                            //判空，不然sheet.GetRow(i).GetCell(j)和sheet.GetRow(i).GetCell(j).CellComment报错
                            //var a = sheet.GetRow(i);
                            //GetCell返回null后无法再进行CellComment
                            //var b = sheet.GetRow(i).GetCell(j);
                            //var c = sheet.GetRow(i).GetCell(j).CellComment;
                            if (sheet.GetRow(j).GetCell(k) != null && sheet.GetRow(j).GetCell(k).CellComment != null)
                            {
                                //遍历sheet每个单元格获取批注，去除批注人后面换行
                                s = getCellLocation(j, k) + ":" + sheet.GetRow(j).GetCell(k).CellComment.String.ToString().Replace("\n", "");
                                //换行
                                sb.AppendLine(s);
                            }
                        }
                    }
                }

                result = sb.ToString();

                return result;
            }

            catch (Exception e)
            {
                //只在Debug模式下才输出
                return e.Message;
            }
        }

        /// <summary>
        /// 根据循环变量获取Excel中对应单元格位置
        /// </summary>
        /// <param name="row">第几行，从0开始</param>
        /// <param name="cell">第几列，从0开始</param>
        /// <returns>返回对应单元格位置，如A1</returns>
        public static string getCellLocation(int row, int cell)
        {
            string result = null;
            string[] str = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            result = str[cell] + (row + 1);
            return result;
        }
    }
}