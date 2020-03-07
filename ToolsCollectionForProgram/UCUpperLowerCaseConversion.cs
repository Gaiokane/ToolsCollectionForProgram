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
    public partial class UCUpperLowerCaseConversion : UserControl
    {
        public UCUpperLowerCaseConversion()
        {
            InitializeComponent();
        }

        #region 小写转大写-小写文本框双击事件 全选
        private void richtxtboxLowerToUpperLower_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            richtxtboxLowerToUpperLower.SelectAll();
            richtxtboxLowerToUpperLower.Focus();
        }
        #endregion

        #region 小写转大写-大写文本框单击事件 转换+全选
        private void richtxtboxLowerToUpperUpper_MouseClick(object sender, MouseEventArgs e)
        {
            richtxtboxLowerToUpperUpper.Text = richtxtboxLowerToUpperLower.Text.Trim().ToUpper();
            richtxtboxLowerToUpperUpper.SelectAll();
            richtxtboxLowerToUpperUpper.Focus();
        }
        #endregion

        #region 大写转小写-小写文本框双击事件 全选
        private void richtxtboxUpperToLowerUpper_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            richtxtboxUpperToLowerUpper.SelectAll();
            richtxtboxUpperToLowerUpper.Focus();
        }
        #endregion

        #region 大写转小写-大写文本框单击事件 转换+全选
        private void richtxtboxUpperToLowerLower_MouseClick(object sender, MouseEventArgs e)
        {
            richtxtboxUpperToLowerLower.Text = richtxtboxUpperToLowerUpper.Text.Trim().ToLower();
            richtxtboxUpperToLowerLower.SelectAll();
            richtxtboxUpperToLowerLower.Focus();
        }
        #endregion
    }
}