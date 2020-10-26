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
    public partial class FrmDatabasesNameList : Form
    {
        public TextBox txtboxdatabase = new TextBox();
        public List<string> listdatabasesname = new List<string>();

        private Point pi;

        public FrmDatabasesNameList()
        {
            InitializeComponent();
        }

        #region 窗体加载事件
        private void FrmDatabasesNameList_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources._20200417084103500_easyicon_net_128;

            treeViewBindData();
        }
        #endregion

        #region treeview获取鼠标坐标 用来判断是否选中节点
        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            pi = new Point(e.X, e.Y);
        }
        #endregion

        #region treeview双击事件 如果双击的是节点，传值到主窗体数据库名文本框
        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = this.treeView1.GetNodeAt(pi);
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

                txtboxdatabase.Text = treeView1.SelectedNode.Text;
                this.Close();
            }
        }
        #endregion

        #region 设置该窗口只能打开一个，配合按钮设置
        private static FrmDatabasesNameList fdnl = new FrmDatabasesNameList();
        public static FrmDatabasesNameList GetFrmDatabasesNameList()
        {
            if (fdnl.IsDisposed)
            {
                fdnl = new FrmDatabasesNameList();
                return fdnl;
            }
            else
            {
                return fdnl;
            }
        }
        #endregion

        #region 窗体关闭时返回一个DialogResult，FrmMain接收返回值
        private void FrmDatabasesNameList_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        #endregion

        #region 按下ESC键关闭当前窗口
        private void treeView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
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

        #region 搜索按钮单击事件 支持模糊搜索
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxDataBaseName.Text))
            {
                treeViewBindData();
            }
            else
            {
                treeView1.Nodes.Clear();

                foreach (var item in onFindKeyWord(txtboxDataBaseName.Text, listdatabasesname))
                {
                    treeView1.Nodes.Add(item);
                }
            }
        }
        #endregion

        #region 模糊搜索List
        private List<string> onFindKeyWord(string str, List<string> list)
        {
            List<string> m_list = new List<string>();
            foreach (var item in list)
            {
                if (item.IndexOf(str) != -1)
                {
                    m_list.Add(item);
                }
            }
            return m_list;
        }
        #endregion
    }
}