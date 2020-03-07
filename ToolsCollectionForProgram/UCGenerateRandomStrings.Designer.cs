namespace ToolsCollectionForProgram
{
    partial class UCGenerateRandomStrings
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
            this.radiobtn_GUID = new System.Windows.Forms.RadioButton();
            this.txtbox_length = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.radiobtn_Mixed = new System.Windows.Forms.RadioButton();
            this.radiobtn_ChineseCharacter = new System.Windows.Forms.RadioButton();
            this.radiobtn_Symbol = new System.Windows.Forms.RadioButton();
            this.radiobtn_NumberAndUppercaseAndLowerCaseLetters = new System.Windows.Forms.RadioButton();
            this.radiobtn_NumberAndUpperCaseLetters = new System.Windows.Forms.RadioButton();
            this.radiobtn_NumberAndLowerCaseLetters = new System.Windows.Forms.RadioButton();
            this.radiobtn_UppercaseAndLowerCaseLetters = new System.Windows.Forms.RadioButton();
            this.radiobtn_UpperCaseLetters = new System.Windows.Forms.RadioButton();
            this.radiobtn_LowerCaseLetters = new System.Windows.Forms.RadioButton();
            this.radiobtn_Number = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radiobtn_GUID
            // 
            this.radiobtn_GUID.AutoSize = true;
            this.radiobtn_GUID.Location = new System.Drawing.Point(411, 25);
            this.radiobtn_GUID.Name = "radiobtn_GUID";
            this.radiobtn_GUID.Size = new System.Drawing.Size(47, 16);
            this.radiobtn_GUID.TabIndex = 10;
            this.radiobtn_GUID.TabStop = true;
            this.radiobtn_GUID.Text = "GUID";
            this.radiobtn_GUID.UseVisualStyleBackColor = true;
            // 
            // txtbox_length
            // 
            this.txtbox_length.Location = new System.Drawing.Point(464, 24);
            this.txtbox_length.Name = "txtbox_length";
            this.txtbox_length.Size = new System.Drawing.Size(93, 21);
            this.txtbox_length.TabIndex = 11;
            this.txtbox_length.Text = "长度";
            this.txtbox_length.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtbox_length_MouseClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(49, 54);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(592, 301);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "数字√\n小写字母√\n大写字母√\n大小写字母√\n数字+小写字母√\n数字+大写字母√\n数字+大小写字母√\n符号√\n汉字√\n混合以上√\nGUID√";
            this.richTextBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseClick);
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(563, 22);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(78, 23);
            this.btn_generate.TabIndex = 12;
            this.btn_generate.Text = "生成";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // radiobtn_Mixed
            // 
            this.radiobtn_Mixed.AutoSize = true;
            this.radiobtn_Mixed.Location = new System.Drawing.Point(322, 25);
            this.radiobtn_Mixed.Name = "radiobtn_Mixed";
            this.radiobtn_Mixed.Size = new System.Drawing.Size(71, 16);
            this.radiobtn_Mixed.TabIndex = 9;
            this.radiobtn_Mixed.TabStop = true;
            this.radiobtn_Mixed.Text = "混合以上";
            this.radiobtn_Mixed.UseVisualStyleBackColor = true;
            // 
            // radiobtn_ChineseCharacter
            // 
            this.radiobtn_ChineseCharacter.AutoSize = true;
            this.radiobtn_ChineseCharacter.Location = new System.Drawing.Point(245, 25);
            this.radiobtn_ChineseCharacter.Name = "radiobtn_ChineseCharacter";
            this.radiobtn_ChineseCharacter.Size = new System.Drawing.Size(47, 16);
            this.radiobtn_ChineseCharacter.TabIndex = 8;
            this.radiobtn_ChineseCharacter.TabStop = true;
            this.radiobtn_ChineseCharacter.Text = "汉字";
            this.radiobtn_ChineseCharacter.UseVisualStyleBackColor = true;
            // 
            // radiobtn_Symbol
            // 
            this.radiobtn_Symbol.AutoSize = true;
            this.radiobtn_Symbol.Location = new System.Drawing.Point(168, 25);
            this.radiobtn_Symbol.Name = "radiobtn_Symbol";
            this.radiobtn_Symbol.Size = new System.Drawing.Size(47, 16);
            this.radiobtn_Symbol.TabIndex = 7;
            this.radiobtn_Symbol.TabStop = true;
            this.radiobtn_Symbol.Text = "符号";
            this.radiobtn_Symbol.UseVisualStyleBackColor = true;
            // 
            // radiobtn_NumberAndUppercaseAndLowerCaseLetters
            // 
            this.radiobtn_NumberAndUppercaseAndLowerCaseLetters.AutoSize = true;
            this.radiobtn_NumberAndUppercaseAndLowerCaseLetters.Location = new System.Drawing.Point(49, 25);
            this.radiobtn_NumberAndUppercaseAndLowerCaseLetters.Name = "radiobtn_NumberAndUppercaseAndLowerCaseLetters";
            this.radiobtn_NumberAndUppercaseAndLowerCaseLetters.Size = new System.Drawing.Size(113, 16);
            this.radiobtn_NumberAndUppercaseAndLowerCaseLetters.TabIndex = 6;
            this.radiobtn_NumberAndUppercaseAndLowerCaseLetters.TabStop = true;
            this.radiobtn_NumberAndUppercaseAndLowerCaseLetters.Text = "数字+大小写字母";
            this.radiobtn_NumberAndUppercaseAndLowerCaseLetters.UseVisualStyleBackColor = true;
            // 
            // radiobtn_NumberAndUpperCaseLetters
            // 
            this.radiobtn_NumberAndUpperCaseLetters.AutoSize = true;
            this.radiobtn_NumberAndUpperCaseLetters.Location = new System.Drawing.Point(518, 3);
            this.radiobtn_NumberAndUpperCaseLetters.Name = "radiobtn_NumberAndUpperCaseLetters";
            this.radiobtn_NumberAndUpperCaseLetters.Size = new System.Drawing.Size(101, 16);
            this.radiobtn_NumberAndUpperCaseLetters.TabIndex = 5;
            this.radiobtn_NumberAndUpperCaseLetters.TabStop = true;
            this.radiobtn_NumberAndUpperCaseLetters.Text = "数字+大写字母";
            this.radiobtn_NumberAndUpperCaseLetters.UseVisualStyleBackColor = true;
            // 
            // radiobtn_NumberAndLowerCaseLetters
            // 
            this.radiobtn_NumberAndLowerCaseLetters.AutoSize = true;
            this.radiobtn_NumberAndLowerCaseLetters.Location = new System.Drawing.Point(411, 3);
            this.radiobtn_NumberAndLowerCaseLetters.Name = "radiobtn_NumberAndLowerCaseLetters";
            this.radiobtn_NumberAndLowerCaseLetters.Size = new System.Drawing.Size(101, 16);
            this.radiobtn_NumberAndLowerCaseLetters.TabIndex = 4;
            this.radiobtn_NumberAndLowerCaseLetters.TabStop = true;
            this.radiobtn_NumberAndLowerCaseLetters.Text = "数字+小写字母";
            this.radiobtn_NumberAndLowerCaseLetters.UseVisualStyleBackColor = true;
            // 
            // radiobtn_UppercaseAndLowerCaseLetters
            // 
            this.radiobtn_UppercaseAndLowerCaseLetters.AutoSize = true;
            this.radiobtn_UppercaseAndLowerCaseLetters.Location = new System.Drawing.Point(322, 3);
            this.radiobtn_UppercaseAndLowerCaseLetters.Name = "radiobtn_UppercaseAndLowerCaseLetters";
            this.radiobtn_UppercaseAndLowerCaseLetters.Size = new System.Drawing.Size(83, 16);
            this.radiobtn_UppercaseAndLowerCaseLetters.TabIndex = 3;
            this.radiobtn_UppercaseAndLowerCaseLetters.TabStop = true;
            this.radiobtn_UppercaseAndLowerCaseLetters.Text = "大小写字母";
            this.radiobtn_UppercaseAndLowerCaseLetters.UseVisualStyleBackColor = true;
            // 
            // radiobtn_UpperCaseLetters
            // 
            this.radiobtn_UpperCaseLetters.AutoSize = true;
            this.radiobtn_UpperCaseLetters.Location = new System.Drawing.Point(245, 3);
            this.radiobtn_UpperCaseLetters.Name = "radiobtn_UpperCaseLetters";
            this.radiobtn_UpperCaseLetters.Size = new System.Drawing.Size(71, 16);
            this.radiobtn_UpperCaseLetters.TabIndex = 2;
            this.radiobtn_UpperCaseLetters.TabStop = true;
            this.radiobtn_UpperCaseLetters.Text = "大写字母";
            this.radiobtn_UpperCaseLetters.UseVisualStyleBackColor = true;
            // 
            // radiobtn_LowerCaseLetters
            // 
            this.radiobtn_LowerCaseLetters.AutoSize = true;
            this.radiobtn_LowerCaseLetters.Location = new System.Drawing.Point(168, 3);
            this.radiobtn_LowerCaseLetters.Name = "radiobtn_LowerCaseLetters";
            this.radiobtn_LowerCaseLetters.Size = new System.Drawing.Size(71, 16);
            this.radiobtn_LowerCaseLetters.TabIndex = 1;
            this.radiobtn_LowerCaseLetters.TabStop = true;
            this.radiobtn_LowerCaseLetters.Text = "小写字母";
            this.radiobtn_LowerCaseLetters.UseVisualStyleBackColor = true;
            // 
            // radiobtn_Number
            // 
            this.radiobtn_Number.AutoSize = true;
            this.radiobtn_Number.Location = new System.Drawing.Point(49, 3);
            this.radiobtn_Number.Name = "radiobtn_Number";
            this.radiobtn_Number.Size = new System.Drawing.Size(47, 16);
            this.radiobtn_Number.TabIndex = 0;
            this.radiobtn_Number.TabStop = true;
            this.radiobtn_Number.Text = "数字";
            this.radiobtn_Number.UseVisualStyleBackColor = true;
            // 
            // UCGenerateRandomStrings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radiobtn_GUID);
            this.Controls.Add(this.txtbox_length);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.radiobtn_Mixed);
            this.Controls.Add(this.radiobtn_ChineseCharacter);
            this.Controls.Add(this.radiobtn_Symbol);
            this.Controls.Add(this.radiobtn_NumberAndUppercaseAndLowerCaseLetters);
            this.Controls.Add(this.radiobtn_NumberAndUpperCaseLetters);
            this.Controls.Add(this.radiobtn_NumberAndLowerCaseLetters);
            this.Controls.Add(this.radiobtn_UppercaseAndLowerCaseLetters);
            this.Controls.Add(this.radiobtn_UpperCaseLetters);
            this.Controls.Add(this.radiobtn_LowerCaseLetters);
            this.Controls.Add(this.radiobtn_Number);
            this.Name = "UCGenerateRandomStrings";
            this.Size = new System.Drawing.Size(692, 358);
            this.Load += new System.EventHandler(this.UCGenerateRandomStrings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radiobtn_GUID;
        private System.Windows.Forms.TextBox txtbox_length;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.RadioButton radiobtn_Mixed;
        private System.Windows.Forms.RadioButton radiobtn_ChineseCharacter;
        private System.Windows.Forms.RadioButton radiobtn_Symbol;
        private System.Windows.Forms.RadioButton radiobtn_NumberAndUppercaseAndLowerCaseLetters;
        private System.Windows.Forms.RadioButton radiobtn_NumberAndUpperCaseLetters;
        private System.Windows.Forms.RadioButton radiobtn_NumberAndLowerCaseLetters;
        private System.Windows.Forms.RadioButton radiobtn_UppercaseAndLowerCaseLetters;
        private System.Windows.Forms.RadioButton radiobtn_UpperCaseLetters;
        private System.Windows.Forms.RadioButton radiobtn_LowerCaseLetters;
        private System.Windows.Forms.RadioButton radiobtn_Number;
    }
}
