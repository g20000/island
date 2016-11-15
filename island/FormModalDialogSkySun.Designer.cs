namespace island
{
    partial class FormModalDialogSkySun
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonSkySunAbsent = new System.Windows.Forms.RadioButton();
            this.radioButtonSkySunWeak = new System.Windows.Forms.RadioButton();
            this.radioButtonSkySunMiddle = new System.Windows.Forms.RadioButton();
            this.radioButtonSkySunHigh = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Установить солнце или дождь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Установить солнце";
            // 
            // radioButtonSkySunAbsent
            // 
            this.radioButtonSkySunAbsent.AutoSize = true;
            this.radioButtonSkySunAbsent.Checked = true;
            this.radioButtonSkySunAbsent.Location = new System.Drawing.Point(15, 63);
            this.radioButtonSkySunAbsent.Name = "radioButtonSkySunAbsent";
            this.radioButtonSkySunAbsent.Size = new System.Drawing.Size(82, 17);
            this.radioButtonSkySunAbsent.TabIndex = 2;
            this.radioButtonSkySunAbsent.TabStop = true;
            this.radioButtonSkySunAbsent.Text = "Солнца нет";
            this.radioButtonSkySunAbsent.UseVisualStyleBackColor = true;
            this.radioButtonSkySunAbsent.CheckedChanged += new System.EventHandler(this.onRadioButtonSkySunLevelAbsentCheckedChanged);
            // 
            // radioButtonSkySunWeak
            // 
            this.radioButtonSkySunWeak.AutoSize = true;
            this.radioButtonSkySunWeak.Location = new System.Drawing.Point(15, 96);
            this.radioButtonSkySunWeak.Name = "radioButtonSkySunWeak";
            this.radioButtonSkySunWeak.Size = new System.Drawing.Size(101, 17);
            this.radioButtonSkySunWeak.TabIndex = 3;
            this.radioButtonSkySunWeak.Text = "Слабое солнце";
            this.radioButtonSkySunWeak.UseVisualStyleBackColor = true;
            this.radioButtonSkySunWeak.CheckedChanged += new System.EventHandler(this.onRadioButtonSkySunLevelWeakCheckedChanged);
            // 
            // radioButtonSkySunMiddle
            // 
            this.radioButtonSkySunMiddle.AutoSize = true;
            this.radioButtonSkySunMiddle.Location = new System.Drawing.Point(15, 133);
            this.radioButtonSkySunMiddle.Name = "radioButtonSkySunMiddle";
            this.radioButtonSkySunMiddle.Size = new System.Drawing.Size(122, 17);
            this.radioButtonSkySunMiddle.TabIndex = 4;
            this.radioButtonSkySunMiddle.Text = "Умеренное солнце";
            this.radioButtonSkySunMiddle.UseVisualStyleBackColor = true;
            this.radioButtonSkySunMiddle.CheckedChanged += new System.EventHandler(this.onRadioButtonSkySunLevelMiddleCheckedChanged);
            // 
            // radioButtonSkySunHigh
            // 
            this.radioButtonSkySunHigh.AutoSize = true;
            this.radioButtonSkySunHigh.Location = new System.Drawing.Point(15, 174);
            this.radioButtonSkySunHigh.Name = "radioButtonSkySunHigh";
            this.radioButtonSkySunHigh.Size = new System.Drawing.Size(54, 17);
            this.radioButtonSkySunHigh.TabIndex = 5;
            this.radioButtonSkySunHigh.Text = "Жара";
            this.radioButtonSkySunHigh.UseVisualStyleBackColor = true;
            this.radioButtonSkySunHigh.CheckedChanged += new System.EventHandler(this.onRadioButtonSkySunLevelHighCheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Подтвердить установку солнца";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onConfirmSelectionSkySunButtonTouched);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "А может быть...";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Установить дождь";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormModalDialogSkySun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonSkySunHigh);
            this.Controls.Add(this.radioButtonSkySunMiddle);
            this.Controls.Add(this.radioButtonSkySunWeak);
            this.Controls.Add(this.radioButtonSkySunAbsent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormModalDialogSkySun";
            this.Text = "FormModalDialogSkySun";
            this.Load += new System.EventHandler(this.FormModalDialogSkySun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonSkySunAbsent;
        private System.Windows.Forms.RadioButton radioButtonSkySunWeak;
        private System.Windows.Forms.RadioButton radioButtonSkySunMiddle;
        private System.Windows.Forms.RadioButton radioButtonSkySunHigh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}