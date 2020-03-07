using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gaiokane;

namespace ToolsCollectionForProgram
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        #region 设置该窗口只能打开一个，配合按钮设置
        private static FrmSettings fs = new FrmSettings();
        public static FrmSettings GetFrmSettings()
        {
            if (fs.IsDisposed)
            {
                fs = new FrmSettings();
                return fs;
            }
            else
            {
                return fs;
            }
        }
        #endregion

        #region 窗体加载事件 获取常用功能按钮配置信息
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            #region 常用功能按钮配置信息
            //下拉框增加默认值
            cmbboxCommonFunctionsButton1.Items.Add("暂无功能");
            cmbboxCommonFunctionsButton2.Items.Add("暂无功能");
            cmbboxCommonFunctionsButton3.Items.Add("暂无功能");
            cmbboxCommonFunctionsButton4.Items.Add("暂无功能");
            cmbboxCommonFunctionsButton5.Items.Add("暂无功能");
            cmbboxCommonFunctionsButton6.Items.Add("暂无功能");
            cmbboxCommonFunctionsButton7.Items.Add("暂无功能");
            cmbboxCommonFunctionsButton8.Items.Add("暂无功能");
            cmbboxCommonFunctionsButton9.Items.Add("暂无功能");

            //将功能集合菜单下的所有项加入下拉菜单
            FrmMain fm = new FrmMain();
            for (int i = 0; i < fm.功能集合ToolStripMenuItem.DropDownItems.Count; i++)
            {
                cmbboxCommonFunctionsButton1.Items.Add(fm.功能集合ToolStripMenuItem.DropDownItems[i].ToString());
                cmbboxCommonFunctionsButton2.Items.Add(fm.功能集合ToolStripMenuItem.DropDownItems[i].ToString());
                cmbboxCommonFunctionsButton3.Items.Add(fm.功能集合ToolStripMenuItem.DropDownItems[i].ToString());
                cmbboxCommonFunctionsButton4.Items.Add(fm.功能集合ToolStripMenuItem.DropDownItems[i].ToString());
                cmbboxCommonFunctionsButton5.Items.Add(fm.功能集合ToolStripMenuItem.DropDownItems[i].ToString());
                cmbboxCommonFunctionsButton6.Items.Add(fm.功能集合ToolStripMenuItem.DropDownItems[i].ToString());
                cmbboxCommonFunctionsButton7.Items.Add(fm.功能集合ToolStripMenuItem.DropDownItems[i].ToString());
                cmbboxCommonFunctionsButton8.Items.Add(fm.功能集合ToolStripMenuItem.DropDownItems[i].ToString());
                cmbboxCommonFunctionsButton9.Items.Add(fm.功能集合ToolStripMenuItem.DropDownItems[i].ToString());
            }

            //获取常用功能按钮配置信息
            getCommonFunctionsButtonName();
            #endregion
        }
        #endregion

        #region 获取常用功能按钮配置信息
        /// <summary>
        /// 获取常用功能按钮配置信息
        /// </summary>
        private void getCommonFunctionsButtonName()
        {
            ConfigSettings.getDefaultBtnNameByappSettings();

            cmbboxCommonFunctionsButton1.SelectedIndex = -1;
            cmbboxCommonFunctionsButton2.SelectedIndex = -1;
            cmbboxCommonFunctionsButton3.SelectedIndex = -1;
            cmbboxCommonFunctionsButton4.SelectedIndex = -1;
            cmbboxCommonFunctionsButton5.SelectedIndex = -1;
            cmbboxCommonFunctionsButton6.SelectedIndex = -1;
            cmbboxCommonFunctionsButton7.SelectedIndex = -1;
            cmbboxCommonFunctionsButton8.SelectedIndex = -1;
            cmbboxCommonFunctionsButton9.SelectedIndex = -1;

            cmbboxCommonFunctionsButton1.SelectedItem = ConfigSettings.btnname1;
            cmbboxCommonFunctionsButton2.SelectedItem = ConfigSettings.btnname2;
            cmbboxCommonFunctionsButton3.SelectedItem = ConfigSettings.btnname3;
            cmbboxCommonFunctionsButton4.SelectedItem = ConfigSettings.btnname4;
            cmbboxCommonFunctionsButton5.SelectedItem = ConfigSettings.btnname5;
            cmbboxCommonFunctionsButton6.SelectedItem = ConfigSettings.btnname6;
            cmbboxCommonFunctionsButton7.SelectedItem = ConfigSettings.btnname7;
            cmbboxCommonFunctionsButton8.SelectedItem = ConfigSettings.btnname8;
            cmbboxCommonFunctionsButton9.SelectedItem = ConfigSettings.btnname9;
        }
        #endregion

        #region 常用功能按钮配置-保存按钮单击事件 保存配置信息
        private void btnCommonFunctionsButtonSave_Click(object sender, EventArgs e)
        {
            setCommonFunctionsButtonName();
            MessageBox.Show("保存成功 请重新运行");
            getCommonFunctionsButtonName();
            Application.Exit();
        }
        #endregion

        #region 常用功能按钮配置-重置按钮单击事件 重新读取配置信息
        private void btnCommonFunctionsButtonReset_Click(object sender, EventArgs e)
        {
            getCommonFunctionsButtonName();
        }
        #endregion

        #region 保存常用功能按钮配置
        /// <summary>
        /// 保存常用功能按钮配置
        /// </summary>
        public void setCommonFunctionsButtonName()
        {
            if (cmbboxCommonFunctionsButton1.SelectedIndex == -1)
            {
                RWConfig.SetappSettingsValue("btnname1", "暂无功能", "./ToolsCollectionForProgram.exe");
            }
            else
            {
                RWConfig.SetappSettingsValue("btnname1", cmbboxCommonFunctionsButton1.SelectedItem.ToString(), "./ToolsCollectionForProgram.exe");
            }
            if (cmbboxCommonFunctionsButton2.SelectedIndex == -1)
            {
                RWConfig.SetappSettingsValue("btnname2", "暂无功能", "./ToolsCollectionForProgram.exe");
            }
            else
            {
                RWConfig.SetappSettingsValue("btnname2", cmbboxCommonFunctionsButton2.SelectedItem.ToString(), "./ToolsCollectionForProgram.exe");
            }
            if (cmbboxCommonFunctionsButton3.SelectedIndex == -1)
            {
                RWConfig.SetappSettingsValue("btnname3", "暂无功能", "./ToolsCollectionForProgram.exe");
            }
            else
            {
                RWConfig.SetappSettingsValue("btnname3", cmbboxCommonFunctionsButton3.SelectedItem.ToString(), "./ToolsCollectionForProgram.exe");
            }
            if (cmbboxCommonFunctionsButton4.SelectedIndex == -1)
            {
                RWConfig.SetappSettingsValue("btnname4", "暂无功能", "./ToolsCollectionForProgram.exe");
            }
            else
            {
                RWConfig.SetappSettingsValue("btnname4", cmbboxCommonFunctionsButton4.SelectedItem.ToString(), "./ToolsCollectionForProgram.exe");
            }
            if (cmbboxCommonFunctionsButton5.SelectedIndex == -1)
            {
                RWConfig.SetappSettingsValue("btnname5", "暂无功能", "./ToolsCollectionForProgram.exe");
            }
            else
            {
                RWConfig.SetappSettingsValue("btnname5", cmbboxCommonFunctionsButton5.SelectedItem.ToString(), "./ToolsCollectionForProgram.exe");
            }
            if (cmbboxCommonFunctionsButton6.SelectedIndex == -1)
            {
                RWConfig.SetappSettingsValue("btnname6", "暂无功能", "./ToolsCollectionForProgram.exe");
            }
            else
            {
                RWConfig.SetappSettingsValue("btnname6", cmbboxCommonFunctionsButton6.SelectedItem.ToString(), "./ToolsCollectionForProgram.exe");
            }
            if (cmbboxCommonFunctionsButton7.SelectedIndex == -1)
            {
                RWConfig.SetappSettingsValue("btnname7", "暂无功能", "./ToolsCollectionForProgram.exe");
            }
            else
            {
                RWConfig.SetappSettingsValue("btnname7", cmbboxCommonFunctionsButton7.SelectedItem.ToString(), "./ToolsCollectionForProgram.exe");
            }
            if (cmbboxCommonFunctionsButton8.SelectedIndex == -1)
            {
                RWConfig.SetappSettingsValue("btnname8", "暂无功能", "./ToolsCollectionForProgram.exe");
            }
            else
            {
                RWConfig.SetappSettingsValue("btnname8", cmbboxCommonFunctionsButton8.SelectedItem.ToString(), "./ToolsCollectionForProgram.exe");
            }
            if (cmbboxCommonFunctionsButton9.SelectedIndex == -1)
            {
                RWConfig.SetappSettingsValue("btnname9", "暂无功能", "./ToolsCollectionForProgram.exe");
            }
            else
            {
                RWConfig.SetappSettingsValue("btnname9", cmbboxCommonFunctionsButton9.SelectedItem.ToString(), "./ToolsCollectionForProgram.exe");
            }
        }
        #endregion
    }
}