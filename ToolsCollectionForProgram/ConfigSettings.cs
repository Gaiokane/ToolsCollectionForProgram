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
        public static string ConfigPath = "./ToolsCollectionForProgram.exe";

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

        #region 获取最后连接字符串MSSQL/MySQL
        /// <summary>
        /// 获取最后连接字符串MSSQL/MySQL
        /// </summary>
        /// <param name="sqlType">数据库类型，MSSQL/MySQL</param>
        /// <returns>数组 string[] sqlType, int sqlType, string Host, bool isPort, string Port, string Database, string Username, string Password</returns>
        public static string[] getLastConnectionStrings(string sqlType)
        {
            string temp = RWConfig.GetappSettingsValue("LastConnectionStringsFor" + sqlType, ConfigPath);
            string[] result = temp.Split(';');
            return result;
        }
        #endregion

        #region 设置最后连接字符串
        /// <summary>
        /// 设置最后连接字符串
        /// </summary>
        /// <param name="sqlType">数据库类型 0=mssql 1=mysql</param>
        /// <param name="Host">数据库地址</param>
        /// <param name="isPort">是否需要端口</param>
        /// <param name="Port">端口号</param>
        /// <param name="Database">数据库名</param>
        /// <param name="Username">用户名</param>
        /// <param name="Password">密码</param>
        /// <returns>true/false</returns>
        public static bool setLastConnectionStrings(int sqlType, string Host, bool isPort, string Port, string Database, string Username, string Password)
        {
            string value = sqlType + ";" + Host + ";" + isPort + ";" + Port + ";" + Database + ";" + Username + ";" + Password;
            if (sqlType == 0 || sqlType == 1)//0=mssql，1=mysql
            {
                if (sqlType == 0)
                {
                    RWConfig.SetappSettingsValue("LastConnectionStringsForMSSQL", value, ConfigPath);
                    return true;
                }
                if (sqlType == 1)
                {
                    RWConfig.SetappSettingsValue("LastConnectionStringsForMySQL", value, ConfigPath);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 设置最后连接数据库类型
        /// <summary>
        /// 设置最后连接数据库类型
        /// </summary>
        /// <param name="sqlType">数据库类型，MSSQL/MySQL</param>
        /// <returns>true/false</returns>
        public static bool setLastConnectionType(string sqlType)
        {
            if (sqlType == "MSSQL" || sqlType == "MySQL")
            {
                RWConfig.SetappSettingsValue("LastConnectionType", sqlType, ConfigPath);
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        /// <summary>
        /// 保存成功连接的连接记录
        /// </summary>
        /// <param name="sqlType">数据库类型 0=mssql 1=mysql</param>
        /// <param name="Host">数据库地址</param>
        /// <param name="isPort">是否需要端口</param>
        /// <param name="Port">端口号</param>
        /// <param name="Database">数据库名</param>
        /// <param name="Username">用户名</param>
        /// <param name="Password">密码</param>
        /// <returns>返回true/false</returns>
        public static bool saveConnectionString(int sqlType, string Host, bool isPort, string Port, string Database, string Username, string Password)
        {
            if (sqlType == 0)//MSSQL
            {
                return saveConnectionStringBySQLType("MSSQL", Host, isPort, Port, Database, Username, Password);
            }
            else//MySQL
            {
                return saveConnectionStringBySQLType("MySQL", Host, isPort, Port, Database, Username, Password);
            }
        }

        /// <summary>
        /// 根据数据库类型保存数据库连接记录
        /// </summary>
        /// <param name="sqlType">数据库类型 MSSQL MySQL</param>
        /// <param name="Host">数据库地址</param>
        /// <param name="isPort">是否需要端口</param>
        /// <param name="Port">端口号</param>
        /// <param name="Database">数据库名</param>
        /// <param name="Username">用户名</param>
        /// <param name="Password">密码</param>
        /// <returns>返回true/false</returns>
        public static bool saveConnectionStringBySQLType(string sqlType, string Host, bool isPort, string Port, string Database, string Username, string Password)
        {
            try
            {
                int n = getSameValueLenth(sqlType + "_Host", Host);//Host计数
                if (n == 0)//说明没有该记录
                {
                    string[] array = getConfigValueByKey(sqlType + "_Host");
                    List<string> List = array.ToList();
                    List.Add(Host);
                    array = List.ToArray();
                    string value;
                    if (array[0] == "")
                    {
                        value = array[array.Length - 1];
                    }
                    else
                    {
                        value = String.Join(";", array);
                    }
                    RWConfig.SetappSettingsValue(sqlType + "_Host", value, ConfigPath);
                }

                n = getSameValueLenth(sqlType + "_DB_" + Host, Database);//DB计数
                if (n == 0)//说明没有该记录
                {
                    string[] array = getConfigValueByKey(sqlType + "_DB_" + Host);
                    List<string> List = array.ToList();
                    List.Add(Database);
                    array = List.ToArray();
                    string value;
                    if (array[0] == "")
                    {
                        value = array[array.Length - 1];
                    }
                    else
                    {
                        value = String.Join(";", array);
                    }
                    RWConfig.SetappSettingsValue(sqlType + "_DB_" + Host, value, ConfigPath);
                }

                RWConfig.SetappSettingsValue(sqlType + "_Host_" + Host, isPort + ";" + Port + ";" + Username + ";" + Password, ConfigPath);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 获取指定Key下Value中匹配字符串数量
        /// </summary>
        /// <param name="ConfigKey">配置文件中的Key</param>
        /// <param name="Value">需要判断的Value</param>
        /// <returns>匹配数量</returns>
        public static int getSameValueLenth(string ConfigKey, string Value)
        {
            int n = 0;//计数
            string[] result = getConfigValueByKey(ConfigKey);
            foreach (var item in result)
            {
                if (Value == item)
                {
                    n += 1;
                }
            }
            return n;
        }

        #region 根据配置文件中的Key获取对应Value
        /// <summary>
        /// 根据配置文件中的Key获取对应Value
        /// </summary>
        /// <param name="ConfigKey">配置文件中的Key</param>
        /// <returns>返回Key对应Value，数组</returns>
        public static string[] getConfigValueByKey(string ConfigKey)
        {
            string[] result = { };
            string str = RWConfig.GetappSettingsValue(ConfigKey, ConfigPath);
            result = str.Split(';');
            return result;
        }
        #endregion

        #region 获取最后连接数据库类型
        /// <summary>
        /// 获取最后连接数据库类型
        /// </summary>
        /// <returns>返回数据库类型，MSSQL/MySQL</returns>
        public static string getLastConnectionType()
        {
            string result = RWConfig.GetappSettingsValue("LastConnectionType", ConfigPath);
            return result;
        }
        #endregion
    }
}