using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaiokane;

namespace ToolsCollectionForProgram
{
    class ConfigSettings
    {
        public static string btnname1, btnname2, btnname3, btnname4, btnname5, btnname6, btnname7, btnname8, btnname9;

        #region 获取配置文件中右侧常用按钮的Text值
        /// <summary>
        /// 获取配置文件中右侧常用按钮的Text值
        /// </summary>
        public static void getDefaultBtnNameByappSettings()
        {
            btnname1 = RWConfig.GetappSettingsValue("btnname1", "./ToolsCollectionForProgram.exe");
            btnname2 = RWConfig.GetappSettingsValue("btnname2", "./ToolsCollectionForProgram.exe");
            btnname3 = RWConfig.GetappSettingsValue("btnname3", "./ToolsCollectionForProgram.exe");
            btnname4 = RWConfig.GetappSettingsValue("btnname4", "./ToolsCollectionForProgram.exe");
            btnname5 = RWConfig.GetappSettingsValue("btnname5", "./ToolsCollectionForProgram.exe");
            btnname6 = RWConfig.GetappSettingsValue("btnname6", "./ToolsCollectionForProgram.exe");
            btnname7 = RWConfig.GetappSettingsValue("btnname7", "./ToolsCollectionForProgram.exe");
            btnname8 = RWConfig.GetappSettingsValue("btnname8", "./ToolsCollectionForProgram.exe");
            btnname9 = RWConfig.GetappSettingsValue("btnname9", "./ToolsCollectionForProgram.exe");
        }
        #endregion

        #region 如果配置文件中无右侧常用按钮的配置，则新建配置，值全为“暂无功能”
        /// <summary>
        /// 如果配置文件中无右侧常用按钮的配置，则新建配置，值全为“暂无功能”
        /// </summary>
        public static void setDefaultBtnNameIfIsNullOrEmptyByappSettings()
        {
            if (string.IsNullOrEmpty(btnname1))
            {
                RWConfig.SetappSettingsValue("btnname1", "暂无功能", "./ToolsCollectionForProgram.exe");
            }
            if (string.IsNullOrEmpty(btnname2))
            {
                RWConfig.SetappSettingsValue("btnname2", "暂无功能", "./ToolsCollectionForProgram.exe");
            }
            if (string.IsNullOrEmpty(btnname3))
            {
                RWConfig.SetappSettingsValue("btnname3", "暂无功能", "./ToolsCollectionForProgram.exe");
            }
            if (string.IsNullOrEmpty(btnname4))
            {
                RWConfig.SetappSettingsValue("btnname4", "暂无功能", "./ToolsCollectionForProgram.exe");
            }
            if (string.IsNullOrEmpty(btnname5))
            {
                RWConfig.SetappSettingsValue("btnname5", "暂无功能", "./ToolsCollectionForProgram.exe");
            }
            if (string.IsNullOrEmpty(btnname6))
            {
                RWConfig.SetappSettingsValue("btnname6", "暂无功能", "./ToolsCollectionForProgram.exe");
            }
            if (string.IsNullOrEmpty(btnname7))
            {
                RWConfig.SetappSettingsValue("btnname7", "暂无功能", "./ToolsCollectionForProgram.exe");
            }
            if (string.IsNullOrEmpty(btnname8))
            {
                RWConfig.SetappSettingsValue("btnname8", "暂无功能", "./ToolsCollectionForProgram.exe");
            }
            if (string.IsNullOrEmpty(btnname9))
            {
                RWConfig.SetappSettingsValue("btnname9", "暂无功能", "./ToolsCollectionForProgram.exe");
            }
        }
        #endregion
    }
}