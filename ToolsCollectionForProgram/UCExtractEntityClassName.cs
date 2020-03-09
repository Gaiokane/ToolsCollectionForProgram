using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolsCollectionForProgram
{
    public partial class UCExtractEntityClassName : UserControl
    {
        public UCExtractEntityClassName()
        {
            InitializeComponent();
        }

        private void richtxtboxEntityClass_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            richtxtboxEntityClass.SelectAll();
        }

        #region 实体类名文本框点击事件 实体类提取实体类名
        private void richtxtboxEntityClassName_MouseClick(object sender, MouseEventArgs e)
        {
            /*
             * public int Id { get; set; }
             * public string Commodityname { get; set; }
             */

            string result = "";
            //按换行分割
            string[] entityClass = richtxtboxEntityClass.Text.Split('\n');
            for (int i = 0; i < entityClass.Length; i++)
            {
                //按{分割
                string[] str = entityClass[i].Split('{');
                //按空格分割
                string[] spacestr = str[0].Split(' ');
                //判断最后一位是否为空格
                if (string.IsNullOrWhiteSpace(spacestr[spacestr.Length - 1]))
                {
                    //是空格取-1
                    result += spacestr[spacestr.Length - 2];
                }
                else
                {
                    //不是空格就取当前
                    result += spacestr[spacestr.Length - 1];
                }
                //判断是否为最后一行，不是则换行
                if (i + 1 != entityClass.Length)
                {
                    result += "\n";
                }
            }
            richtxtboxEntityClassName.Text = result;
        }
        #endregion
    }
}