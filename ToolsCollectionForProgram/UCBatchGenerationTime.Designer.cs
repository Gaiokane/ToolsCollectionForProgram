namespace ToolsCollectionForProgram
{
    partial class UCBatchGenerationTime
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBeginTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxDateTimeFormat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxLength = new System.Windows.Forms.TextBox();
            this.richtxtboxResultDate = new System.Windows.Forms.RichTextBox();
            this.radiobtnSeconds = new System.Windows.Forms.RadioButton();
            this.radiobtnMinutes = new System.Windows.Forms.RadioButton();
            this.radiobtnHours = new System.Windows.Forms.RadioButton();
            this.radiobtnDays = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxTimeInterval = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobtnSortDesc = new System.Windows.Forms.RadioButton();
            this.radiobtnSortAsc = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "起始时间：";
            // 
            // dtpBeginTime
            // 
            this.dtpBeginTime.Location = new System.Drawing.Point(87, 11);
            this.dtpBeginTime.Name = "dtpBeginTime";
            this.dtpBeginTime.Size = new System.Drawing.Size(179, 21);
            this.dtpBeginTime.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "时间格式：";
            // 
            // txtboxDateTimeFormat
            // 
            this.txtboxDateTimeFormat.Location = new System.Drawing.Point(87, 38);
            this.txtboxDateTimeFormat.Name = "txtboxDateTimeFormat";
            this.txtboxDateTimeFormat.Size = new System.Drawing.Size(179, 21);
            this.txtboxDateTimeFormat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "长度：";
            // 
            // txtboxLength
            // 
            this.txtboxLength.Location = new System.Drawing.Point(87, 87);
            this.txtboxLength.Name = "txtboxLength";
            this.txtboxLength.Size = new System.Drawing.Size(179, 21);
            this.txtboxLength.TabIndex = 5;
            this.txtboxLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxLength_KeyPress);
            // 
            // richtxtboxResultDate
            // 
            this.richtxtboxResultDate.Location = new System.Drawing.Point(3, 141);
            this.richtxtboxResultDate.Name = "richtxtboxResultDate";
            this.richtxtboxResultDate.Size = new System.Drawing.Size(686, 214);
            this.richtxtboxResultDate.TabIndex = 6;
            this.richtxtboxResultDate.Text = "";
            this.richtxtboxResultDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richtxtboxResultDate_MouseClick);
            // 
            // radiobtnSeconds
            // 
            this.radiobtnSeconds.AutoSize = true;
            this.radiobtnSeconds.Location = new System.Drawing.Point(87, 65);
            this.radiobtnSeconds.Name = "radiobtnSeconds";
            this.radiobtnSeconds.Size = new System.Drawing.Size(35, 16);
            this.radiobtnSeconds.TabIndex = 7;
            this.radiobtnSeconds.TabStop = true;
            this.radiobtnSeconds.Text = "秒";
            this.radiobtnSeconds.UseVisualStyleBackColor = true;
            // 
            // radiobtnMinutes
            // 
            this.radiobtnMinutes.AutoSize = true;
            this.radiobtnMinutes.Location = new System.Drawing.Point(128, 65);
            this.radiobtnMinutes.Name = "radiobtnMinutes";
            this.radiobtnMinutes.Size = new System.Drawing.Size(47, 16);
            this.radiobtnMinutes.TabIndex = 8;
            this.radiobtnMinutes.TabStop = true;
            this.radiobtnMinutes.Text = "分钟";
            this.radiobtnMinutes.UseVisualStyleBackColor = true;
            // 
            // radiobtnHours
            // 
            this.radiobtnHours.AutoSize = true;
            this.radiobtnHours.Location = new System.Drawing.Point(181, 65);
            this.radiobtnHours.Name = "radiobtnHours";
            this.radiobtnHours.Size = new System.Drawing.Size(47, 16);
            this.radiobtnHours.TabIndex = 9;
            this.radiobtnHours.TabStop = true;
            this.radiobtnHours.Text = "小时";
            this.radiobtnHours.UseVisualStyleBackColor = true;
            // 
            // radiobtnDays
            // 
            this.radiobtnDays.AutoSize = true;
            this.radiobtnDays.Location = new System.Drawing.Point(234, 65);
            this.radiobtnDays.Name = "radiobtnDays";
            this.radiobtnDays.Size = new System.Drawing.Size(35, 16);
            this.radiobtnDays.TabIndex = 10;
            this.radiobtnDays.TabStop = true;
            this.radiobtnDays.Text = "日";
            this.radiobtnDays.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "时间间隔：";
            // 
            // txtboxTimeInterval
            // 
            this.txtboxTimeInterval.Location = new System.Drawing.Point(87, 114);
            this.txtboxTimeInterval.Name = "txtboxTimeInterval";
            this.txtboxTimeInterval.Size = new System.Drawing.Size(179, 21);
            this.txtboxTimeInterval.TabIndex = 5;
            this.txtboxTimeInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxTimeInterval_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobtnSortDesc);
            this.groupBox1.Controls.Add(this.radiobtnSortAsc);
            this.groupBox1.Location = new System.Drawing.Point(272, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 42);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "排序方式";
            // 
            // radiobtnSortDesc
            // 
            this.radiobtnSortDesc.AutoSize = true;
            this.radiobtnSortDesc.Location = new System.Drawing.Point(59, 20);
            this.radiobtnSortDesc.Name = "radiobtnSortDesc";
            this.radiobtnSortDesc.Size = new System.Drawing.Size(47, 16);
            this.radiobtnSortDesc.TabIndex = 1;
            this.radiobtnSortDesc.TabStop = true;
            this.radiobtnSortDesc.Text = "降序";
            this.radiobtnSortDesc.UseVisualStyleBackColor = true;
            // 
            // radiobtnSortAsc
            // 
            this.radiobtnSortAsc.AutoSize = true;
            this.radiobtnSortAsc.Location = new System.Drawing.Point(6, 20);
            this.radiobtnSortAsc.Name = "radiobtnSortAsc";
            this.radiobtnSortAsc.Size = new System.Drawing.Size(47, 16);
            this.radiobtnSortAsc.TabIndex = 0;
            this.radiobtnSortAsc.TabStop = true;
            this.radiobtnSortAsc.Text = "升序";
            this.radiobtnSortAsc.UseVisualStyleBackColor = true;
            this.radiobtnSortAsc.CheckedChanged += new System.EventHandler(this.radiobtnSortAsc_CheckedChanged);
            // 
            // UCBatchGenerationTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radiobtnDays);
            this.Controls.Add(this.radiobtnHours);
            this.Controls.Add(this.radiobtnMinutes);
            this.Controls.Add(this.radiobtnSeconds);
            this.Controls.Add(this.richtxtboxResultDate);
            this.Controls.Add(this.txtboxTimeInterval);
            this.Controls.Add(this.txtboxLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxDateTimeFormat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpBeginTime);
            this.Controls.Add(this.label1);
            this.Name = "UCBatchGenerationTime";
            this.Size = new System.Drawing.Size(692, 358);
            this.Load += new System.EventHandler(this.UCBatchGenerationTime_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBeginTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxDateTimeFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxLength;
        private System.Windows.Forms.RichTextBox richtxtboxResultDate;
        private System.Windows.Forms.RadioButton radiobtnSeconds;
        private System.Windows.Forms.RadioButton radiobtnMinutes;
        private System.Windows.Forms.RadioButton radiobtnHours;
        private System.Windows.Forms.RadioButton radiobtnDays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxTimeInterval;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobtnSortAsc;
        private System.Windows.Forms.RadioButton radiobtnSortDesc;
    }
}
