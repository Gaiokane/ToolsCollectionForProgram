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
    public partial class UCGenerateRandomStrings : UserControl
    {
        public UCGenerateRandomStrings()
        {
            InitializeComponent();
        }

        #region 生成按钮单击事件
        private void btn_generate_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = GenerateRandomValue.StringToArray(txtbox_length.Text);

            #region 给radioButton赋值
            int radiobtn_value = 0;
            if (radiobtn_Number.Checked == true)//数字
            {
                radiobtn_value = 1;
            }
            else if (radiobtn_LowerCaseLetters.Checked == true)//小写字母
            {
                radiobtn_value = 2;
            }
            else if (radiobtn_UpperCaseLetters.Checked == true)//大写字母
            {
                radiobtn_value = 3;
            }
            else if (radiobtn_UppercaseAndLowerCaseLetters.Checked == true)//大小写字母
            {
                radiobtn_value = 4;
            }
            else if (radiobtn_NumberAndLowerCaseLetters.Checked == true)//数字+小写字母
            {
                radiobtn_value = 5;
            }
            else if (radiobtn_NumberAndUpperCaseLetters.Checked == true)//数字+大写字母
            {
                radiobtn_value = 6;
            }
            else if (radiobtn_NumberAndUppercaseAndLowerCaseLetters.Checked == true)//数字+大小写字母
            {
                radiobtn_value = 7;
            }
            else if (radiobtn_Symbol.Checked == true)//符号
            {
                radiobtn_value = 8;
            }
            else if (radiobtn_ChineseCharacter.Checked == true)//汉字
            {
                radiobtn_value = 9;
            }
            else if (radiobtn_Mixed.Checked == true)//混合
            {
                radiobtn_value = 10;
            }
            else if (radiobtn_GUID.Checked == true)//GUID
            {
                radiobtn_value = 11;
            }
            #endregion

            #region switch case处理
            switch (radiobtn_value)
            {
                case 1://数字
                    richTextBox1.Text = GenerateRandomValue.RandomNumber(GetLength(txtbox_length));
                    break;
                case 2://小写字母
                    richTextBox1.Text = GenerateRandomValue.RandomLowerCaseLetters(GetLength(txtbox_length));
                    break;
                case 3://大写字母
                    richTextBox1.Text = GenerateRandomValue.RandomUpperCaseLetters(GetLength(txtbox_length));
                    break;
                case 4://大小写字母
                    richTextBox1.Text = GenerateRandomValue.RandomUppercaseAndLowerCaseLetters(GetLength(txtbox_length));
                    break;
                case 5://数字+小写字母
                    richTextBox1.Text = GenerateRandomValue.RandomNumberAndLowerCaseLetters(GetLength(txtbox_length));
                    break;
                case 6://数字+大写字母
                    richTextBox1.Text = GenerateRandomValue.RandomNumberAndUpperCaseLetters(GetLength(txtbox_length));
                    break;
                case 7://数字+大小写字母
                    richTextBox1.Text = GenerateRandomValue.RandomNumberAndUppercaseAndLowerCaseLetters(GetLength(txtbox_length));
                    break;
                case 8://符号
                    richTextBox1.Text = GenerateRandomValue.RandomSymbol(GetLength(txtbox_length));
                    break;
                case 9://汉字
                    richTextBox1.Text = GenerateRandomValue.RandomChineseCharacter(GetLength(txtbox_length));
                    break;
                case 10://混合
                    richTextBox1.Text = GenerateRandomValue.RandomMixed(GetLength(txtbox_length));
                    break;
                case 11://GUID
                    richTextBox1.Text = GenerateRandomValue.GUID();
                    break;
                default:
                    break;
            }
            #endregion
        }
        #endregion

        #region 长度文本框单击事件
        private void txtbox_length_MouseClick(object sender, MouseEventArgs e)
        {
            txtbox_length.SelectAll();
        }
        #endregion

        #region 获取长度文本框输入的值，含判断
        private static int GetLength(TextBox txtbox)
        {
            int result = 0;
            if (IsNumber(txtbox.Text.Trim()) == true)
            {
                result = Convert.ToInt32(txtbox.Text.Trim());
            }
            else
            {
                MessageBox.Show("请输入数字！");
            }
            return result;
        }
        #endregion

        #region 富文本框单击事件
        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.Focus();
        }
        #endregion

        #region 判断字符串是否为数字
        /// <summary>
        /// 判断字符串是否为数字
        /// </summary>
        /// <param name="str">待验证的字符串</param>
        /// <returns>bool</returns>
        public static bool IsNumber(string str)
        {
            bool result = true;
            foreach (char ar in str)
            {
                if (!char.IsNumber(ar))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        #endregion

        #region 窗体加载事件 单选按钮默认选择数字
        private void UCGenerateRandomStrings_Load(object sender, EventArgs e)
        {
            radiobtn_Number.Checked = true;
        }
        #endregion
    }
}