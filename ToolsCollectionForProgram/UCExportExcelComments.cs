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
    public partial class UCExportExcelComments : UserControl
    {
        public UCExportExcelComments()
        {
            InitializeComponent();
        }

        private void UCExportExcelComments_Load(object sender, EventArgs e)
        {
            textBox1.Text = "双击选择Excel文件路径";
            textBox1.ForeColor = Color.DarkGray;

            radioButton1.Checked = true;
            textBox2.Visible = false;
            label1.Visible = false;
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择Excel文件";
            ofd.Filter = "Excel文件(*.xls,*.xlsx)|*.xls;*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox2.Visible = false;
                label1.Visible = false;
            }
            else
            {
                textBox2.Visible = true;
                label1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //导出全部Sheet页批注
            if (radioButton1.Checked == true)
            {
                //MessageBox.Show(ExcelHelper.ReadExcelCommentBySheet(textBox1.Text.Trim()));
                Clipboard.SetDataObject(ExcelHelper.ReadExcelCommentBySheet(textBox1.Text.Trim()));
                MessageBox.Show("所选Excel全部Sheet页批注已复制到剪切板");
            }
            //导出指定Sheet页批注
            else
            {
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("请输入Sheet页编号，从0开始");
                    textBox2.Focus();
                }
                else
                {
                    int index = Convert.ToInt32(textBox2.Text);
                    //MessageBox.Show(ExcelHelper.ReadExcelCommentBySheet(textBox1.Text, index));
                    Clipboard.SetDataObject(ExcelHelper.ReadExcelCommentBySheet(textBox1.Text, index));
                    MessageBox.Show("所选Excel Sheet" + index + "批注已复制到剪切板");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "双击选择Excel文件路径")
            {
                textBox1.ForeColor = Color.Black;
            }
            else
            {
                textBox1.ForeColor = Color.DarkGray;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}