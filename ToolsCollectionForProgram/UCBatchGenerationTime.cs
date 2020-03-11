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

        private void UCBatchGenerationTime_Load(object sender, EventArgs e)
        {
            dtpBeginTime.Format = DateTimePickerFormat.Custom;
            dtpBeginTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            txtboxDateTimeFormat.Text = "yyyy-MM-dd HH:mm:ss";

            radiobtnSeconds.Checked = true;
        }

        private void richtxtboxResultDate_MouseClick(object sender, MouseEventArgs e)
        {
            richtxtboxResultDate.Text = "";
            DateTime dt = dtpBeginTime.Value;
            string result = "";
            for (int i = 0; i < Convert.ToInt32(txtboxLength.Text); i++)
            {
                if (radiobtnSeconds.Checked == true)
                {
                    result += dt.AddSeconds(i * Convert.ToInt32(txtboxTimeInterval.Text)).ToString(txtboxDateTimeFormat.Text);
                }
                if (radiobtnMinutes.Checked == true)
                {
                    result += dt.AddMinutes(i * Convert.ToInt32(txtboxTimeInterval.Text)).ToString(txtboxDateTimeFormat.Text);
                }
                if (radiobtnHours.Checked == true)
                {
                    result += dt.AddHours(i * Convert.ToInt32(txtboxTimeInterval.Text)).ToString(txtboxDateTimeFormat.Text);
                }
                if (radiobtnDays.Checked == true)
                {
                    result += dt.AddDays(i * Convert.ToInt32(txtboxTimeInterval.Text)).ToString(txtboxDateTimeFormat.Text);
                }
                if (i + 1 < Convert.ToInt32(txtboxLength.Text))
                {
                    result += "\n";
                }
            }
            richtxtboxResultDate.Text = result;
        }
    }
}