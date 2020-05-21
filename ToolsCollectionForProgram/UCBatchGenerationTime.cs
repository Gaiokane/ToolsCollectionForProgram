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
    public partial class UCBatchGenerationTime : UserControl
    {
        public UCBatchGenerationTime()
        {
            InitializeComponent();
        }

        #region 窗体加载事件 赋默认值
        private void UCBatchGenerationTime_Load(object sender, EventArgs e)
        {
            //设置dtp自定义格式
            dtpBeginTime.Format = DateTimePickerFormat.Custom;
            //指定dtp格式
            dtpBeginTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            //默认时间格式 fff为毫秒
            txtboxDateTimeFormat.Text = "yyyy-MM-dd HH:mm:ss.fff";
            //默认长度
            txtboxLength.Text = "5";
            //默认时间间隔
            txtboxTimeInterval.Text = "1";

            //秒单选按钮默认选中
            radiobtnSeconds.Checked = true;

            //排序升序单选按钮默认选中
            radiobtnSortAsc.Checked = true;
        }
        #endregion

        #region 结果文本框点击事件 主要逻辑
        private void richtxtboxResultDate_MouseClick(object sender, MouseEventArgs e)
        {
            //时间格式文本框判空
            if (string.IsNullOrEmpty(txtboxDateTimeFormat.Text) || string.IsNullOrWhiteSpace(txtboxDateTimeFormat.Text))
            {
                MessageBox.Show("时间格式不能为空！");
                txtboxDateTimeFormat.Focus();
            }
            else
            {
                //长度文本框判空
                if (string.IsNullOrEmpty(txtboxLength.Text) || string.IsNullOrWhiteSpace(txtboxLength.Text))
                {
                    MessageBox.Show("长度不能为空！");
                    txtboxLength.Focus();
                }
                else
                {
                    //时间间隔文本框判空
                    if (string.IsNullOrEmpty(txtboxTimeInterval.Text) || string.IsNullOrWhiteSpace(txtboxTimeInterval.Text))
                    {
                        MessageBox.Show("时间间隔不能为空！");
                        txtboxTimeInterval.Focus();
                    }
                    else
                    {
                        try
                        {
                            //清空结果文本框
                            richtxtboxResultDate.Text = "";
                            //dt取dtp时间
                            DateTime dt = dtpBeginTime.Value;
                            //定义结果字符串
                            string result = "";
                            //根据长度循环
                            for (int i = 0; i < Convert.ToInt32(txtboxLength.Text); i++)
                            {
                                if (radiobtnSeconds.Checked == true)//秒
                                {
                                    //在起始时间基础上加上时间间隔，并转换成指定时间格式
                                    result += dt.AddSeconds(i * Convert.ToInt32(txtboxTimeInterval.Text)).ToString(txtboxDateTimeFormat.Text);
                                }
                                if (radiobtnMinutes.Checked == true)//分钟
                                {
                                    //在起始时间基础上加上时间间隔，并转换成指定时间格式
                                    result += dt.AddMinutes(i * Convert.ToInt32(txtboxTimeInterval.Text)).ToString(txtboxDateTimeFormat.Text);
                                }
                                if (radiobtnHours.Checked == true)//小时
                                {
                                    //在起始时间基础上加上时间间隔，并转换成指定时间格式
                                    result += dt.AddHours(i * Convert.ToInt32(txtboxTimeInterval.Text)).ToString(txtboxDateTimeFormat.Text);
                                }
                                if (radiobtnDays.Checked == true)//日
                                {
                                    //在起始时间基础上加上时间间隔，并转换成指定时间格式
                                    result += dt.AddDays(i * Convert.ToInt32(txtboxTimeInterval.Text)).ToString(txtboxDateTimeFormat.Text);
                                }
                                //如果不是最后一条，加上换行
                                if (i + 1 < Convert.ToInt32(txtboxLength.Text))
                                {
                                    result += "\n";
                                }
                            }
                            //赋值给结果文本框
                            //richtxtboxResultDate.Text = result;

                            if (radiobtnSortAsc.Checked == true)
                            {
                                richtxtboxResultDate.Text = SortStr(result, "+");
                            }
                            if (radiobtnSortDesc.Checked == true)
                            {
                                richtxtboxResultDate.Text = SortStr(result, "-");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }
        #endregion

        #region 长度文本框只能输入数字
        private void txtboxLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region 时间间隔文本框只能输入数字
        private void txtboxTimeInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region 对list中元素进行排序
        /// <summary>
        /// 对list中元素进行排序
        /// </summary>
        /// <param name="Str">字符串</param>
        /// <param name="Sort">升序：+，倒叙：-</param>
        /// <returns>返回排序完的字符串，以\n分割</returns>
        private string SortStr(string Str, string Sort)
        {
            if (string.IsNullOrEmpty(Str) == true)
            {
                return Str;
            }
            else
            {
                List<string> list = Str.Split(new string[] { "\n" }, StringSplitOptions.None).ToList();
                if (Sort == "+")
                {
                    list.Sort();
                }
                else if (Sort == "-")
                {
                    list.Reverse();
                }
                else
                {
                    list.Sort();
                }
                return String.Join("\n", list.ToArray()).Trim();
            }
        }
        #endregion

        #region 排序方式单选按钮单击事件
        private void radiobtnSortAsc_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnSortAsc.Checked == true)
            {
                richtxtboxResultDate.Text = SortStr(richtxtboxResultDate.Text, "+");
            }
            if (radiobtnSortDesc.Checked == true)
            {
                richtxtboxResultDate.Text = SortStr(richtxtboxResultDate.Text, "-");
            }
        }
        #endregion
    }
}