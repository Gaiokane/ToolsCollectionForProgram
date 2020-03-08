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
    public partial class UCEntityClassAssignment : UserControl
    {
        public UCEntityClassAssignment()
        {
            InitializeComponent();
        }

        #region 结果文本框鼠标单击事件 返回结果并全选
        private void richtxtboxResult_MouseClick(object sender, MouseEventArgs e)
        {
            //将实体类型属性按照换行转为数组
            string[] attribute = richtxtboxEntityClassAttribute.Text.Split('\n');
            string result = "";
            for (int i = 0; i < attribute.Length; i++)
            {
                //result += txtboxLeftEntityClassName.Text + "." + attribute[i] + " = " + txtboxRightEntityClassName.Text + "." + attribute[i]+"\n";
                if (string.IsNullOrEmpty(txtboxLeftEntityClassName.Text))
                {
                    //左实体类名为空时，=左边直接显示实体类属性
                    result += attribute[i];
                }
                else
                {
                    //左实体类名不为空时，=左边带上左实体类名+.+实体类属性
                    result += txtboxLeftEntityClassName.Text + "." + attribute[i];
                }
                //=连接
                result += " = ";
                if (string.IsNullOrEmpty(txtboxRightEntityClassName.Text))
                {
                    //右实体类名为空时，=右边直接显示实体类属性且全部转小写
                    result += attribute[i].ToLower();
                }
                else
                {
                    //右实体类名不为空时，=右边带上右实体类名+.+实体类属性
                    result += txtboxRightEntityClassName.Text + "." + attribute[i];
                }
                //结尾加上;
                result += ";";
                //判断是否为最后一行，不是则换行
                if (i + 1 != attribute.Length)
                {
                    result += "\n";
                }
            }
            richtxtboxResult.Text = result;
            richtxtboxResult.SelectAll();
        }
        #endregion
    }
}