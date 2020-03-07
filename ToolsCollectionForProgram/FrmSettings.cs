using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolsCollectionForProgram
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        #region 设置该窗口只能打开一个，配合按钮设置
        private static FrmSettings fs = new FrmSettings();
        public static FrmSettings GetFrmSettings()
        {
            if (fs.IsDisposed)
            {
                fs = new FrmSettings();
                return fs;
            }
            else
            {
                return fs;
            }
        }
        #endregion
    }
}