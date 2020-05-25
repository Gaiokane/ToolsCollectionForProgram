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
    public partial class UCTimeCalculator : UserControl
    {
        public UCTimeCalculator()
        {
            InitializeComponent();
        }

        #region 窗体加载事件
        private void UCTimeCalculator_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePicker2.CustomFormat = "HH:mm:ss";
            dateTimePicker2.Value = Convert.ToDateTime("08:00:00");

            radioButton1.Checked = true;
        }
        #endregion

        #region 计算按钮单击事件
        private void btnCalc_Click(object sender, EventArgs e)
        {
            int h = dateTimePicker2.Value.Hour;
            int m = dateTimePicker2.Value.Minute;
            int s = dateTimePicker2.Value.Second;

            DateTime dt = dateTimePicker1.Value;

            if (radioButton1.Checked == true)//+
            {
                dt = dt.AddHours(h);
                dt = dt.AddMinutes(m);
                dt = dt.AddSeconds(s);
            }
            else//-
            {
                dt = dt.AddHours(-h);
                dt = dt.AddMinutes(-m);
                dt = dt.AddSeconds(-s);
            }
            textBox1.Text = dt.ToString("yyyy-MM-dd HH:mm:ss");
        }
        #endregion
    }
}