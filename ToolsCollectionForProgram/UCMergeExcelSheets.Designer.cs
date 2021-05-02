namespace ToolsCollectionForProgram
{
    partial class UCMergeExcelSheets
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_TestResetLV = new System.Windows.Forms.Button();
            this.btn_TestPrintLVItems = new System.Windows.Forms.Button();
            this.btn_SelectExcels = new System.Windows.Forms.Button();
            this.btn_Merge = new System.Windows.Forms.Button();
            this.Btn_lvClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(399, 323);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView1_ItemDrag);
            this.listView1.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listView1_ItemMouseHover);
            this.listView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyUp);
            this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
            // 
            // btn_TestResetLV
            // 
            this.btn_TestResetLV.Location = new System.Drawing.Point(246, 3);
            this.btn_TestResetLV.Name = "btn_TestResetLV";
            this.btn_TestResetLV.Size = new System.Drawing.Size(75, 23);
            this.btn_TestResetLV.TabIndex = 1;
            this.btn_TestResetLV.Text = "重置lv";
            this.btn_TestResetLV.UseVisualStyleBackColor = true;
            this.btn_TestResetLV.Click += new System.EventHandler(this.btn_TestResetLV_Click);
            // 
            // btn_TestPrintLVItems
            // 
            this.btn_TestPrintLVItems.Location = new System.Drawing.Point(327, 3);
            this.btn_TestPrintLVItems.Name = "btn_TestPrintLVItems";
            this.btn_TestPrintLVItems.Size = new System.Drawing.Size(75, 23);
            this.btn_TestPrintLVItems.TabIndex = 2;
            this.btn_TestPrintLVItems.Text = "输出lv项";
            this.btn_TestPrintLVItems.UseVisualStyleBackColor = true;
            this.btn_TestPrintLVItems.Click += new System.EventHandler(this.btn_TestPrintLVItems_Click);
            // 
            // btn_SelectExcels
            // 
            this.btn_SelectExcels.Location = new System.Drawing.Point(3, 3);
            this.btn_SelectExcels.Name = "btn_SelectExcels";
            this.btn_SelectExcels.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectExcels.TabIndex = 3;
            this.btn_SelectExcels.Text = "选择Excel";
            this.btn_SelectExcels.UseVisualStyleBackColor = true;
            this.btn_SelectExcels.Click += new System.EventHandler(this.btn_SelectExcels_Click);
            // 
            // btn_Merge
            // 
            this.btn_Merge.Location = new System.Drawing.Point(84, 3);
            this.btn_Merge.Name = "btn_Merge";
            this.btn_Merge.Size = new System.Drawing.Size(75, 23);
            this.btn_Merge.TabIndex = 4;
            this.btn_Merge.Text = "合并";
            this.btn_Merge.UseVisualStyleBackColor = true;
            // 
            // Btn_lvClear
            // 
            this.Btn_lvClear.Location = new System.Drawing.Point(165, 3);
            this.Btn_lvClear.Name = "Btn_lvClear";
            this.Btn_lvClear.Size = new System.Drawing.Size(75, 23);
            this.Btn_lvClear.TabIndex = 5;
            this.Btn_lvClear.Text = "清空";
            this.Btn_lvClear.UseVisualStyleBackColor = true;
            this.Btn_lvClear.Click += new System.EventHandler(this.Btn_lvClear_Click);
            // 
            // UCMergeExcelSheets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_lvClear);
            this.Controls.Add(this.btn_Merge);
            this.Controls.Add(this.btn_SelectExcels);
            this.Controls.Add(this.btn_TestPrintLVItems);
            this.Controls.Add(this.btn_TestResetLV);
            this.Controls.Add(this.listView1);
            this.Name = "UCMergeExcelSheets";
            this.Size = new System.Drawing.Size(692, 358);
            this.Load += new System.EventHandler(this.UCMergeExcelSheets_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_TestResetLV;
        private System.Windows.Forms.Button btn_TestPrintLVItems;
        private System.Windows.Forms.Button btn_SelectExcels;
        private System.Windows.Forms.Button btn_Merge;
        private System.Windows.Forms.Button Btn_lvClear;
    }
}
