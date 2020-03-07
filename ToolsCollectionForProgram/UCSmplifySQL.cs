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
    public partial class UCSmplifySQL : UserControl
    {
        public UCSmplifySQL()
        {
            InitializeComponent();
        }

        #region 原SQL文本框双击事件 全选
        private void richtxtboxOld_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            richtxtboxOld.SelectAll();
            richtxtboxOld.Focus();
        }
        #endregion

        #region 简化后SQL文本框单击事件 简化+全选
        private void richtxtboxNew_MouseClick(object sender, MouseEventArgs e)
        {
            string oldSql = richtxtboxOld.Text;
            richtxtboxNew.Text = oldSql.Replace("\n", " ").Replace("\t", " ").Replace("\r", " ");
            richtxtboxNew.SelectAll();
            richtxtboxNew.Focus();
        }
        #endregion
    }
}