namespace ToolsCollectionForProgram
{
    partial class UCRemainingDownloadTimeCalculator
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
            this.labelTimeLeft = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtboxSpeed = new System.Windows.Forms.TextBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.radioBtnGB = new System.Windows.Forms.RadioButton();
            this.radioBtnMB = new System.Windows.Forms.RadioButton();
            this.txtboxSize = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.radioBtnKBs = new System.Windows.Forms.RadioButton();
            this.radioBtnMBs = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTimeLeft
            // 
            this.labelTimeLeft.AutoSize = true;
            this.labelTimeLeft.Location = new System.Drawing.Point(190, 201);
            this.labelTimeLeft.Name = "labelTimeLeft";
            this.labelTimeLeft.Size = new System.Drawing.Size(41, 12);
            this.labelTimeLeft.TabIndex = 18;
            this.labelTimeLeft.Text = "剩余：";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(452, 166);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 17;
            this.btnCalc.Text = "计算";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtboxSpeed
            // 
            this.txtboxSpeed.Location = new System.Drawing.Point(237, 168);
            this.txtboxSpeed.Name = "txtboxSpeed";
            this.txtboxSpeed.Size = new System.Drawing.Size(100, 21);
            this.txtboxSpeed.TabIndex = 16;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(166, 171);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(65, 12);
            this.labelSpeed.TabIndex = 15;
            this.labelSpeed.Text = "下载速度：";
            // 
            // radioBtnGB
            // 
            this.radioBtnGB.AutoSize = true;
            this.radioBtnGB.Location = new System.Drawing.Point(399, 142);
            this.radioBtnGB.Name = "radioBtnGB";
            this.radioBtnGB.Size = new System.Drawing.Size(35, 16);
            this.radioBtnGB.TabIndex = 14;
            this.radioBtnGB.TabStop = true;
            this.radioBtnGB.Text = "GB";
            this.radioBtnGB.UseVisualStyleBackColor = true;
            // 
            // radioBtnMB
            // 
            this.radioBtnMB.AutoSize = true;
            this.radioBtnMB.Location = new System.Drawing.Point(343, 142);
            this.radioBtnMB.Name = "radioBtnMB";
            this.radioBtnMB.Size = new System.Drawing.Size(35, 16);
            this.radioBtnMB.TabIndex = 13;
            this.radioBtnMB.TabStop = true;
            this.radioBtnMB.Text = "MB";
            this.radioBtnMB.UseVisualStyleBackColor = true;
            // 
            // txtboxSize
            // 
            this.txtboxSize.Location = new System.Drawing.Point(237, 141);
            this.txtboxSize.Name = "txtboxSize";
            this.txtboxSize.Size = new System.Drawing.Size(100, 21);
            this.txtboxSize.TabIndex = 12;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(190, 144);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(41, 12);
            this.labelSize.TabIndex = 11;
            this.labelSize.Text = "大小：";
            // 
            // radioBtnKBs
            // 
            this.radioBtnKBs.AutoSize = true;
            this.radioBtnKBs.Location = new System.Drawing.Point(0, 3);
            this.radioBtnKBs.Name = "radioBtnKBs";
            this.radioBtnKBs.Size = new System.Drawing.Size(47, 16);
            this.radioBtnKBs.TabIndex = 8;
            this.radioBtnKBs.TabStop = true;
            this.radioBtnKBs.Text = "KB/s";
            this.radioBtnKBs.UseVisualStyleBackColor = true;
            // 
            // radioBtnMBs
            // 
            this.radioBtnMBs.AutoSize = true;
            this.radioBtnMBs.Location = new System.Drawing.Point(56, 3);
            this.radioBtnMBs.Name = "radioBtnMBs";
            this.radioBtnMBs.Size = new System.Drawing.Size(47, 16);
            this.radioBtnMBs.TabIndex = 9;
            this.radioBtnMBs.TabStop = true;
            this.radioBtnMBs.Text = "MB/s";
            this.radioBtnMBs.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBtnKBs);
            this.panel1.Controls.Add(this.radioBtnMBs);
            this.panel1.Location = new System.Drawing.Point(343, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 45);
            this.panel1.TabIndex = 19;
            // 
            // UCRemainingDownloadTimeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTimeLeft);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtboxSpeed);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.radioBtnGB);
            this.Controls.Add(this.radioBtnMB);
            this.Controls.Add(this.txtboxSize);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.panel1);
            this.Name = "UCRemainingDownloadTimeCalculator";
            this.Size = new System.Drawing.Size(692, 358);
            this.Load += new System.EventHandler(this.UCRemainingDownloadTimeCalculator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTimeLeft;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtboxSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.RadioButton radioBtnGB;
        private System.Windows.Forms.RadioButton radioBtnMB;
        private System.Windows.Forms.TextBox txtboxSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.RadioButton radioBtnKBs;
        private System.Windows.Forms.RadioButton radioBtnMBs;
        private System.Windows.Forms.Panel panel1;
    }
}
