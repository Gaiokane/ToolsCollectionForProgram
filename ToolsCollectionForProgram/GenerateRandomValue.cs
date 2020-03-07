using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ToolsCollectionForProgram
{
    class GenerateRandomValue
    {
        static readonly Random Random = new Random(~unchecked((int)DateTime.Now.Ticks));
        static readonly char[] NumberList = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static readonly char[] LowCharList = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        static readonly char[] UpCharList = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        static readonly char[] SymbolList = { '`', '-', '=', '[', ']', '\\', ';', '\'', ',', '.', '/', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '{', '}', '|', ':', '"', '<', '>', '?' };
        private static char[] ChineseCharacterList;

        #region 生成随机数字
        /// <summary>
        /// 生成随机数字
        /// </summary>
        /// <param name="Length">生成长度</param>
        public static string RandomNumber(int Length)
        {
            return Create(Length, false, NumberList);
        }

        /// <summary>
        /// 生成随机数字
        /// </summary>
        /// <param name="Length">生成长度</param>
        /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
        public static string RandomNumber(int Length, bool Sleep)
        {
            return Create(Length, Sleep, NumberList);
        }
        #endregion

        #region 生成随机小写字母
        /// <summary>
        /// 生成随机小写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        public static string RandomLowerCaseLetters(int Length)
        {
            return Create(Length, false, LowCharList);
        }

        /// <summary>
        /// 生成随机小写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
        public static string RandomLowerCaseLetters(int Length, bool Sleep)
        {
            return Create(Length, Sleep, LowCharList);
        }
        #endregion

        #region 生成随机大写字母
        /// <summary>
        /// 生成随机大写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        public static string RandomUpperCaseLetters(int Length)
        {
            return Create(Length, false, UpCharList);
        }

        /// <summary>
        /// 生成随机大写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
        public static string RandomUpperCaseLetters(int Length, bool Sleep)
        {
            return Create(Length, Sleep, UpCharList);
        }
        #endregion

        #region 生成随机大小写字母
        /// <summary>
        /// 生成随机大小写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        public static string RandomUppercaseAndLowerCaseLetters(int Length)
        {
            return Create(Length, false, MergeArray(LowCharList, UpCharList, null, null, null));
        }

        /// <summary>
        /// 生成随机大小写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
        public static string RandomUppercaseAndLowerCaseLetters(int Length, bool Sleep)
        {
            return Create(Length, Sleep, MergeArray(LowCharList, UpCharList, null, null, null));
        }
        #endregion

        #region 生成随机数字+小写字母
        /// <summary>
        /// 生成随机数字+小写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        public static string RandomNumberAndLowerCaseLetters(int Length)
        {
            return Create(Length, false, MergeArray(NumberList, LowCharList, null, null, null));
        }

        /// <summary>
        /// 生成随机数字+小写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
        public static string RandomNumberAndLowerCaseLetters(int Length, bool Sleep)
        {
            return Create(Length, Sleep, MergeArray(NumberList, LowCharList, null, null, null));
        }
        #endregion

        #region 生成随机数字+大写字母
        /// <summary>
        /// 生成随机数字+大写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        public static string RandomNumberAndUpperCaseLetters(int Length)
        {
            return Create(Length, false, MergeArray(NumberList, UpCharList, null, null, null));
        }

        /// <summary>
        /// 生成随机数字+大写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
        public static string RandomNumberAndUpperCaseLetters(int Length, bool Sleep)
        {
            return Create(Length, Sleep, MergeArray(NumberList, UpCharList, null, null, null));
        }
        #endregion

        #region 生成随机数字+大小写字母
        /// <summary>
        /// 生成随机数字+大小写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        public static string RandomNumberAndUppercaseAndLowerCaseLetters(int Length)
        {
            return Create(Length, false, MergeArray(NumberList, LowCharList, UpCharList, null, null));
        }

        /// <summary>
        /// 生成随机数字+大小写字母
        /// </summary>
        /// <param name="Length">生成长度</param>
        /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
        public static string RandomNumberAndUppercaseAndLowerCaseLetters(int Length, bool Sleep)
        {
            return Create(Length, Sleep, MergeArray(NumberList, LowCharList, UpCharList, null, null));
        }
        #endregion

        #region 生成随机符号
        /// <summary>
        /// 生成随机符号
        /// </summary>
        /// <param name="Length">生成长度</param>
        public static string RandomSymbol(int Length)
        {
            return Create(Length, false, SymbolList);
        }

        /// <summary>
        /// 生成随机符号
        /// </summary>
        /// <param name="Length">生成长度</param>
        /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
        public static string RandomSymbol(int Length, bool Sleep)
        {
            return Create(Length, Sleep, SymbolList);
        }
        #endregion

        #region 生成随机汉字
        public static string RandomChineseCharacter(int Length)
        {
            //获取GB2312编码页（表）
            Encoding gb = Encoding.GetEncoding("gb2312");

            //调用函数产生4个随机中文汉字编码
            object[] bytes = CreateRandomChineseCharacter(Length);

            //根据汉字编码的字节数组解码出中文汉字
            string result = string.Empty;

            for (int i = 0; i < Length; i++)
            {
                result += gb.GetString((byte[])Convert.ChangeType(bytes[i], typeof(byte[])));
            }
            return result;
        }
        #endregion

        #region 生成随机汉字方法
        /// <summary>
        /// 此函数在汉字编码范围内随机创建含两个元素的十六进制字节数组，每个字节数组代表一个汉字，并将四个字节数组存储在object数组中。
        /// </summary>
        /// <param name="strlength">需要产生的汉字个数</param>
        /// <returns></returns>
        public static object[] CreateRandomChineseCharacter(int strlength)
        {
            //定义一个字符串数组储存汉字编码的组成元素
            string[] rBase = new String[16] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f" };

            Random rnd = new Random();

            //定义一个object数组用来
            object[] bytes = new object[strlength];

            /*
             * 每循环一次产生一个含两个元素的十六进制字节数组，并将其放入bject数组中
             * 每个汉字有四个区位码组成
             * 区位码第1位和区位码第2位作为字节数组第一个元素
             * 区位码第3位和区位码第4位作为字节数组第二个元素
            */
            for (int i = 0; i < strlength; i++)
            {
                //区位码第1位
                int r1 = rnd.Next(11, 14);
                string str_r1 = rBase[r1].Trim();

                //区位码第2位
                rnd = new Random(r1 * unchecked((int)DateTime.Now.Ticks) + i);//更换随机数发生器的

                //种子避免产生重复值
                int r2;
                if (r1 == 13)
                {
                    r2 = rnd.Next(0, 7);
                }
                else
                {
                    r2 = rnd.Next(0, 16);
                }
                string str_r2 = rBase[r2].Trim();

                //区位码第3位
                rnd = new Random(r2 * unchecked((int)DateTime.Now.Ticks) + i);
                int r3 = rnd.Next(10, 16);
                string str_r3 = rBase[r3].Trim();

                //区位码第4位
                rnd = new Random(r3 * unchecked((int)DateTime.Now.Ticks) + i);
                int r4;
                if (r3 == 10)
                {
                    r4 = rnd.Next(1, 16);
                }
                else if (r3 == 15)
                {
                    r4 = rnd.Next(0, 15);
                }
                else
                {
                    r4 = rnd.Next(0, 16);
                }
                string str_r4 = rBase[r4].Trim();

                //定义两个字节变量存储产生的随机汉字区位码
                byte byte1 = Convert.ToByte(str_r1 + str_r2, 16);
                byte byte2 = Convert.ToByte(str_r3 + str_r4, 16);
                //将两个字节变量存储在字节数组中
                byte[] str_r = new byte[] { byte1, byte2 };

                //将产生的一个汉字的字节数组放入object数组中
                bytes.SetValue(str_r, i);
            }
            return bytes;
        }
        #endregion

        #region 生成随机数字+小写字母+大写字母+符号+汉字
        /// <summary>
        /// 生成随机数字+小写字母+大写字母+符号+汉字
        /// </summary>
        /// <param name="Length">生成长度</param>
        public static string RandomMixed(int Length)
        {
            //return MergeArray(NumberList, LowCharList, UpCharList, SymbolList,null).Length.ToString();
            ChineseCharacterList = RandomChineseCharacter(77).ToArray();
            return Create(Length, false, MergeArray(NumberList, LowCharList, UpCharList, SymbolList, ChineseCharacterList));
        }

        /// <summary>
        /// 生成随机数字+小写字母+大写字母+符号+汉字
        /// </summary>
        /// <param name="Length">生成长度</param>
        /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
        public static string RandomMixed(int Length, bool Sleep)
        {
            ChineseCharacterList = RandomChineseCharacter(77).ToArray();
            return Create(Length, Sleep, MergeArray(NumberList, LowCharList, UpCharList, SymbolList, ChineseCharacterList));
        }
        #endregion

        #region 生成随机GUID
        /// <summary>
        /// 生成随机GUID
        /// </summary>
        /// <param name="Length">生成长度</param>
        public static string GUID()
        {
            /*
             * 1  var uuid  = Guid.NewGuid().ToString();    // 9af7f46a-ea52-4aa3-b8c3-9fd484c2af12
             * 2  var uuidN = Guid.NewGuid().ToString("N"); // e0a953c3ee6040eaa9fae2b667060e09
             * 3  var uuidD = Guid.NewGuid().ToString("D"); // 9af7f46a-ea52-4aa3-b8c3-9fd484c2af12
             * 4  var uuidB = Guid.NewGuid().ToString("B"); // {734fd453-a4f8-4c5d-9c98-3fe2d7079760}
             * 5  var uuidP = Guid.NewGuid().ToString("P"); // (ade24d16-db0f-40af-8794-1e08e2040df3)
             * 6  var uuidX = Guid.NewGuid().ToString("X"); // {0x3fa412e3,0x8356,0x428f,{0xaa,0x34,0xb7,0x40,0xda,0xaf,0x45,0x6f}}
             */
            return Guid.NewGuid().ToString();
        }
        #endregion

        #region 字符串转成数组样式
        /// <summary>
        /// 将字符串转成数组样式
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns></returns>
        public static string StringToArray(string str)
        {
            string result = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                result += "'" + str.Substring(i, 1) + "'";
                if (i < str.Length - 1)
                {
                    result += ",";
                }
            }
            return result;
        }
        #endregion

        #region 合并数组

        #region （已注释）使用下面新方法，如没有数组4、数组5可传null
        /// <summary>
        /// 合并两个数组
        /// </summary>
        /// <param name="List1">数组1</param>
        /// <param name="List2">数组2</param>
        /// <returns>合并后的数组</returns>
        /*private static char[] MergeArray(char[] List1, char[] List2)
        {
            char[] Merge = null;
            List<char> list = new List<char>();
            list.AddRange(List1);
            list.AddRange(List2);
            Merge = list.ToArray();
            return Merge;
        }

        /// <summary>
        /// 合并三个数组
        /// </summary>
        /// <param name="List1">数组1</param>
        /// <param name="List2">数组2</param>
        /// <param name="List3">数组3</param>
        /// <returns>合并后的数组</returns>
        private static char[] MergeArray(char[] List1, char[] List2, char[] List3)
        {
            char[] Merge = null;
            List<char> list = new List<char>();
            list.AddRange(List1);
            list.AddRange(List2);
            list.AddRange(List3);
            Merge = list.ToArray();
            return Merge;
        }*/
        #endregion

        /// <summary>
        /// 合并五个数组
        /// </summary>
        /// <param name="List1">数组1</param>
        /// <param name="List2">数组2</param>
        /// <param name="List3">数组3</param>
        /// <param name="List4">数组4</param>
        /// <param name="List5">数组5</param>
        /// <returns>合并后的数组</returns>
        private static char[] MergeArray(char[] List1, char[] List2, char[] List3, char[] List4, char[] List5)
        {
            char[] Merge = null;
            List<char> list = new List<char>();
            if (List1 != null && List1.Length > 0)
            {
                list.AddRange(List1);
            }
            if (List2 != null && List2.Length > 0)
            {
                list.AddRange(List2);
            }
            if (List3 != null && List3.Length > 0)
            {
                list.AddRange(List3);
            }
            if (List4 != null && List4.Length > 0)
            {
                list.AddRange(List4);
            }
            if (List5 != null && List5.Length > 0)
            {
                list.AddRange(List5);
            }
            Merge = list.ToArray();
            return Merge;
        }
        #endregion

        #region 生成随机值
        /// <summary>
        /// 生成随机值
        /// </summary>
        /// <returns>随机值</returns>
        /// <param name="Length">生成长度</param>
        /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
        /// <param name="List">字典</param>
        private static string Create(int Length, bool Sleep, char[] List)
        {
            if (Sleep) Thread.Sleep(3);
            char[] Pattern = List;
            string result = string.Empty;
            int n = Pattern.Length;

            for (int i = 0; i < Length; i++)
            {
                int rnd = Random.Next(0, n);
                result += Pattern[rnd];
            }
            return result;
        }
        #endregion
    }
}