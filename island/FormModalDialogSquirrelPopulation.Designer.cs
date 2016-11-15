namespace island
{
    partial class FormModalDialogSquirrelPopulation
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
            this.radioButtonSquirrelPopulationAbsent = new System.Windows.Forms.RadioButton();
            this.radioButtonSquirrelPopulationLow = new System.Windows.Forms.RadioButton();
            this.radioButtonSqurrelPopulationMiddle = new System.Windows.Forms.RadioButton();
            this.radioButtonSquirrelPopulationHigh = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Установить численность белок";
            // 
            // radioButtonSquirrelPopulationAbsent
            // 
            this.radioButtonSquirrelPopulationAbsent.AutoSize = true;
            this.radioButtonSquirrelPopulationAbsent.Location = new System.Drawing.Point(13, 44);
            this.radioButtonSquirrelPopulationAbsent.Name = "radioButtonSquirrelPopulationAbsent";
            this.radioButtonSquirrelPopulationAbsent.Size = new System.Drawing.Size(77, 17);
            this.radioButtonSquirrelPopulationAbsent.TabIndex = 1;
            this.radioButtonSquirrelPopulationAbsent.TabStop = true;
            this.radioButtonSquirrelPopulationAbsent.Text = "Нет белок";
            this.radioButtonSquirrelPopulationAbsent.UseVisualStyleBackColor = true;
            this.radioButtonSquirrelPopulationAbsent.CheckedChanged += new System.EventHandler(this.onRadioButtonSquirrelPopulationAbsentCheckedChanged);
            // 
            // radioButtonSquirrelPopulationLow
            // 
            this.radioButtonSquirrelPopulationLow.AutoSize = true;
            this.radioButtonSquirrelPopulationLow.Location = new System.Drawing.Point(13, 85);
            this.radioButtonSquirrelPopulationLow.Name = "radioButtonSquirrelPopulationLow";
            this.radioButtonSquirrelPopulationLow.Size = new System.Drawing.Size(85, 17);
            this.radioButtonSquirrelPopulationLow.TabIndex = 2;
            this.radioButtonSquirrelPopulationLow.TabStop = true;
            this.radioButtonSquirrelPopulationLow.Text = "Мало белок";
            this.radioButtonSquirrelPopulationLow.UseVisualStyleBackColor = true;
            this.radioButtonSquirrelPopulationLow.CheckedChanged += new System.EventHandler(this.onRadioButtonSquirrelPopulationWeakCheckedChanged);
            // 
            // radioButtonSqurrelPopulationMiddle
            // 
            this.radioButtonSqurrelPopulationMiddle.AutoSize = true;
            this.radioButtonSqurrelPopulationMiddle.Location = new System.Drawing.Point(13, 133);
            this.radioButtonSqurrelPopulationMiddle.Name = "radioButtonSqurrelPopulationMiddle";
            this.radioButtonSqurrelPopulationMiddle.Size = new System.Drawing.Size(162, 17);
            this.radioButtonSqurrelPopulationMiddle.TabIndex = 3;
            this.radioButtonSqurrelPopulationMiddle.TabStop = true;
            this.radioButtonSqurrelPopulationMiddle.Text = "Среднее количество белок";
            this.radioButtonSqurrelPopulationMiddle.UseVisualStyleBackColor = true;
            this.radioButtonSqurrelPopulationMiddle.CheckedChanged += new System.EventHandler(this.onRadioButtonSquirrelPopulationMiddleCheckedChanged);
            // 
            // radioButtonSquirrelPopulationHigh
            // 
            this.radioButtonSquirrelPopulationHigh.AutoSize = true;
            this.radioButtonSquirrelPopulationHigh.Location = new System.Drawing.Point(13, 181);
            this.radioButtonSquirrelPopulationHigh.Name = "radioButtonSquirrelPopulationHigh";
            this.radioButtonSquirrelPopulationHigh.Size = new System.Drawing.Size(90, 17);
            this.radioButtonSquirrelPopulationHigh.TabIndex = 4;
            this.radioButtonSquirrelPopulationHigh.TabStop = true;
            this.radioButtonSquirrelPopulationHigh.Text = "Много белок";
            this.radioButtonSquirrelPopulationHigh.UseVisualStyleBackColor = true;
            this.radioButtonSquirrelPopulationHigh.CheckedChanged += new System.EventHandler(this.onRadioButtonSquirrelPopulationStrongCheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Подтвердить выбор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onConfirmSelectionButtonTouched);
            // 
            // FormModalDialogSquirrelPopulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonSquirrelPopulationHigh);
            this.Controls.Add(this.radioButtonSqurrelPopulationMiddle);
            this.Controls.Add(this.radioButtonSquirrelPopulationLow);
            this.Controls.Add(this.radioButtonSquirrelPopulationAbsent);
            this.Controls.Add(this.label1);
            this.Name = "FormModalDialogSquirrelPopulation";
            this.Text = "FormModalDialogSquirrelPopulation";
            this.Load += new System.EventHandler(this.FormModalDialogSquirrelPopulation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonSquirrelPopulationAbsent;
        private System.Windows.Forms.RadioButton radioButtonSquirrelPopulationLow;
        private System.Windows.Forms.RadioButton radioButtonSqurrelPopulationMiddle;
        private System.Windows.Forms.RadioButton radioButtonSquirrelPopulationHigh;
        private System.Windows.Forms.Button button1;
    }
}