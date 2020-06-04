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
    public partial class UCCount : UserControl
    {
        public UCCount()
        {
            InitializeComponent();
        }

        private void UCCount_Load(object sender, EventArgs e)
        {
            //RichTextBox增加右键菜单
            RichTextBoxMenu richTextBoxMenu_richTextBox1 = new RichTextBoxMenu(richTextBox1);

            label1.Text = "字符串中字符个数：";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "字符串中字符个数：" + richTextBox1.Text.Length;
        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.SelectAll();
        }
    }
}