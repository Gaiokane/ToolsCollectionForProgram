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
    public partial class UCTimeDifferenceCalculator : UserControl
    {
        public UCTimeDifferenceCalculator()
        {
            InitializeComponent();
        }

        #region 窗体加载事件
        private void UCTimeDifferenceCalculator_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }
        #endregion

        #region 返回两个时间的间隔
        /// <summary>
        /// 返回两个时间的间隔
        /// </summary>
        /// <param name="DateTime1">时间1</param>
        /// <param name="DateTime2">时间2</param>
        /// <returns>x天x小时x分钟x秒</returns>
        private string DateDiff(DateTime DateTime1, DateTime DateTime2)
        {
            string dateDiff = null;
            TimeSpan ts1 = new TimeSpan(DateTime1.Ticks);
            TimeSpan ts2 = new TimeSpan(DateTime2.Ticks);
            TimeSpan ts = ts1.Subtract(ts2).Duration();
            dateDiff = ts.Days.ToString() + "天"
                + ts.Hours.ToString() + "小时"
                + ts.Minutes.ToString() + "分钟"
                + ts.Seconds.ToString() + "秒";

            return dateDiff;
        }
        #endregion

        #region 结果文本框单击事件 返回时间差
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = DateDiff(dateTimePicker1.Value, dateTimePicker2.Value);
            textBox1.SelectAll();
            textBox1.Focus();
        }
        #endregion
    }
}