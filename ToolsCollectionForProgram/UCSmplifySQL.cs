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

        private void richtxtboxNew_MouseClick(object sender, MouseEventArgs e)
        {
            string oldSql = richtxtboxOld.Text;
            richtxtboxNew.Text = oldSql.Replace("\n", " ").Replace("\t", " ").Replace("\r", " ");
        }
    }
}