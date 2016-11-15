namespace island
{
    partial class FormModalDialogGrass
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
            this.radioButtonGrassAbsent = new System.Windows.Forms.RadioButton();
            this.radioButtonVeryWeakGrassLevel = new System.Windows.Forms.RadioButton();
            this.radioButtonWeakGrassLevel = new System.Windows.Forms.RadioButton();
            this.radioButtonMiddleGrassLevel = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConfirmGrassLevelSelection = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.radioButtonVeryHighGrassLevel = new System.Windows.Forms.RadioButton();
            this.radioButtonHighGrassLevel = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Установить траву, гору, реку, белок";
            // 
            // radioButtonGrassAbsent
            // 
            this.radioButtonGrassAbsent.AutoSize = true;
            this.radioButtonGrassAbsent.Location = new System.Drawing.Point(12, 53);
            this.radioButtonGrassAbsent.Name = "radioButtonGrassAbsent";
            this.radioButtonGrassAbsent.Size = new System.Drawing.Size(78, 17);
            this.radioButtonGrassAbsent.TabIndex = 1;
            this.radioButtonGrassAbsent.TabStop = true;
            this.radioButtonGrassAbsent.Text = "Нет травы";
            this.radioButtonGrassAbsent.UseVisualStyleBackColor = true;
            this.radioButtonGrassAbsent.CheckedChanged += new System.EventHandler(this.onRadioButtonGrassLevelAbsentCheckedChanged);
            // 
            // radioButtonVeryWeakGrassLevel
            // 
            this.radioButtonVeryWeakGrassLevel.AutoSize = true;
            this.radioButtonVeryWeakGrassLevel.Location = new System.Drawing.Point(12, 76);
            this.radioButtonVeryWeakGrassLevel.Name = "radioButtonVeryWeakGrassLevel";
            this.radioButtonVeryWeakGrassLevel.Size = new System.Drawing.Size(119, 17);
            this.radioButtonVeryWeakGrassLevel.TabIndex = 2;
            this.radioButtonVeryWeakGrassLevel.TabStop = true;
            this.radioButtonVeryWeakGrassLevel.Text = "Очень мало травы";
            this.radioButtonVeryWeakGrassLevel.UseVisualStyleBackColor = true;
            this.radioButtonVeryWeakGrassLevel.CheckedChanged += new System.EventHandler(this.onRadioButtonGrassLevelVeryWeakCheckedChanged);
            // 
            // radioButtonWeakGrassLevel
            // 
            this.radioButtonWeakGrassLevel.AutoSize = true;
            this.radioButtonWeakGrassLevel.Location = new System.Drawing.Point(12, 99);
            this.radioButtonWeakGrassLevel.Name = "radioButtonWeakGrassLevel";
            this.radioButtonWeakGrassLevel.Size = new System.Drawing.Size(86, 17);
            this.radioButtonWeakGrassLevel.TabIndex = 3;
            this.radioButtonWeakGrassLevel.TabStop = true;
            this.radioButtonWeakGrassLevel.Text = "Мало травы";
            this.radioButtonWeakGrassLevel.UseVisualStyleBackColor = true;
            this.radioButtonWeakGrassLevel.CheckedChanged += new System.EventHandler(this.onRadioButtonGrassLevelWeakCheckedChanged);
            // 
            // radioButtonMiddleGrassLevel
            // 
            this.radioButtonMiddleGrassLevel.AutoSize = true;
            this.radioButtonMiddleGrassLevel.Location = new System.Drawing.Point(12, 125);
            this.radioButtonMiddleGrassLevel.Name = "radioButtonMiddleGrassLevel";
            this.radioButtonMiddleGrassLevel.Size = new System.Drawing.Size(126, 17);
            this.radioButtonMiddleGrassLevel.TabIndex = 4;
            this.radioButtonMiddleGrassLevel.TabStop = true;
            this.radioButtonMiddleGrassLevel.Text = "Среднее к-во травы";
            this.radioButtonMiddleGrassLevel.UseVisualStyleBackColor = true;
            this.radioButtonMiddleGrassLevel.CheckedChanged += new System.EventHandler(this.onRadioButtonGrassLevelMiddleCheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Установить траву";
            // 
            // buttonConfirmGrassLevelSelection
            // 
            this.buttonConfirmGrassLevelSelection.Location = new System.Drawing.Point(12, 226);
            this.buttonConfirmGrassLevelSelection.Name = "buttonConfirmGrassLevelSelection";
            this.buttonConfirmGrassLevelSelection.Size = new System.Drawing.Size(179, 23);
            this.buttonConfirmGrassLevelSelection.TabIndex = 6;
            this.buttonConfirmGrassLevelSelection.Text = "Подтвердить установку травы";
            this.buttonConfirmGrassLevelSelection.UseVisualStyleBackColor = true;
            this.buttonConfirmGrassLevelSelection.Click += new System.EventHandler(this.onConfirmSelectionGrassButtonTouched);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "А может быть...";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Установить гору";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(163, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Установить реку";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(127, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Задать количество белок";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // radioButtonVeryHighGrassLevel
            // 
            this.radioButtonVeryHighGrassLevel.AutoSize = true;
            this.radioButtonVeryHighGrassLevel.Location = new System.Drawing.Point(15, 174);
            this.radioButtonVeryHighGrassLevel.Name = "radioButtonVeryHighGrassLevel";
            this.radioButtonVeryHighGrassLevel.Size = new System.Drawing.Size(124, 17);
            this.radioButtonVeryHighGrassLevel.TabIndex = 11;
            this.radioButtonVeryHighGrassLevel.TabStop = true;
            this.radioButtonVeryHighGrassLevel.Text = "Очень много травы";
            this.radioButtonVeryHighGrassLevel.UseVisualStyleBackColor = true;
            this.radioButtonVeryHighGrassLevel.CheckedChanged += new System.EventHandler(this.onRadioButtonGrassLevelVeryStrongCheckedChanged);
            // 
            // radioButtonHighGrassLevel
            // 
            this.radioButtonHighGrassLevel.AutoSize = true;
            this.radioButtonHighGrassLevel.Location = new System.Drawing.Point(12, 151);
            this.radioButtonHighGrassLevel.Name = "radioButtonHighGrassLevel";
            this.radioButtonHighGrassLevel.Size = new System.Drawing.Size(91, 17);
            this.radioButtonHighGrassLevel.TabIndex = 12;
            this.radioButtonHighGrassLevel.TabStop = true;
            this.radioButtonHighGrassLevel.Text = "Много травы";
            this.radioButtonHighGrassLevel.UseVisualStyleBackColor = true;
            this.radioButtonHighGrassLevel.CheckedChanged += new System.EventHandler(this.onRadioButtonGrassLevelStrongCheckedChanged);
            // 
            // FormModalDialogGrass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.radioButtonHighGrassLevel);
            this.Controls.Add(this.radioButtonVeryHighGrassLevel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonConfirmGrassLevelSelection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonMiddleGrassLevel);
            this.Controls.Add(this.radioButtonWeakGrassLevel);
            this.Controls.Add(this.radioButtonVeryWeakGrassLevel);
            this.Controls.Add(this.radioButtonGrassAbsent);
            this.Controls.Add(this.label1);
            this.Name = "FormModalDialogGrass";
            this.Text = "FormModalDialogGrass";
            this.Load += new System.EventHandler(this.FormModalDialogGrass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonGrassAbsent;
        private System.Windows.Forms.RadioButton radioButtonVeryWeakGrassLevel;
        private System.Windows.Forms.RadioButton radioButtonWeakGrassLevel;
        private System.Windows.Forms.RadioButton radioButtonMiddleGrassLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConfirmGrassLevelSelection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton radioButtonVeryHighGrassLevel;
        private System.Windows.Forms.RadioButton radioButtonHighGrassLevel;
    }
}