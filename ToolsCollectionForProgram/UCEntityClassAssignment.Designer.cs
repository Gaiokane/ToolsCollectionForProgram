namespace ToolsCollectionForProgram
{
    partial class UCEntityClassAssignment
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
            this.labLeftEntityClassName = new System.Windows.Forms.Label();
            this.txtboxLeftEntityClassName = new System.Windows.Forms.TextBox();
            this.labRightEntityClassName = new System.Windows.Forms.Label();
            this.txtboxRightEntityClassName = new System.Windows.Forms.TextBox();
            this.labEntityClassAttribute = new System.Windows.Forms.Label();
            this.richtxtboxEntityClassAttribute = new System.Windows.Forms.RichTextBox();
            this.richtxtboxResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labLeftEntityClassName
            // 
            this.labLeftEntityClassName.AutoSize = true;
            this.labLeftEntityClassName.Location = new System.Drawing.Point(3, 6);
            this.labLeftEntityClassName.Name = "labLeftEntityClassName";
            this.labLeftEntityClassName.Size = new System.Drawing.Size(77, 12);
            this.labLeftEntityClassName.TabIndex = 0;
            this.labLeftEntityClassName.Text = "左实体类名：";
            // 
            // txtboxLeftEntityClassName
            // 
            this.txtboxLeftEntityClassName.Location = new System.Drawing.Point(86, 3);
            this.txtboxLeftEntityClassName.Name = "txtboxLeftEntityClassName";
            this.txtboxLeftEntityClassName.Size = new System.Drawing.Size(161, 21);
            this.txtboxLeftEntityClassName.TabIndex = 1;
            // 
            // labRightEntityClassName
            // 
            this.labRightEntityClassName.AutoSize = true;
            this.labRightEntityClassName.Location = new System.Drawing.Point(3, 33);
            this.labRightEntityClassName.Name = "labRightEntityClassName";
            this.labRightEntityClassName.Size = new System.Drawing.Size(77, 12);
            this.labRightEntityClassName.TabIndex = 2;
            this.labRightEntityClassName.Text = "右实体类名：";
            // 
            // txtboxRightEntityClassName
            // 
            this.txtboxRightEntityClassName.Location = new System.Drawing.Point(86, 30);
            this.txtboxRightEntityClassName.Name = "txtboxRightEntityClassName";
            this.txtboxRightEntityClassName.Size = new System.Drawing.Size(161, 21);
            this.txtboxRightEntityClassName.TabIndex = 3;
            // 
            // labEntityClassAttribute
            // 
            this.labEntityClassAttribute.AutoSize = true;
            this.labEntityClassAttribute.Location = new System.Drawing.Point(3, 60);
            this.labEntityClassAttribute.Name = "labEntityClassAttribute";
            this.labEntityClassAttribute.Size = new System.Drawing.Size(77, 12);
            this.labEntityClassAttribute.TabIndex = 4;
            this.labEntityClassAttribute.Text = "实体类属性：";
            // 
            // richtxtboxEntityClassAttribute
            // 
            this.richtxtboxEntityClassAttribute.Location = new System.Drawing.Point(86, 57);
            this.richtxtboxEntityClassAttribute.Name = "richtxtboxEntityClassAttribute";
            this.richtxtboxEntityClassAttribute.Size = new System.Drawing.Size(161, 298);
            this.richtxtboxEntityClassAttribute.TabIndex = 5;
            this.richtxtboxEntityClassAttribute.Text = "";
            // 
            // richtxtboxResult
            // 
            this.richtxtboxResult.Location = new System.Drawing.Point(253, 3);
            this.richtxtboxResult.Name = "richtxtboxResult";
            this.richtxtboxResult.Size = new System.Drawing.Size(406, 352);
            this.richtxtboxResult.TabIndex = 6;
            this.richtxtboxResult.Text = "";
            this.richtxtboxResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richtxtboxResult_MouseClick);
            // 
            // UCEntityClassAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richtxtboxResult);
            this.Controls.Add(this.richtxtboxEntityClassAttribute);
            this.Controls.Add(this.labEntityClassAttribute);
            this.Controls.Add(this.txtboxRightEntityClassName);
            this.Controls.Add(this.labRightEntityClassName);
            this.Controls.Add(this.txtboxLeftEntityClassName);
            this.Controls.Add(this.labLeftEntityClassName);
            this.Name = "UCEntityClassAssignment";
            this.Size = new System.Drawing.Size(692, 358);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLeftEntityClassName;
        private System.Windows.Forms.TextBox txtboxLeftEntityClassName;
        private System.Windows.Forms.Label labRightEntityClassName;
        private System.Windows.Forms.TextBox txtboxRightEntityClassName;
        private System.Windows.Forms.Label labEntityClassAttribute;
        private System.Windows.Forms.RichTextBox richtxtboxEntityClassAttribute;
        private System.Windows.Forms.RichTextBox richtxtboxResult;
    }
}
