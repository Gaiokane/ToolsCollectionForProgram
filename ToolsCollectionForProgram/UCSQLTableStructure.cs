using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ToolsCollectionForProgram
{
    public partial class UCSQLTableStructure : UserControl
    {
        string host, port, database, username, password, sqlconn;

        SqlConnection mssqlconn;
        SqlCommand mssqlcmd = new SqlCommand();

        MySqlConnection mysqlconn;

        public TreeNode tn;
        public TreeView tv;
        public string databasename = "NULL";

        public TextBox txtboxdatabase = new TextBox();
        public List<string> listdatabasesname = new List<string>();

        private Point pi;

        public string tablename;

        private string sqlGetTableStructureForMSSQL;
        private string sqlGetTableStructureForMySQL;

        public string sqltype;

        #region 获取数据库名、表名、视图名字段
        string sqlGetDatabasesNameListForMSSQL = "SELECT name AS DATABASE_NAME FROM sysdatabases ORDER BY name;";
        string sqlGetDatabasesNameListForMySQL = "SELECT SCHEMA_NAME AS DATABASE_NAME FROM `information_schema`.`SCHEMATA` ORDER BY SCHEMA_NAME;";
        DataTable dtDatabasesNameList;
        List<string> listDatabasesName;

        string sqlGetDatabaseTablesNameListForMSSQL = "SELECT 2;";
        string sqlGetDatabaseTablesNameListForMySQL = "SELECT 2;";
        DataTable dtDatabaseTablesNameList;
        List<string> listDatabaseTablesName;

        string sqlGetDatabaseViewsNameListForMSSQL = "SELECT 3;";
        string sqlGetDatabaseViewsNameListForMySQL = "SELECT 3;";
        DataTable dtDatabaseViewsNameList;
        List<string> listDatabaseViewsName;
        #endregion

        public UCSQLTableStructure()
        {
            InitializeComponent();
        }

        #region 数据库_单选按钮切换默认端口改变
        private void radiobtnMSSQL_CheckedChanged(object sender, EventArgs e)
        {
            int isLastConnectionSettingError = 0;
            string[] LastConnectionStrings;
            string radiobtn;
            if (radiobtnMSSQL.Checked == true)
            {
                radiobtn = "MSSQL";
            }
            else
            {
                radiobtn = "MySQL";
            }

            #region 判断MSSQL的LastConnectionStrings、MySQL的LastConnectionStrings是否有问题，对有问题部分重置为默认值
            LastConnectionStrings = ConfigSettings.getLastConnectionStrings(radiobtn);
            if (radiobtn == "MSSQL" && LastConnectionStrings.Length != 7)
            {
                //MSSQL的LastConnectionStrings问题，值为2
                isLastConnectionSettingError += 2;
            }
            if (radiobtn == "MySQL" && LastConnectionStrings.Length != 7)
            {
                //MySQL的LastConnectionStrings问题，值为4
                isLastConnectionSettingError += 4;
            }

            //MSSQL的LastConnectionStrings问题，值为2
            if (getAndOperationResult(isLastConnectionSettingError, 2) != 0)
            {
                ConfigSettings.setLastConnectionStrings(0, "127.0.0.1", false, "1433", "qktest", "sa", "11111");
            }
            //MySQL的LastConnectionStrings问题，值为4
            if (getAndOperationResult(isLastConnectionSettingError, 4) != 0)
            {
                ConfigSettings.setLastConnectionStrings(1, "127.0.0.1", true, "3306", "pagination", "qkk", "qkk");
            }
            if (isLastConnectionSettingError != 0)
            {
                MessageBox.Show("最新数据库连接值不正确，已重置为默认值，请重新运行该程序！");
                Application.Exit();
            }
            #endregion

            bool isPort = false;
            if (LastConnectionStrings[2] == "True")
            {
                isPort = true;
            }
            else if (LastConnectionStrings[2] == "False")
            {
                isPort = false;
            }
            else
            {
                isPort = false;
            }
            //int sqlType, string Host, bool isPort, string Port, string Database, string Username, string Password
            if (LastConnectionStrings[0] == "0")
            {
                radiobtnMSSQL.Checked = true;
                txtboxHost.Text = LastConnectionStrings[1];
                chkboxPort.Checked = isPort;
                txtboxPort.Text = LastConnectionStrings[3];
                txtboxDatabase.Text = LastConnectionStrings[4];
                txtboxUsername.Text = LastConnectionStrings[5];
                txtboxPassword.Text = LastConnectionStrings[6];
            }
            else if (LastConnectionStrings[0] == "1")
            {
                radiobtnMYSQL.Checked = true;
                txtboxHost.Text = LastConnectionStrings[1];
                chkboxPort.Checked = isPort;
                txtboxPort.Text = LastConnectionStrings[3];
                txtboxDatabase.Text = LastConnectionStrings[4];
                txtboxUsername.Text = LastConnectionStrings[5];
                txtboxPassword.Text = LastConnectionStrings[6];
            }
            else
            {
                setTestConn();
            }
        }
        #endregion

        #region 数据库_连接按钮单击事件
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxHost.Text))
            {
                MessageBox.Show("Host不能为空！");
                txtboxHost.Focus();
            }
            else
            {
                if (chkboxPort.Checked == true && string.IsNullOrEmpty(txtboxPort.Text))
                {
                    MessageBox.Show("Port不能为空！");
                    txtboxPort.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(txtboxDatabase.Text))
                    {
                        MessageBox.Show("Database不能为空！");
                        txtboxDatabase.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtboxUsername.Text))
                        {
                            MessageBox.Show("Username不能为空！");
                            txtboxUsername.Focus();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtboxPassword.Text))
                            {
                                MessageBox.Show("Password不能为空！");
                                txtboxPassword.Focus();
                            }
                            else
                            {
                                host = txtboxHost.Text.Trim();
                                port = txtboxPort.Text.Trim();
                                database = txtboxDatabase.Text.Trim();
                                username = txtboxUsername.Text.Trim();
                                password = txtboxPassword.Text.Trim();

                                #region 使用MSSQL
                                if (radiobtnMSSQL.Checked == true)
                                {
                                    sqlconn = string.Empty;
                                    if (chkboxPort.Checked == true)//指定端口
                                    {
                                        sqlconn = "server=" + host + "," + port + "; database=" + database + "; uid=" + username + "; pwd=" + password + "";
                                    }
                                    else//不指定端口
                                    {
                                        sqlconn = "server=" + host + "; database=" + database + "; uid=" + username + "; pwd=" + password + "";
                                    }
                                    try
                                    {
                                        mssqlconn = new SqlConnection(sqlconn);
                                        mssqlconn.Open();
                                        //MessageBox.Show(mssqlconn.State.ToString());//Open
                                        if (mssqlconn.State == ConnectionState.Open)
                                        {
                                            labConnectStatus.Text = "状态：已连接";
                                            btnConnect.Enabled = false;
                                            radiobtnMSSQL.Enabled = false;
                                            radiobtnMYSQL.Enabled = false;
                                            txtboxHost.Enabled = false;
                                            chkboxPort.Enabled = false;
                                            txtboxPort.Enabled = false;
                                            txtboxDatabase.Enabled = false;
                                            txtboxUsername.Enabled = false;
                                            txtboxPassword.Enabled = false;
                                            btnShowDatabases.Enabled = false;
                                        }

                                        //设置最后连接数据库类型
                                        if (ConfigSettings.setLastConnectionType("MSSQL") == false)
                                        {
                                            MessageBox.Show("更新最后连接数据库类型出错！");
                                        }

                                        //设置上一次连接字符串
                                        if (ConfigSettings.setLastConnectionStrings(0, host, chkboxPort.Checked, port, database, username, password) == false)
                                        {
                                            MessageBox.Show("更新最后连接字符串出错！");
                                        }

                                        //保存连接成功的记录
                                        if (ConfigSettings.saveConnectionString(0, host, chkboxPort.Checked, port, database, username, password) == false)
                                        {
                                            MessageBox.Show("保存连接记录出错！");
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                                #endregion
                                #region 使用MYSQL
                                if (radiobtnMYSQL.Checked == true)
                                {
                                    sqlconn = string.Empty;
                                    if (chkboxPort.Checked == true)//指定端口
                                    {
                                        sqlconn = "Host = " + host + "; Port = " + port + "; Database = " + database + "; Username = " + username + "; Password = " + password + "";
                                    }
                                    else//不指定端口
                                    {
                                        sqlconn = "Host = " + host + "; Database = " + database + "; Username = " + username + "; Password = " + password + "";
                                    }
                                    try
                                    {
                                        mysqlconn = new MySqlConnection(sqlconn);
                                        mysqlconn.Open();
                                        //MessageBox.Show(mysqlconn.ConnectionTimeout.ToString());
                                        //MessageBox.Show(mysqlconn.State.ToString());//Open
                                        if (mysqlconn.State == ConnectionState.Open)
                                        {
                                            labConnectStatus.Text = "状态：已连接";
                                            btnConnect.Enabled = false;
                                            radiobtnMSSQL.Enabled = false;
                                            radiobtnMYSQL.Enabled = false;
                                            txtboxHost.Enabled = false;
                                            chkboxPort.Enabled = false;
                                            txtboxPort.Enabled = false;
                                            txtboxDatabase.Enabled = false;
                                            txtboxUsername.Enabled = false;
                                            txtboxPassword.Enabled = false;
                                            btnShowDatabases.Enabled = false;
                                        }

                                        //设置最后连接数据库类型
                                        if (ConfigSettings.setLastConnectionType("MySQL") == false)
                                        {
                                            MessageBox.Show("更新最后连接数据库类型出错！");
                                        }

                                        //设置上一次连接字符串
                                        if (ConfigSettings.setLastConnectionStrings(1, host, chkboxPort.Checked, port, database, username, password) == false)
                                        {
                                            MessageBox.Show("更新最后连接字符串出错！");
                                        }

                                        //保存连接成功的记录
                                        if (ConfigSettings.saveConnectionString(1, host, chkboxPort.Checked, port, database, username, password) == false)
                                        {
                                            MessageBox.Show("保存连接记录出错！");
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                                #endregion

                                #region 查看表结构按钮单击事件
                                if (labConnectStatus.Text == "状态：已连接")
                                {
                                    //MessageBox.Show(GetsqlGetDatabaseTablesNameListForMSSQLORMySQL("MySQL", txtboxDatabase.Text.Trim()));
                                    //MessageBox.Show(GetsqlGetDatabaseTablesNameListForMSSQLORMySQL("MSSQL", txtboxDatabase.Text.Trim()));

                                    databasename = txtboxDatabase.Text.Trim();

                                    TreeNode tn = new TreeNode();
                                    tn.Text = txtboxDatabase.Text.Trim();

                                    /*节点测试
                                    tn.Nodes.Add("节点1");
                                    tn.Nodes.Add("节点2");
                                    tn.Nodes[0].Nodes.Add("节点1的子节点1");
                                    tn.Nodes[0].Nodes[0].Nodes.Add("节点1的子节点1的子子节点1");
                                    tn.Nodes[1].Nodes.Add("节点2的子节点1");
                                    tn.Nodes[1].Nodes.Add("节点2的子节点2");
                                    */

                                    #region 使用MSSQL
                                    if (radiobtnMSSQL.Checked == true)
                                    {
                                        sqlGetDatabaseTablesNameListForMSSQL = GetsqlGetDatabaseTablesNameListForMSSQLORMySQL("MSSQL", "TABLE", txtboxDatabase.Text.Trim());
                                        sqlGetDatabaseViewsNameListForMSSQL = GetsqlGetDatabaseTablesNameListForMSSQLORMySQL("MSSQL", "VIEW", txtboxDatabase.Text.Trim());

                                        try
                                        {
                                            //SqlHelper中把conn.close都去掉了
                                            //处理单击树节点显示表结构后连接被关闭
                                            /*if (mssqlconn.State == ConnectionState.Closed)
                                            {
                                                mssqlconn.Open();
                                            }*/
                                            if (mssqlconn.State == ConnectionState.Open)
                                            {
                                                //获取当前数据库下的表名
                                                dtDatabaseTablesNameList = SqlHelper.getDataSetMSSQL(sqlGetDatabaseTablesNameListForMSSQL, mssqlconn).Tables[0];
                                                //mssqlconn.Open();
                                                //将表名存到list
                                                listDatabaseTablesName = DataTableToList(dtDatabaseTablesNameList);
                                                tn.Nodes.Add("表");
                                                foreach (var item in listDatabaseTablesName)
                                                {
                                                    tn.Nodes[0].Nodes.Add(item);
                                                }

                                                //获取当前数据库下的视图名
                                                dtDatabaseViewsNameList = SqlHelper.getDataSetMSSQL(sqlGetDatabaseViewsNameListForMSSQL, mssqlconn).Tables[0];
                                                //mssqlconn.Open();
                                                //将表名存到list
                                                listDatabaseViewsName = DataTableToList(dtDatabaseViewsNameList);
                                                tn.Nodes.Add("视图");
                                                foreach (var item in listDatabaseViewsName)
                                                {
                                                    tn.Nodes[1].Nodes.Add(item);
                                                }

                                                this.tn = tn;
                                                this.sqltype = "MSSQL";

                                                treeView1.Nodes.Add(tn);

                                                treeView1.ExpandAll();//展开所有树节点
                                                                      //treeView1.CollapseAll();//折叠所有树节点
                                                treeView1.Nodes[0].EnsureVisible();//垂直滚动条在展开所有节点后回到顶端

                                                //修复未默认选中treeview，当点击节点时报错的问题
                                                treeView1.Focus();

                                                //MessageBox.Show(databasename);
                                                //MessageBox.Show(treeView1.Nodes[0].Text);

                                                //RichTextBox增加右键菜单
                                                RichTextBoxMenu richTextBoxMenu_richTextBox1 = new RichTextBoxMenu(richTextBox1);
                                            }
                                            else
                                            {
                                                mssqlconn.Open();
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }
                                    }
                                    #endregion
                                    #region 使用MYSQL
                                    if (radiobtnMYSQL.Checked == true)
                                    {
                                        sqlGetDatabaseTablesNameListForMySQL = GetsqlGetDatabaseTablesNameListForMSSQLORMySQL("MySQL", "TABLE", txtboxDatabase.Text.Trim());
                                        sqlGetDatabaseViewsNameListForMySQL = GetsqlGetDatabaseTablesNameListForMSSQLORMySQL("MySQL", "VIEW", txtboxDatabase.Text.Trim());

                                        try
                                        {
                                            //SqlHelper中把conn.close都去掉了
                                            //处理单击树节点显示表结构后连接被关闭
                                            /*if (mysqlconn.State == ConnectionState.Closed)
                                            {
                                                mysqlconn.Open();
                                            }*/
                                            if (mysqlconn.State == ConnectionState.Open)
                                            {
                                                //获取当前数据库下的表名
                                                dtDatabaseTablesNameList = SqlHelper.getDataSetMySQL(sqlGetDatabaseTablesNameListForMySQL, mysqlconn).Tables[0];
                                                //mysqlconn.Open();
                                                //将表名存到list
                                                listDatabaseTablesName = DataTableToList(dtDatabaseTablesNameList);
                                                tn.Nodes.Add("表");
                                                foreach (var item in listDatabaseTablesName)
                                                {
                                                    tn.Nodes[0].Nodes.Add(item);
                                                }

                                                //获取当前数据库下的视图名
                                                dtDatabaseViewsNameList = SqlHelper.getDataSetMySQL(sqlGetDatabaseViewsNameListForMySQL, mysqlconn).Tables[0];
                                                //mysqlconn.Open();
                                                //将表名存到list
                                                listDatabaseViewsName = DataTableToList(dtDatabaseViewsNameList);
                                                tn.Nodes.Add("视图");
                                                foreach (var item in listDatabaseViewsName)
                                                {
                                                    tn.Nodes[1].Nodes.Add(item);
                                                }

                                                this.tn = tn;
                                                this.sqltype = "MySQL";

                                                treeView1.Nodes.Add(tn);

                                                treeView1.ExpandAll();//展开所有树节点
                                                                      //treeView1.CollapseAll();//折叠所有树节点
                                                treeView1.Nodes[0].EnsureVisible();//垂直滚动条在展开所有节点后回到顶端

                                                //修复未默认选中treeview，当点击节点时报错的问题
                                                treeView1.Focus();

                                                //MessageBox.Show(databasename);
                                                //MessageBox.Show(treeView1.Nodes[0].Text);

                                                //RichTextBox增加右键菜单
                                                RichTextBoxMenu richTextBoxMenu_richTextBox1 = new RichTextBoxMenu(richTextBox1);
                                            }
                                            else
                                            {
                                                mysqlconn.Open();
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }
                                    }
                                    #endregion
                                }
                                else
                                {
                                    MessageBox.Show("请先连接数据库！");
                                    btnConnect.Focus();
                                }
                                #endregion
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region treeView加载全部数据
        private void treeViewBindData()
        {
            treeView1.Nodes.Clear();

            foreach (var item in listdatabasesname)
            {
                treeView1.Nodes.Add(item);
            }
        }
        #endregion

        private void UCSQLTableStructure_Load(object sender, EventArgs e)
        {
            setTestConn();

            #region 读取并设置上一次数据库连接
            int isLastConnectionSettingError = 0;
            string LastConnectionType = ConfigSettings.getLastConnectionType();
            string[] LastConnectionStrings;

            #region 判断LastConnectionType、MSSQL的LastConnectionStrings、MySQL的LastConnectionStrings是否有问题，对有问题部分重置为默认值
            if (LastConnectionType == "MSSQL" || LastConnectionType == "MySQL")
            {

            }
            //LastConnectionType问题，值为1
            else
            {
                isLastConnectionSettingError += 1;
            }
            LastConnectionStrings = ConfigSettings.getLastConnectionStrings("MSSQL");
            if (LastConnectionStrings.Length != 7)
            {
                //MSSQL的LastConnectionStrings问题，值为2
                isLastConnectionSettingError += 2;
            }
            LastConnectionStrings = ConfigSettings.getLastConnectionStrings("MySQL");
            if (LastConnectionStrings.Length != 7)
            {
                //MySQL的LastConnectionStrings问题，值为4
                isLastConnectionSettingError += 4;
            }

            //LastConnectionType问题，值为1
            if (getAndOperationResult(isLastConnectionSettingError, 1) != 0)
            {
                ConfigSettings.setLastConnectionType("MySQL");
            }
            //MSSQL的LastConnectionStrings问题，值为2
            if (getAndOperationResult(isLastConnectionSettingError, 2) != 0)
            {
                ConfigSettings.setLastConnectionStrings(0, "docker,98", false, "1433", "qktest", "sa", "Qwer1234!");
            }
            //MySQL的LastConnectionStrings问题，值为4
            if (getAndOperationResult(isLastConnectionSettingError, 4) != 0)
            {
                ConfigSettings.setLastConnectionStrings(1, "127.0.0.1", true, "3306", "pagination", "qkk", "qkk");
            }
            if (isLastConnectionSettingError != 0)
            {
                MessageBox.Show("最新数据库连接值不正确，已重置为默认值，请重新运行该程序！");
                Application.Exit();
            }
            #endregion

            LastConnectionStrings = ConfigSettings.getLastConnectionStrings(LastConnectionType);
            bool isPort = false;
            if (LastConnectionStrings[2] == "True")
            {
                isPort = true;
            }
            else if (LastConnectionStrings[2] == "False")
            {
                isPort = false;
            }
            else
            {
                isPort = false;
            }
            //int sqlType, string Host, bool isPort, string Port, string Database, string Username, string Password
            if (LastConnectionStrings[0] == "0")
            {
                radiobtnMSSQL.Checked = true;
                txtboxHost.Text = LastConnectionStrings[1];
                chkboxPort.Checked = isPort;
                txtboxPort.Text = LastConnectionStrings[3];
                txtboxDatabase.Text = LastConnectionStrings[4];
                txtboxUsername.Text = LastConnectionStrings[5];
                txtboxPassword.Text = LastConnectionStrings[6];
            }
            else if (LastConnectionStrings[0] == "1")
            {
                radiobtnMYSQL.Checked = true;
                txtboxHost.Text = LastConnectionStrings[1];
                chkboxPort.Checked = isPort;
                txtboxPort.Text = LastConnectionStrings[3];
                txtboxDatabase.Text = LastConnectionStrings[4];
                txtboxUsername.Text = LastConnectionStrings[5];
                txtboxPassword.Text = LastConnectionStrings[6];
            }
            else
            {
                setTestConn();
            }
            #endregion
        }

        #region 数据库_断开按钮单击事件
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (labConnectStatus.Text == "状态：已断开")
            {

            }
            else
            {
                if (radiobtnMSSQL.Checked == true)
                {
                    mssqlconn.Close();
                    labConnectStatus.Text = "状态：已断开";
                    btnConnect.Enabled = true;
                    radiobtnMSSQL.Enabled = true;
                    radiobtnMYSQL.Enabled = true;
                    txtboxHost.Enabled = true;
                    chkboxPort.Enabled = true;
                    txtboxPort.Enabled = true;
                    txtboxDatabase.Enabled = true;
                    txtboxUsername.Enabled = true;
                    txtboxPassword.Enabled = true;
                    btnShowDatabases.Enabled = true;
                }
                if (radiobtnMYSQL.Checked == true)
                {
                    mysqlconn.Close();
                    labConnectStatus.Text = "状态：已断开";
                    btnConnect.Enabled = true;
                    radiobtnMSSQL.Enabled = true;
                    radiobtnMYSQL.Enabled = true;
                    txtboxHost.Enabled = true;
                    chkboxPort.Enabled = true;
                    txtboxPort.Enabled = true;
                    txtboxDatabase.Enabled = true;
                    txtboxUsername.Enabled = true;
                    txtboxPassword.Enabled = true;
                    btnShowDatabases.Enabled = true;
                }

                treeView1.Nodes.Clear();
                dataGridView1.DataSource = null;
            }
        }
        #endregion

        #region 选定表节点后，调用dgBindData，获取所选表 表结构，并显示到dg中
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = this.treeView1.GetNodeAt(pi);
            //获取深度，0：数据库名；1：表/视图；2：表名/视图名
            //MessageBox.Show(node.Level.ToString());
            if (node.Level == 2)
            {
                if (pi.X < node.Bounds.Left || pi.X > node.Bounds.Right)
                {
                    //不触发事件

                    return;
                }
                else
                {
                    //触发事件
                    dgBindData(sqltype, treeView1.SelectedNode.Text);
                }
            }
        }
        #endregion

        #region 处理点击已选择节点后重新获取所选表 表结构，并显示到dg中
        private void treeView1_Click(object sender, EventArgs e)
        {
            TreeNode node = this.treeView1.GetNodeAt(pi);
            //获取深度，0：数据库名；1：表/视图；2：表名/视图名
            //MessageBox.Show(node.Level.ToString());
            if (node.Level == 2)
            {
                if (pi.X < node.Bounds.Left || pi.X > node.Bounds.Right)
                {
                    //不触发事件

                    return;
                }
                else
                {
                    //触发事件
                    if (treeView1.SelectedNode.Text == node.Text)
                    {
                        dgBindData(sqltype, treeView1.SelectedNode.Text);
                    }
                }
            }
        }
        #endregion

        #region treeview双击事件 如果双击的是节点，传值到insert语句文本框光标处
        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = this.treeView1.GetNodeAt(pi);
            //获取深度，0：数据库名；1：表/视图；2：表名/视图名
            //MessageBox.Show(node.Level.ToString());
            if (node.Level == 2)
            {
                if (pi.X < node.Bounds.Left || pi.X > node.Bounds.Right)
                {
                    //不触发事件

                    //txtboxdatabase.Text = "no selected";
                    //this.Close();

                    return;
                }
                else
                {
                    //触发事件

                    //MessageBox.Show(treeView1.SelectedNode.Text);
                    tablename = treeView1.SelectedNode.Text;
                    //this.DialogResult = DialogResult.OK;
                    //this.Close();
                }
            }
        }
        #endregion

        #region treeView1按下ESC键关闭当前窗口
        private void treeView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                //this.Close();
            }
        }
        #endregion

        #region treeview获取鼠标坐标 用来判断是否选中节点
        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            pi = new Point(e.X, e.Y);
        }
        #endregion

        #region 数据库_获取数据库列表按钮单击事件 获取服务器数据库名列表，双击可以快速填充到Database文本框中
        private void btnShowDatabases_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxHost.Text))
            {
                MessageBox.Show("Host不能为空！");
                txtboxHost.Focus();
            }
            else
            {
                if (chkboxPort.Checked == true && string.IsNullOrEmpty(txtboxPort.Text))
                {
                    MessageBox.Show("Port不能为空！");
                    txtboxPort.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(txtboxDatabase.Text))
                    {
                        MessageBox.Show("Database不能为空！");
                        txtboxDatabase.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtboxUsername.Text))
                        {
                            MessageBox.Show("Username不能为空！");
                            txtboxUsername.Focus();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtboxPassword.Text))
                            {
                                MessageBox.Show("Password不能为空！");
                                txtboxPassword.Focus();
                            }
                            else
                            {
                                host = txtboxHost.Text.Trim();
                                port = txtboxPort.Text.Trim();
                                username = txtboxUsername.Text.Trim();
                                password = txtboxPassword.Text.Trim();

                                #region 使用MSSQL
                                if (radiobtnMSSQL.Checked == true)
                                {
                                    sqlconn = string.Empty;
                                    database = "master";
                                    if (chkboxPort.Checked == true)//指定端口
                                    {
                                        sqlconn = "server=" + host + "," + port + "; database=" + database + "; uid=" + username + "; pwd=" + password + "";
                                    }
                                    else//不指定端口
                                    {
                                        sqlconn = "server=" + host + "; database=" + database + "; uid=" + username + "; pwd=" + password + "";
                                    }
                                    try
                                    {
                                        mssqlconn = new SqlConnection(sqlconn);
                                        mssqlconn.Open();
                                        if (mssqlconn.State == ConnectionState.Open)
                                        {
                                            FrmDatabasesNameList fdnl = new FrmDatabasesNameList();

                                            fdnl.txtboxdatabase = txtboxDatabase;

                                            //获取当前用户有权限的数据库名DataTable
                                            dtDatabasesNameList = SqlHelper.getDataSetMSSQL(sqlGetDatabasesNameListForMSSQL, mssqlconn).Tables[0];
                                            //将数据库名存到list
                                            listDatabasesName = DataTableToList(dtDatabasesNameList);
                                            fdnl.listdatabasesname = listDatabasesName;

                                            //设置只能打开一个，配合FrmDatabasesNameList中的GetFrmDatabasesNameList()设置
                                            FrmDatabasesNameList.GetFrmDatabasesNameList().Activate();

                                            //接收FrmDatabasesNameList返回的DialogResult，可自定义操作
                                            if (fdnl.ShowDialog() == DialogResult.OK)
                                            {

                                            }

                                            mssqlconn.Close();
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                                #endregion
                                #region 使用MYSQL
                                if (radiobtnMYSQL.Checked == true)
                                {
                                    sqlconn = string.Empty;
                                    database = "information_schema";
                                    if (chkboxPort.Checked == true)//指定端口
                                    {
                                        sqlconn = "Host = " + host + "; Port = " + port + "; Database = " + database + "; Username = " + username + "; Password = " + password + "";
                                    }
                                    else//不指定端口
                                    {
                                        sqlconn = "Host = " + host + "; Database = " + database + "; Username = " + username + "; Password = " + password + "";
                                    }
                                    try
                                    {
                                        mysqlconn = new MySqlConnection(sqlconn);
                                        mysqlconn.Open();
                                        if (mysqlconn.State == ConnectionState.Open)
                                        {
                                            FrmDatabasesNameList fdnl = new FrmDatabasesNameList();

                                            fdnl.txtboxdatabase = txtboxDatabase;

                                            //获取当前用户有权限的数据库名DataTable
                                            dtDatabasesNameList = SqlHelper.getDataSetMySQL(sqlGetDatabasesNameListForMySQL, mysqlconn).Tables[0];
                                            //将数据库名存到list
                                            listDatabasesName = DataTableToList(dtDatabasesNameList);
                                            fdnl.listdatabasesname = listDatabasesName;

                                            //设置只能打开一个，配合FrmDatabasesNameList中的GetFrmDatabasesNameList()设置
                                            FrmDatabasesNameList.GetFrmDatabasesNameList().Activate();

                                            //接收FrmDatabasesNameList返回的DialogResult，可自定义操作
                                            if (fdnl.ShowDialog() == DialogResult.OK)
                                            {

                                            }

                                            mysqlconn.Close();
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                                #endregion
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region 获取数据库名，将DataTable中第一列的数据转为List
        /// <summary>
        /// 获取数据库名，将DataTable中第一列的数据转为List
        /// </summary>
        /// <param name="dt">传入的DataTable</param>
        /// <returns>返回List<string></returns>
        public static List<string> DataTableToList(DataTable dt)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(dt.Rows[i][0].ToString());
            }

            return list;
        }
        #endregion

        #region 与运算，返回结果，0 or 非0
        /// <summary>
        /// 与运算，返回结果，0 or 非0
        /// </summary>
        /// <param name="value">value & num</param>
        /// <param name="num">value & num</param>
        /// <returns></returns>
        private int getAndOperationResult(int value, int num)
        {
            int result = value & num;
            return result;
        }
        #endregion

        #region 设置测试用默认数据库连接
        private void setTestConn()
        {
            radiobtnMYSQL.Checked = true;
            txtboxHost.Text = "127.0.0.1";
            txtboxPort.Text = "3306";
            txtboxDatabase.Text = "pagination";
            txtboxUsername.Text = "qkk";
            txtboxPassword.Text = "qkk";
        }
        #endregion

        #region 获取MSSQL/MySQL当前所选数据库中的表名/视图名
        /// <summary>
        /// 获取MSSQL/MySQL当前所选数据库中的表名/视图名
        /// </summary>
        /// <param name="sqlType">MSSQL/MySQL</param>
        /// <param name="Type">TABLE/VIEW</param>
        /// <param name="DataBaseName">数据库名</param>
        /// <returns></returns>
        private string GetsqlGetDatabaseTablesNameListForMSSQLORMySQL(string sqlType, string Type, string DataBaseName)
        {
            string result = "SELECT 1;";

            if (string.IsNullOrEmpty(sqlType) == false && string.IsNullOrEmpty(DataBaseName) == false)
            {
                //MSSQL
                if (sqlType == "MSSQL")
                {
                    //表
                    if (Type == "TABLE")
                    {
                        result = "USE " + DataBaseName + ";SELECT name FROM sysobjects WHERE xtype = 'U' ORDER BY name;";
                        return result;
                    }
                    //视图
                    if (Type == "VIEW")
                    {
                        result = "USE " + DataBaseName + ";SELECT name FROM sysobjects WHERE xtype = 'V' ORDER BY name;";
                        return result;
                    }
                    else
                    {
                        return result;
                    }
                }
                //MySQL
                if (sqlType == "MySQL")
                {
                    //表
                    if (Type == "TABLE")
                    {
                        result = "SELECT TABLE_NAME FROM `information_schema`.`TABLES` WHERE TABLE_SCHEMA = '" + DataBaseName + "' AND TABLE_TYPE = 'BASE TABLE' ORDER BY TABLE_NAME;";
                        return result;
                    }
                    //视图
                    if (Type == "VIEW")
                    {
                        result = "SELECT TABLE_NAME FROM `information_schema`.`TABLES` WHERE TABLE_SCHEMA = '" + DataBaseName + "' AND TABLE_TYPE = 'VIEW' ORDER BY TABLE_NAME;";
                        //result = "SELECT TABLE_NAME FROM `information_schema`.`VIEWS` WHERE TABLE_SCHEMA = '" + DataBaseName + "' ORDER BY TABLE_NAME;";
                        return result;
                    }
                    else
                    {
                        return result;
                    }
                }
                else
                {
                    return result;
                }
            }
            else
            {
                return result;
            }
        }
        #endregion

        #region dg绑定数据，获取表结构信息
        /// <summary>
        /// dg绑定数据，获取表结构信息
        /// </summary>
        /// <param name="sqlType">MSSQL/MySQL</param>
        /// <param name="TableName">表名</param>
        private void dgBindData(string sqlType, string TableName)
        {
            if (string.IsNullOrEmpty(sqlType) == false && string.IsNullOrEmpty(TableName) == false)
            {
                sqlGetTableStructureForMSSQL = GetsqlGetTableStructureForMSSQLORMySQL("MSSQL", TableName);
                sqlGetTableStructureForMySQL = GetsqlGetTableStructureForMSSQLORMySQL("MySQL", TableName);

                //MSSQL
                if (sqlType == "MSSQL")
                {
                    dataGridView1.DataSource = SqlHelper.getDataSetMSSQL(sqlGetTableStructureForMSSQL, mssqlconn).Tables[0];
                }
                //MySQL
                if (sqlType == "MySQL")
                {
                    dataGridView1.DataSource = SqlHelper.getDataSetMySQL(sqlGetTableStructureForMySQL, mysqlconn).Tables[0];

                    dataGridView1.Columns[0].HeaderText = "列名";
                    dataGridView1.Columns[1].HeaderText = "类型";
                    dataGridView1.Columns[2].HeaderText = "注释";
                }
            }
        }
        #endregion

        #region 获取MSSQL/MySQL当前所选表的表结构消息
        /// <summary>
        /// 获取MSSQL/MySQL当前所选表的表结构消息
        /// </summary>
        /// <param name="sqlType">MSSQL/MySQL</param>
        /// <param name="DataBaseName">数据库名</param>
        /// <param name="TableName">表名</param>
        /// <returns></returns>
        private string GetsqlGetTableStructureForMSSQLORMySQL(string sqlType, string TableName)
        {
            string result = "SELECT 1;";

            if (string.IsNullOrEmpty(sqlType) == false && string.IsNullOrEmpty(TableName) == false)
            {
                //MSSQL
                if (sqlType == "MSSQL")
                {
                    #region 查表结构sql
                    /*
                     USE dbname;
                     SELECT (case when a.colorder=1 then d.name else null end) 表名,
                     a.colorder 字段序号,a.name 字段名,
                     (case when COLUMNPROPERTY( a.id,a.name,'IsIdentity')=1 then '√'else '' end) 标识,
                     (case when (SELECT count(*) FROM sysobjects
                     WHERE (name in (SELECT name FROM sysindexes
                     WHERE (id = a.id) AND (indid in
                     (SELECT indid FROM sysindexkeys
                     WHERE (id = a.id) AND (colid in
                     (SELECT colid FROM syscolumns WHERE (id = a.id) AND (name = a.name)))))))
                     AND (xtype = 'PK'))>0 then '√' else '' end) 主键,b.name 类型,a.length 占用字节数,
                     COLUMNPROPERTY(a.id,a.name,'PRECISION') as 长度,
                     isnull(COLUMNPROPERTY(a.id,a.name,'Scale'),0) as 小数位数,(case when a.isnullable=1 then '√'else '' end) 允许空,
                     isnull(e.text,'') 默认值,isnull(g.[value], ' ') AS [说明]
                     FROM  syscolumns a
                     left join systypes b on a.xtype=b.xusertype
                     inner join sysobjects d on a.id=d.id and d.xtype='U' and d.name<>'dtproperties'
                     left join syscomments e on a.cdefault=e.id
                     left join sys.extended_properties g on a.id=g.major_id AND a.colid=g.minor_id
                     left join sys.extended_properties f on d.id=f.class and f.minor_id=0
                     where b.name is not null
                     --WHERE d.name='info' --如果只查询指定表,加上此条件
                     order by a.id,a.colorder
                     */
                    #endregion

                    result = "USE " + databasename + "; " +
                        "SELECT (case when a.colorder=1 then d.name else null end) 表名, " +
                        "a.colorder 字段序号, a.name 字段名, " +
                        "(case when COLUMNPROPERTY(a.id, a.name, 'IsIdentity') = 1 then '√'else '' end) 标识, " +
                        "(case when(SELECT count(*) FROM sysobjects " +
                        "WHERE(name in (SELECT name FROM sysindexes " +
                        "WHERE(id = a.id) AND(indid in " +
                        "(SELECT indid FROM sysindexkeys " +
                        "WHERE(id = a.id) AND(colid in " +
                        "(SELECT colid FROM syscolumns WHERE(id = a.id) AND(name = a.name))))))) " +
                        "AND(xtype = 'PK'))> 0 then '√' else '' end) 主键,b.name 类型, a.length 占用字节数, " +
                        "COLUMNPROPERTY(a.id, a.name, 'PRECISION') as 长度, " +
                        "isnull(COLUMNPROPERTY(a.id, a.name, 'Scale'), 0) as 小数位数,(case when a.isnullable = 1 then '√'else '' end) 允许空, " +
                        "isnull(e.text, '') 默认值,isnull(g.[value], ' ') AS[说明] " +
                        "FROM syscolumns a " +
                        "left join systypes b on a.xtype = b.xusertype " +
                        "inner join sysobjects d on a.id = d.id and d.xtype = 'U' and d.name <> 'dtproperties' " +
                        "left join syscomments e on a.cdefault = e.id " +
                        "left join sys.extended_properties g on a.id = g.major_id AND a.colid = g.minor_id " +
                        "left join sys.extended_properties f on d.id = f.class and f.minor_id=0 " +
                        "WHERE d.name= '" + TableName + "' " +
                        "order by a.id, a.colorder";
                    return result;
                }
                //MySQL
                if (sqlType == "MySQL")
                {
                    result = "SELECT COLUMN_NAME, COLUMN_TYPE, COLUMN_COMMENT FROM information_schema.COLUMNS WHERE TABLE_SCHEMA = '" + databasename + "' AND TABLE_NAME = '" + TableName + "';";
                    //SELECT COLUMN_NAME AS 字段名, COLUMN_TYPE AS 字段类型, COLUMN_COMMENT AS 字段注释 FROM information_schema.COLUMNS WHERE TABLE_SCHEMA = '" + DataBaseName + "' AND TABLE_NAME = '" + TableName + "';
                    return result;
                }
                else
                {
                    return result;
                }
            }
            else
            {
                return result;
            }
        }
        #endregion
    }
}