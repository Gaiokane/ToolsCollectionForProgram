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
        int typeid = 0;//拖入panel的控件类型id，0：其他，1：button，2：ToolStripItem

        public FrmMain()
        {
            InitializeComponent();
        }

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
            if (btnName == "大小写转换")
            {
                UCUpperLowerCaseConversion uculcc = new UCUpperLowerCaseConversion();
                return uculcc;
            }
            if (btnName == "生成随机字符")
            {
                UCGenerateRandomStrings ucgrs = new UCGenerateRandomStrings();
                return ucgrs;
            }
            else
            {
                UCNull ucnull = new UCNull();
                return ucnull;
            }
        }
        #endregion

        #region 窗体加载事件
        private void FrmMain_Load(object sender, EventArgs e)
        {
            #region 常用功能按钮配置
            //panel支持拖放
            panel1.AllowDrop = true;
            panel2.AllowDrop = true;
            panel3.AllowDrop = true;
            panel4.AllowDrop = true;

            //读取常用功能按钮配置信息
            ConfigSettings.getDefaultBtnNameByappSettings();
            //若没有读到，赋默认值
            ConfigSettings.setDefaultBtnNameIfIsNullOrEmptyByappSettings();
            //重新读取常用功能按钮配置信息
            ConfigSettings.getDefaultBtnNameByappSettings();

            //将配置信息显示到按钮上
            btnCommonFunctions1.Text = ConfigSettings.btnname1;
            btnCommonFunctions2.Text = ConfigSettings.btnname2;
            btnCommonFunctions3.Text = ConfigSettings.btnname3;
            btnCommonFunctions4.Text = ConfigSettings.btnname4;
            btnCommonFunctions5.Text = ConfigSettings.btnname5;
            btnCommonFunctions6.Text = ConfigSettings.btnname6;
            btnCommonFunctions7.Text = ConfigSettings.btnname7;
            btnCommonFunctions8.Text = ConfigSettings.btnname8;
            btnCommonFunctions9.Text = ConfigSettings.btnname9;
            #endregion
        }
        #endregion

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

        #region 右侧常用功能按钮拖拽到panel上显示copy效果
        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            #region 该块只支持Button（已弃用），下方支持Button和ToolStripItem
            /*if (e.Data.GetDataPresent(typeof(Button)))
            {
                //接收拖拽来的效果，Copy为直接收DragDropEffects.Copy
                e.Effect = DragDropEffects.Copy;
            }*/
            #endregion

            //MessageBox.Show(简化SQLToolStripMenuItem.GetType().ToString());
            //MessageBox.Show(简化SQLToolStripMenuItem.GetType().ToString()+"\n"+ e.Data.GetFormats()[0]+"\n"+ e.Data.GetDataPresent(typeof(ToolStripItem)).ToString());
            //MessageBox.Show(e.Data.GetDataPresent(typeof(ToolStripItem)).ToString());
            if (e.Data.GetDataPresent(typeof(Button)))
            {
                //拖入panel的控件类型id，0：其他，1：button，2：ToolStripItem
                typeid = 1;
                //接收拖拽来的效果，Copy为直接收DragDropEffects.Copy
                e.Effect = DragDropEffects.Copy;
            }
            if (e.Data.GetDataPresent(typeof(ToolStripItem)))
            {
                //拖入panel的控件类型id，0：其他，1：button，2：ToolStripItem
                typeid = 2;
                //接收拖拽来的效果，Copy为直接收DragDropEffects.Copy
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            #region 该块只支持Button（已弃用），下方支持Button和ToolStripItem
            /*if (e.Data.GetDataPresent(typeof(Button)))
            {
                //接收拖拽来的效果，Copy为直接收DragDropEffects.Copy
                e.Effect = DragDropEffects.Copy;
            }*/
            #endregion

            //MessageBox.Show(简化SQLToolStripMenuItem.GetType().ToString());
            //MessageBox.Show(简化SQLToolStripMenuItem.GetType().ToString()+"\n"+ e.Data.GetFormats()[0]+"\n"+ e.Data.GetDataPresent(typeof(ToolStripItem)).ToString());
            //MessageBox.Show(e.Data.GetDataPresent(typeof(ToolStripItem)).ToString());
            if (e.Data.GetDataPresent(typeof(Button)))
            {
                //拖入panel的控件类型id，0：其他，1：button，2：ToolStripItem
                typeid = 1;
                //接收拖拽来的效果，Copy为直接收DragDropEffects.Copy
                e.Effect = DragDropEffects.Copy;
            }
            if (e.Data.GetDataPresent(typeof(ToolStripItem)))
            {
                //拖入panel的控件类型id，0：其他，1：button，2：ToolStripItem
                typeid = 2;
                //接收拖拽来的效果，Copy为直接收DragDropEffects.Copy
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panel3_DragEnter(object sender, DragEventArgs e)
        {
            #region 该块只支持Button（已弃用），下方支持Button和ToolStripItem
            /*if (e.Data.GetDataPresent(typeof(Button)))
            {
                //接收拖拽来的效果，Copy为直接收DragDropEffects.Copy
                e.Effect = DragDropEffects.Copy;
            }*/
            #endregion

            //MessageBox.Show(简化SQLToolStripMenuItem.GetType().ToString());
            //MessageBox.Show(简化SQLToolStripMenuItem.GetType().ToString()+"\n"+ e.Data.GetFormats()[0]+"\n"+ e.Data.GetDataPresent(typeof(ToolStripItem)).ToString());
            //MessageBox.Show(e.Data.GetDataPresent(typeof(ToolStripItem)).ToString());
            if (e.Data.GetDataPresent(typeof(Button)))
            {
                //拖入panel的控件类型id，0：其他，1：button，2：ToolStripItem
                typeid = 1;
                //接收拖拽来的效果，Copy为直接收DragDropEffects.Copy
                e.Effect = DragDropEffects.Copy;
            }
            if (e.Data.GetDataPresent(typeof(ToolStripItem)))
            {
                //拖入panel的控件类型id，0：其他，1：button，2：ToolStripItem
                typeid = 2;
                //接收拖拽来的效果，Copy为直接收DragDropEffects.Copy
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panel4_DragEnter(object sender, DragEventArgs e)
        {
            #region 该块只支持Button（已弃用），下方支持Button和ToolStripItem
            /*if (e.Data.GetDataPresent(typeof(Button)))
            {
                //接收拖拽来的效果，Copy为直接收DragDropEffects.Copy
                e.Effect = DragDropEffects.Copy;
            }*/
            #endregion

            //MessageBox.Show(简化SQLToolStripMenuItem.GetType().ToString());
            //MessageBox.Show(简化SQLToolStripMenuItem.GetType().ToString()+"\n"+ e.Data.GetFormats()[0]+"\n"+ e.Data.GetDataPresent(typeof(ToolStripItem)).ToString());
            //MessageBox.Show(e.Data.GetDataPresent(typeof(ToolStripItem)).ToString());
            if (e.Data.GetDataPresent(typeof(Button)))
            {
                //拖入panel的控件类型id，0：其他，1：button，2：ToolStripItem
                typeid = 1;
                //接收拖拽来的效果，Copy为直接收DragDropEffects.Copy
                e.Effect = DragDropEffects.Copy;
            }
            if (e.Data.GetDataPresent(typeof(ToolStripItem)))
            {
                //拖入panel的控件类型id，0：其他，1：button，2：ToolStripItem
                typeid = 2;
                //接收拖拽来的效果，Copy为直接收DragDropEffects.Copy
                e.Effect = DragDropEffects.Copy;
            }
        }
        #endregion

        #region 按钮拖拽到panel上，panel根据按钮Text打开对应用户控件
        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            #region 该块只支持Button（已弃用），下方支持Button和ToolStripItem
            /*//获取拖拽到该控件上按钮的Text值
                string btnname = getBtnText(e.Data.GetData(typeof(Button)).ToString());
                //MessageBox.Show(btnname);
                //获取拖拽到该控件上按钮名字对应的用户控件
                Control frm = GetUserControlNameByButtonName(btnname);
                //清空当前panel
                panel1.Controls.Clear();
                //绑定用户控件
                panel1.Controls.Add(frm);*/
            #endregion

            string btnname = "";
            if (typeid == 0)//拖入panel的控件类型id，0：其他，1：button，2：ToolStripItem
            {

            }
            if (typeid == 1)//拖入panel的控件类型id，0：其他，1：button，2：ToolStripItem
            {
                //获取拖拽到该控件上按钮的Text值
                btnname = getBtnText(e.Data.GetData(typeof(Button)).ToString());
            }
            if (typeid == 2)//拖入panel的控件类型id，0：其他，1：button，2：ToolStripItem
            {
                //获取拖拽到该控件上按钮的Text值
                btnname = e.Data.GetData(typeof(ToolStripItem)).ToString();
            }
            //获取拖拽到该控件上按钮名字对应的用户控件
            Control frm = GetUserControlNameByButtonName(btnname);
            //清空当前panel
            panel1.Controls.Clear();
            //绑定用户控件
            panel1.Controls.Add(frm);
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            #region 该块只支持Button（已弃用），下方支持Button和ToolStripItem
            /*//获取拖拽到该控件上按钮的Text值
                string btnname = getBtnText(e.Data.GetData(typeof(Button)).ToString());
                //MessageBox.Show(btnname);
                //获取拖拽到该控件上按钮名字对应的用户控件
                Control frm = GetUserControlNameByButtonName(btnname);
                //清空当前panel
                panel2.Controls.Clear();
                //绑定用户控件
                panel2.Controls.Add(frm);*/
            #endregion

            string btnname = "";
            if (typeid == 0)//拖入panel的控件类型id，0：其他，1：button，2：ToolStripItem
            {

            }
            if (typeid == 1)//拖入panel的控件类型id，0：其他，1：button，2：ToolStripItem
            {
                //获取拖拽到该控件上按钮的Text值
                btnname = getBtnText(e.Data.GetData(typeof(Button)).ToString());
            }
            if (typeid == 2)//拖入panel的控件类型id，0：其他，1：button，2：ToolStripItem
            {
                //获取拖拽到该控件上按钮的Text值
                btnname = e.Data.GetData(typeof(ToolStripItem)).ToString();
            }
            //获取拖拽到该控件上按钮名字对应的用户控件
            Control frm = GetUserControlNameByButtonName(btnname);
            //清空当前panel
            panel2.Controls.Clear();
            //绑定用户控件
            panel2.Controls.Add(frm);
        }

        private void panel3_DragDrop(object sender, DragEventArgs e)
        {
            #region 该块只支持Button（已弃用），下方支持Button和ToolStripItem
            /*//获取拖拽到该控件上按钮的Text值
                string btnname = getBtnText(e.Data.GetData(typeof(Button)).ToString());
                //MessageBox.Show(btnname);
                //获取拖拽到该控件上按钮名字对应的用户控件
                Control frm = GetUserControlNameByButtonName(btnname);
                //清空当前panel
                panel3.Controls.Clear();
                //绑定用户控件
                panel3.Controls.Add(frm);*/
            #endregion

            string btnname = "";
            if (typeid == 0)//拖入panel的控件类型id，0：其他，1：button，2：ToolStripItem
            {

            }
            if (typeid == 1)//拖入panel的控件类型id，0：其他，1：button，2：ToolStripItem
            {
                //获取拖拽到该控件上按钮的Text值
                btnname = getBtnText(e.Data.GetData(typeof(Button)).ToString());
            }
            if (typeid == 2)//拖入panel的控件类型id，0：其他，1：button，2：ToolStripItem
            {
                //获取拖拽到该控件上按钮的Text值
                btnname = e.Data.GetData(typeof(ToolStripItem)).ToString();
            }
            //获取拖拽到该控件上按钮名字对应的用户控件
            Control frm = GetUserControlNameByButtonName(btnname);
            //清空当前panel
            panel3.Controls.Clear();
            //绑定用户控件
            panel3.Controls.Add(frm);
        }

        private void panel4_DragDrop(object sender, DragEventArgs e)
        {
            #region 该块只支持Button（已弃用），下方支持Button和ToolStripItem
            /*//获取拖拽到该控件上按钮的Text值
                string btnname = getBtnText(e.Data.GetData(typeof(Button)).ToString());
                //MessageBox.Show(btnname);
                //获取拖拽到该控件上按钮名字对应的用户控件
                Control frm = GetUserControlNameByButtonName(btnname);
                //清空当前panel
                panel4.Controls.Clear();
                //绑定用户控件
                panel4.Controls.Add(frm);*/
            #endregion

            string btnname = "";
            if (typeid == 0)//拖入panel的控件类型id，0：其他，1：button，2：ToolStripItem
            {

            }
            if (typeid == 1)//拖入panel的控件类型id，0：其他，1：button，2：ToolStripItem
            {
                //获取拖拽到该控件上按钮的Text值
                btnname = getBtnText(e.Data.GetData(typeof(Button)).ToString());
            }
            if (typeid == 2)//拖入panel的控件类型id，0：其他，1：button，2：ToolStripItem
            {
                //获取拖拽到该控件上按钮的Text值
                btnname = e.Data.GetData(typeof(ToolStripItem)).ToString();
            }
            //获取拖拽到该控件上按钮名字对应的用户控件
            Control frm = GetUserControlNameByButtonName(btnname);
            //清空当前panel
            panel4.Controls.Clear();
            //绑定用户控件
            panel4.Controls.Add(frm);
        }
        #endregion

        #region 顶部菜单栏
        #region 简化SQL拖拽效果
        private void 简化SQLToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                简化SQLToolStripMenuItem.DoDragDrop(简化SQLToolStripMenuItem, DragDropEffects.Copy);//发送的拖拽效果
            }
        }
        #endregion

        #region 大小写转换拖拽效果
        private void 大小写转换ToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                大小写转换ToolStripMenuItem.DoDragDrop(大小写转换ToolStripMenuItem, DragDropEffects.Copy);//发送的拖拽效果
            }
        }
        #endregion

        #region 生成随机字符拖拽效果
        private void 生成随机字符ToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                生成随机字符ToolStripMenuItem.DoDragDrop(生成随机字符ToolStripMenuItem, DragDropEffects.Copy);//发送的拖拽效果
            }
        }
        #endregion

        #region 窗口设置（预留功能）单窗口、四窗口切换
        private void 单窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("预留功能");
        }

        private void 四窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("预留功能");
        }
        #endregion

        #region 设置按钮单击事件，只能打开一个设置窗口
        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //设置只能打开一个，配合FrmSettings中的GetFrmSettings()设置
            FrmSettings.GetFrmSettings().Activate();
            FrmSettings.GetFrmSettings().Show();
        }
        #endregion

        #region 退出按钮单击事件
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #endregion

        #endregion
    }
}