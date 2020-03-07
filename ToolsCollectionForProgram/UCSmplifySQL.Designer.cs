namespace ToolsCollectionForProgram
{
    partial class UCSmplifySQL
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
            this.richtxtboxNew = new System.Windows.Forms.RichTextBox();
            this.richtxtboxOld = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richtxtboxNew
            // 
            this.richtxtboxNew.Location = new System.Drawing.Point(3, 182);
            this.richtxtboxNew.Name = "richtxtboxNew";
            this.richtxtboxNew.Size = new System.Drawing.Size(686, 173);
            this.richtxtboxNew.TabIndex = 3;
            this.richtxtboxNew.Text = "";
            this.richtxtboxNew.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richtxtboxNew_MouseClick);
            // 
            // richtxtboxOld
            // 
            this.richtxtboxOld.Location = new System.Drawing.Point(3, 3);
            this.richtxtboxOld.Name = "richtxtboxOld";
            this.richtxtboxOld.Size = new System.Drawing.Size(686, 173);
            this.richtxtboxOld.TabIndex = 2;
            this.richtxtboxOld.Text = "";
            // 
            // UCSmplifySQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richtxtboxNew);
            this.Controls.Add(this.richtxtboxOld);
            this.Name = "UCSmplifySQL";
            this.Size = new System.Drawing.Size(692, 358);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxtboxNew;
        private System.Windows.Forms.RichTextBox richtxtboxOld;
    }
}
