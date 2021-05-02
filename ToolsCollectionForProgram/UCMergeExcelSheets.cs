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
    public partial class UCMergeExcelSheets : UserControl
    {
        public UCMergeExcelSheets()
        {
            InitializeComponent();
        }

        private void UCMergeExcelSheets_Load(object sender, EventArgs e)
        {
            lvReset();
        }

        private void lvReset()
        {
            listView1.Clear();

            listView1.Items.Add("TV_1");
            listView1.Items.Add("TV_2");
            listView1.Items.Add("TV_3");
            listView1.Items.Add("TV_4");
            listView1.Items.Add("TV_5");
        }

        private void btn_TestResetLV_Click(object sender, EventArgs e)
        {
            lvReset();
        }

        private ListViewItem itemDraged = null;//定义拖动的item
        private ListViewItem itemSelected = null;//定义拖动到位置的item
        bool isdrag = false;//是否拖动状态

        //ItemMouseHover方法实现鼠标拖动到某个元素上时更改该元素的被选中状态
        private void listView1_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip((e.Item).ListView, (e.Item).Text);

            itemSelected = e.Item;
            if (isdrag)
            {
                e.Item.Selected = true;
            }
            else
            {
                e.Item.Selected = false;
            }
        }

        //ItemDrag获取被拖动的item
        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            itemDraged = (ListViewItem)e.Item;
            this.Cursor = Cursors.Hand;
            isdrag = true;
        }

        //MouseUp当拖动放开鼠标时，进行位置调整操作
        private void listView1_MouseUp(object sender, MouseEventArgs e)
        {
            isdrag = false;
            if ((itemSelected != null) && (itemDraged != null))
            {
                if (itemDraged.Index != itemSelected.Index)
                {
                    this.listView1.Items.RemoveAt(itemDraged.Index);
                    this.listView1.Items.Insert(itemSelected.Index, itemDraged);
                    itemDraged = null;
                    itemSelected = null;
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_TestPrintLVItems_Click(object sender, EventArgs e)
        {
            string str = string.Empty;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                str += listView1.Items[i].Text + "\n";
            }
            MessageBox.Show(str);
        }

        private void btn_SelectExcels_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Title = "选择Excel文件";
            ofd.Filter = "Excel文件(*.xls,*.xlsx)|*.xls;*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in ofd.FileNames)
                {
                    listView1.Items.Add(item);
                }
            }
        }

        private void listView1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 46)
            {
                //string str = string.Empty;
                while (listView1.SelectedItems.Count > 0)
                {
                    //str += listView1.SelectedItems[0].Text + "\n";
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
                //MessageBox.Show(str);
            }
        }

        private void Btn_lvClear_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }
    }
}