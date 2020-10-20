namespace ToolsCollectionForProgram
{
    partial class FrmDatabasesNameList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtboxDataBaseName = new System.Windows.Forms.TextBox();
            this.labDataBaseName = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(189, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtboxDataBaseName
            // 
            this.txtboxDataBaseName.Location = new System.Drawing.Point(83, 12);
            this.txtboxDataBaseName.Name = "txtboxDataBaseName";
            this.txtboxDataBaseName.Size = new System.Drawing.Size(100, 21);
            this.txtboxDataBaseName.TabIndex = 6;
            // 
            // labDataBaseName
            // 
            this.labDataBaseName.AutoSize = true;
            this.labDataBaseName.Location = new System.Drawing.Point(12, 15);
            this.labDataBaseName.Name = "labDataBaseName";
            this.labDataBaseName.Size = new System.Drawing.Size(65, 12);
            this.labDataBaseName.TabIndex = 5;
            this.labDataBaseName.Text = "数据库名：";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.Location = new System.Drawing.Point(12, 40);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(260, 409);
            this.treeView1.TabIndex = 4;
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            this.treeView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treeView1_KeyPress);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // FrmDatabasesNameList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtboxDataBaseName);
            this.Controls.Add(this.labDataBaseName);
            this.Controls.Add(this.treeView1);
            this.Name = "FrmDatabasesNameList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库名列表";
            this.Load += new System.EventHandler(this.FrmDatabasesNameList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtboxDataBaseName;
        private System.Windows.Forms.Label labDataBaseName;
        private System.Windows.Forms.TreeView treeView1;
    }
}