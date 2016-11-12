namespace island
{
    partial class FormModalDialogRain
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
            this.radioButtonRainAbsent = new System.Windows.Forms.RadioButton();
            this.radioButtonRainWeak = new System.Windows.Forms.RadioButton();
            this.radioButtonRainMiddle = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonRainStrong = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonRainAbsent
            // 
            this.radioButtonRainAbsent.AutoSize = true;
            this.radioButtonRainAbsent.Checked = true;
            this.radioButtonRainAbsent.Location = new System.Drawing.Point(12, 56);
            this.radioButtonRainAbsent.Name = "radioButtonRainAbsent";
            this.radioButtonRainAbsent.Size = new System.Drawing.Size(79, 17);
            this.radioButtonRainAbsent.TabIndex = 5;
            this.radioButtonRainAbsent.TabStop = true;
            this.radioButtonRainAbsent.Text = "Без дождя";
            this.radioButtonRainAbsent.UseVisualStyleBackColor = true;
            this.radioButtonRainAbsent.CheckedChanged += new System.EventHandler(this.onRadioButtonRainAbsentCheckedChanged);
            // 
            // radioButtonRainWeak
            // 
            this.radioButtonRainWeak.AutoSize = true;
            this.radioButtonRainWeak.Location = new System.Drawing.Point(12, 89);
            this.radioButtonRainWeak.Name = "radioButtonRainWeak";
            this.radioButtonRainWeak.Size = new System.Drawing.Size(99, 17);
            this.radioButtonRainWeak.TabIndex = 6;
            this.radioButtonRainWeak.Text = "Слабый дождь";
            this.radioButtonRainWeak.UseVisualStyleBackColor = true;
            this.radioButtonRainWeak.CheckedChanged += new System.EventHandler(this.onRadioButtonRainWeakCheckedChanged);
            // 
            // radioButtonRainMiddle
            // 
            this.radioButtonRainMiddle.AutoSize = true;
            this.radioButtonRainMiddle.Location = new System.Drawing.Point(12, 127);
            this.radioButtonRainMiddle.Name = "radioButtonRainMiddle";
            this.radioButtonRainMiddle.Size = new System.Drawing.Size(85, 17);
            this.radioButtonRainMiddle.TabIndex = 7;
            this.radioButtonRainMiddle.Text = "Умеренный";
            this.radioButtonRainMiddle.UseVisualStyleBackColor = true;
            this.radioButtonRainMiddle.CheckedChanged += new System.EventHandler(this.onRadioButtonRainMiddleCheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Подтвердить выбор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onConfirmSelectionButtonTouched);
            // 
            // radioButtonRainStrong
            // 
            this.radioButtonRainStrong.AutoSize = true;
            this.radioButtonRainStrong.Location = new System.Drawing.Point(12, 167);
            this.radioButtonRainStrong.Name = "radioButtonRainStrong";
            this.radioButtonRainStrong.Size = new System.Drawing.Size(63, 17);
            this.radioButtonRainStrong.TabIndex = 8;
            this.radioButtonRainStrong.Text = "Ливень";
            this.radioButtonRainStrong.UseVisualStyleBackColor = true;
            this.radioButtonRainStrong.CheckedChanged += new System.EventHandler(this.onRadioButtonRainStrongCheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Установить дождь";
            // 
            // FormModalDialogRain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 249);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonRainStrong);
            this.Controls.Add(this.radioButtonRainMiddle);
            this.Controls.Add(this.radioButtonRainWeak);
            this.Controls.Add(this.radioButtonRainAbsent);
            this.Name = "FormModalDialogRain";
            this.Text = "FormModalDialogRain";
            this.Load += new System.EventHandler(this.FormModalDialogRain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonRainAbsent;
        private System.Windows.Forms.RadioButton radioButtonRainWeak;
        private System.Windows.Forms.RadioButton radioButtonRainMiddle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonRainStrong;
        private System.Windows.Forms.Label label1;
    }
}