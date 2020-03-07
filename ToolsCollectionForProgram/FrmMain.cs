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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            panel1.AllowDrop = true;
            panel2.AllowDrop = true;
            panel3.AllowDrop = true;
            panel4.AllowDrop = true;

            btnCommonFunctions1.Text = "简化SQL";
        }

        #region 右侧常用功能按钮拖拽效果
        private void btnCommonFunctions1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                btnCommonFunctions1.DoDragDrop(btnCommonFunctions1, DragDropEffects.Copy);//发送的拖拽效果
            }
        }

        private void btnCommonFunctions2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                btnCommonFunctions2.DoDragDrop(btnCommonFunctions2, DragDropEffects.Copy);
            }
        }

        private void btnCommonFunctions3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                btnCommonFunctions3.DoDragDrop(btnCommonFunctions3, DragDropEffects.Copy);
            }
        }

        private void btnCommonFunctions4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                btnCommonFunctions4.DoDragDrop(btnCommonFunctions4, DragDropEffects.Copy);
            }
        }

        private void btnCommonFunctions5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                btnCommonFunctions5.DoDragDrop(btnCommonFunctions5, DragDropEffects.Copy);
            }
        }

        private void btnCommonFunctions6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                btnCommonFunctions6.DoDragDrop(btnCommonFunctions6, DragDropEffects.Copy);
            }
        }

        private void btnCommonFunctions7_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                btnCommonFunctions7.DoDragDrop(btnCommonFunctions7, DragDropEffects.Copy);
            }
        }

        private void btnCommonFunctions8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                btnCommonFunctions8.DoDragDrop(btnCommonFunctions8, DragDropEffects.Copy);
            }
        }

        private void btnCommonFunctions9_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                btnCommonFunctions9.DoDragDrop(btnCommonFunctions9, DragDropEffects.Copy);
            }
        }
        #endregion

        #region 获取拖拽到Panel上的按钮Text值
        /// <summary>
        /// 获取拖拽到Panel上的按钮Text值
        /// </summary>
        /// <param name="btnData">按钮Data，e.Data.GetData</param>
        /// <returns>返回按钮Text值</returns>
        private string getBtnText(string btnData)
        {
            string[] temp = btnData.Split(' ');
            return temp[2];
        }
        #endregion

        #region 传入按钮Text值，获取对应窗体
        /// <summary>
        /// 传入按钮Text值，获取对应窗体
        /// </summary>
        /// <param name="btnName">按钮Text</param>
        /// <returns>返回Control</returns>
        private Control GetUserControlNameByButtonName(string btnName)
        {
            if (btnName == "简化SQL")
            {
                UCSmplifySQL ucss = new UCSmplifySQL();
                return ucss;
            }
            else
            {
                UCNull ucnull = new UCNull();
                return ucnull;
            }
        }
        #endregion

        #region 右侧常用功能按钮拖拽到panel上显示copy效果
        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Button)))
            {
                //接收拖拽来的效果，Copy为直接收DragDropEffects.Copy
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Button)))
            {
                //接收拖拽来的效果，Copy为直接收DragDropEffects.Copy
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panel3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Button)))
            {
                //接收拖拽来的效果，Copy为直接收DragDropEffects.Copy
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panel4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Button)))
            {
                //接收拖拽来的效果，Copy为直接收DragDropEffects.Copy
                e.Effect = DragDropEffects.Copy;
            }
        }
        #endregion

        #region 按钮拖拽到panel上，panel根据按钮Text打开对应用户控件
        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            //获取拖拽到该控件上按钮的Text值
            string btnname = getBtnText(e.Data.GetData(typeof(Button)).ToString());
            //MessageBox.Show(btnname);
            //获取拖拽到该控件上按钮名字对应的用户控件
            Control frm = GetUserControlNameByButtonName(btnname);
            //清空当前panel
            panel1.Controls.Clear();
            //绑定用户控件
            panel1.Controls.Add(frm);
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            //获取拖拽到该控件上按钮的Text值
            string btnname = getBtnText(e.Data.GetData(typeof(Button)).ToString());
            //MessageBox.Show(btnname);
            //获取拖拽到该控件上按钮名字对应的用户控件
            Control frm = GetUserControlNameByButtonName(btnname);
            //清空当前panel
            panel2.Controls.Clear();
            //绑定用户控件
            panel2.Controls.Add(frm);
        }

        private void panel3_DragDrop(object sender, DragEventArgs e)
        {
            //获取拖拽到该控件上按钮的Text值
            string btnname = getBtnText(e.Data.GetData(typeof(Button)).ToString());
            //MessageBox.Show(btnname);
            //获取拖拽到该控件上按钮名字对应的用户控件
            Control frm = GetUserControlNameByButtonName(btnname);
            //清空当前panel
            panel3.Controls.Clear();
            //绑定用户控件
            panel3.Controls.Add(frm);
        }

        private void panel4_DragDrop(object sender, DragEventArgs e)
        {
            //获取拖拽到该控件上按钮的Text值
            string btnname = getBtnText(e.Data.GetData(typeof(Button)).ToString());
            //MessageBox.Show(btnname);
            //获取拖拽到该控件上按钮名字对应的用户控件
            Control frm = GetUserControlNameByButtonName(btnname);
            //清空当前panel
            panel4.Controls.Clear();
            //绑定用户控件
            panel4.Controls.Add(frm);
        }
        #endregion
    }
}