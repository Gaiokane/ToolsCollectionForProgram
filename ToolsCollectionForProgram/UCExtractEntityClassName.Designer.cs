namespace ToolsCollectionForProgram
{
    partial class UCExtractEntityClassName
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
            this.labEntityClass = new System.Windows.Forms.Label();
            this.richtxtboxEntityClass = new System.Windows.Forms.RichTextBox();
            this.labto = new System.Windows.Forms.Label();
            this.labEntityClassName = new System.Windows.Forms.Label();
            this.richtxtboxEntityClassName = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labEntityClass
            // 
            this.labEntityClass.AutoSize = true;
            this.labEntityClass.Location = new System.Drawing.Point(10, 7);
            this.labEntityClass.Name = "labEntityClass";
            this.labEntityClass.Size = new System.Drawing.Size(53, 12);
            this.labEntityClass.TabIndex = 0;
            this.labEntityClass.Text = "实体类：";
            // 
            // richtxtboxEntityClass
            // 
            this.richtxtboxEntityClass.Location = new System.Drawing.Point(12, 22);
            this.richtxtboxEntityClass.Name = "richtxtboxEntityClass";
            this.richtxtboxEntityClass.Size = new System.Drawing.Size(320, 333);
            this.richtxtboxEntityClass.TabIndex = 1;
            this.richtxtboxEntityClass.Text = "public int Id { get; set; }\npublic string Commodityname { get; set; }\n双击全选";
            this.richtxtboxEntityClass.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.richtxtboxEntityClass_MouseDoubleClick);
            // 
            // labto
            // 
            this.labto.AutoSize = true;
            this.labto.Location = new System.Drawing.Point(338, 183);
            this.labto.Name = "labto";
            this.labto.Size = new System.Drawing.Size(17, 12);
            this.labto.TabIndex = 2;
            this.labto.Text = "=>";
            // 
            // labEntityClassName
            // 
            this.labEntityClassName.AutoSize = true;
            this.labEntityClassName.Location = new System.Drawing.Point(359, 7);
            this.labEntityClassName.Name = "labEntityClassName";
            this.labEntityClassName.Size = new System.Drawing.Size(65, 12);
            this.labEntityClassName.TabIndex = 3;
            this.labEntityClassName.Text = "实体类名：";
            // 
            // richtxtboxEntityClassName
            // 
            this.richtxtboxEntityClassName.Location = new System.Drawing.Point(361, 22);
            this.richtxtboxEntityClassName.Name = "richtxtboxEntityClassName";
            this.richtxtboxEntityClassName.Size = new System.Drawing.Size(320, 333);
            this.richtxtboxEntityClassName.TabIndex = 4;
            this.richtxtboxEntityClassName.Text = "";
            this.richtxtboxEntityClassName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richtxtboxEntityClassName_MouseClick);
            // 
            // UCExtractEntityClassName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richtxtboxEntityClassName);
            this.Controls.Add(this.labEntityClassName);
            this.Controls.Add(this.labto);
            this.Controls.Add(this.richtxtboxEntityClass);
            this.Controls.Add(this.labEntityClass);
            this.Name = "UCExtractEntityClassName";
            this.Size = new System.Drawing.Size(692, 358);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labEntityClass;
        private System.Windows.Forms.RichTextBox richtxtboxEntityClass;
        private System.Windows.Forms.Label labto;
        private System.Windows.Forms.Label labEntityClassName;
        private System.Windows.Forms.RichTextBox richtxtboxEntityClassName;
    }
}
