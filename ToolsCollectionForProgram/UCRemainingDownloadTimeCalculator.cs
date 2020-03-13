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
    public partial class UCRemainingDownloadTimeCalculator : UserControl
    {
        public UCRemainingDownloadTimeCalculator()
        {
            InitializeComponent();
        }

        #region 窗体加载事件 赋默认值
        private void UCRemainingDownloadTimeCalculator_Load(object sender, EventArgs e)
        {
            radioBtnMB.Checked = true;
            radioBtnKBs.Checked = true;

            txtboxSize.Text = "100";
            txtboxSpeed.Text = "600";
        }
        #endregion

        #region 计算按钮单击事件
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxSize.Text) || string.IsNullOrWhiteSpace(txtboxSize.Text))
            {
                MessageBox.Show("大小不能为空！");
                txtboxSize.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(txtboxSpeed.Text) || string.IsNullOrWhiteSpace(txtboxSpeed.Text))
                {
                    MessageBox.Show("下载速度不能为空！");
                    txtboxSpeed.Focus();
                }
                else
                {
                    double size = Convert.ToDouble(txtboxSize.Text);//radioBtnMB.Checked==true
                    double speed = Convert.ToDouble(txtboxSpeed.Text);//radioBtnKBs.Checked==true

                    if (radioBtnGB.Checked == true)
                    {
                        size = size * 1024;
                    }
                    if (radioBtnMBs.Checked == true)
                    {
                        speed = speed * 1024;
                    }

                    labelTimeLeft.Text = "剩余：" + DownloadTime(size, speed);
                }
            }
        }
        #endregion

        #region 根据文件大小和下载速度计算剩余下载时间
        /// <summary>
        /// 根据文件大小和下载速度计算剩余下载时间
        /// </summary>
        /// <param name="Size">文件大小，单位MB</param>
        /// <param name="Speed">下载速度，单位KB/s</param>
        /// <returns>返回剩余时间（含单位）</returns>
        private string DownloadTime(double Size, double Speed)
        {
            //MessageBox.Show("70/60:" + 59 / 60 + "\n70%60:" + 59 % 60);
            double secondsRemaining = Size * 1024 / Speed;//剩余秒数
            int minutesRemaining = Convert.ToInt32(secondsRemaining) / 60;//剩余分钟
            int hoursRemaining = minutesRemaining / 60;//剩余小时
            int daysRemaining = hoursRemaining / 24;//剩余天数


            //MessageBox.Show((time % 60).ToString());
            if (secondsRemaining < 60)//不超过1分钟
            {
                return secondsRemaining + "秒";
            }
            else//超过1分钟
            {
                if (minutesRemaining < 60)//不超过1小时
                {
                    //double[] minsec = intdec(minutesRemaining);
                    //MessageBox.Show("1:" + minsec[0] + "\n2:" + Math.Round(minsec[1]*60,7) + "\n3:" + Math.Ceiling(50.6));
                    //return minsec[0] + "分钟" + Math.Ceiling(minsec[1] * 60) + "秒";
                    return minutesRemaining + "分钟" + Math.Ceiling(secondsRemaining % 60) + "秒";
                }
                else//超过1小时
                {
                    if (hoursRemaining < 24)//不超过1天
                    {
                        return hoursRemaining + "小时" + minutesRemaining % 60 + "分钟" + Math.Ceiling(secondsRemaining % 60) + "秒";
                    }
                    else//超过1天
                    {
                        return daysRemaining + "天" + hoursRemaining % 24 + "小时" + minutesRemaining % 60 + "分钟" + Math.Ceiling(secondsRemaining % 60) + "秒";
                    }
                }
            }
        }
        #endregion

        #region 传入小数，返回整数和小数部分
        /// <summary>
        /// 传入小数，返回整数和小数部分
        /// </summary>
        /// <param name="num">需要分割的小数</param>
        /// <returns>double数组，[0]为整数部分，[1]为小数部分</returns>
        private double[] intdec(double num)
        {
            string[] temp = num.ToString().Split('.');
            double[] result = { Convert.ToDouble(temp[0]), Convert.ToDouble(temp[1]) };
            return result;
        }
        #endregion
    }
}