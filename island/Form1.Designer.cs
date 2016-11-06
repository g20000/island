namespace island
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxLake = new System.Windows.Forms.PictureBox();
            this.pictureBoxMountain = new System.Windows.Forms.PictureBox();
            this.pictureBoxRain3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxRain2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxRain = new System.Windows.Forms.PictureBox();
            this.pictureBoxGrass = new System.Windows.Forms.PictureBox();
            this.pictureBoxSkySun = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMountain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRain3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRain2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkySun)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxLake
            // 
            this.pictureBoxLake.Image = global::island.Properties.Resources.icon_river;
            this.pictureBoxLake.Location = new System.Drawing.Point(174, 89);
            this.pictureBoxLake.Name = "pictureBoxLake";
            this.pictureBoxLake.Size = new System.Drawing.Size(42, 35);
            this.pictureBoxLake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLake.TabIndex = 7;
            this.pictureBoxLake.TabStop = false;
            // 
            // pictureBoxMountain
            // 
            this.pictureBoxMountain.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMountain.BackgroundImage = global::island.Properties.Resources.icon_mountain;
            this.pictureBoxMountain.Image = global::island.Properties.Resources.icon_mountain;
            this.pictureBoxMountain.InitialImage = global::island.Properties.Resources.icon_mountain;
            this.pictureBoxMountain.Location = new System.Drawing.Point(30, 83);
            this.pictureBoxMountain.Name = "pictureBoxMountain";
            this.pictureBoxMountain.Size = new System.Drawing.Size(42, 41);
            this.pictureBoxMountain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMountain.TabIndex = 6;
            this.pictureBoxMountain.TabStop = false;
            // 
            // pictureBoxRain3
            // 
            this.pictureBoxRain3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRain3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRain3.BackgroundImage")));
            this.pictureBoxRain3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRain3.Image = global::island.Properties.Resources.kaplja;
            this.pictureBoxRain3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRain3.InitialImage")));
            this.pictureBoxRain3.Location = new System.Drawing.Point(174, 31);
            this.pictureBoxRain3.Name = "pictureBoxRain3";
            this.pictureBoxRain3.Size = new System.Drawing.Size(42, 39);
            this.pictureBoxRain3.TabIndex = 5;
            this.pictureBoxRain3.TabStop = false;
            // 
            // pictureBoxRain2
            // 
            this.pictureBoxRain2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRain2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRain2.BackgroundImage")));
            this.pictureBoxRain2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRain2.Image = global::island.Properties.Resources.kaplja;
            this.pictureBoxRain2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRain2.InitialImage")));
            this.pictureBoxRain2.Location = new System.Drawing.Point(97, 31);
            this.pictureBoxRain2.Name = "pictureBoxRain2";
            this.pictureBoxRain2.Size = new System.Drawing.Size(42, 39);
            this.pictureBoxRain2.TabIndex = 4;
            this.pictureBoxRain2.TabStop = false;
            // 
            // pictureBoxRain
            // 
            this.pictureBoxRain.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRain.BackgroundImage")));
            this.pictureBoxRain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRain.Image = global::island.Properties.Resources.kaplja;
            this.pictureBoxRain.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRain.InitialImage")));
            this.pictureBoxRain.Location = new System.Drawing.Point(30, 31);
            this.pictureBoxRain.Name = "pictureBoxRain";
            this.pictureBoxRain.Size = new System.Drawing.Size(42, 39);
            this.pictureBoxRain.TabIndex = 3;
            this.pictureBoxRain.TabStop = false;
            // 
            // pictureBoxGrass
            // 
            this.pictureBoxGrass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBoxGrass.Location = new System.Drawing.Point(12, 76);
            this.pictureBoxGrass.Name = "pictureBoxGrass";
            this.pictureBoxGrass.Size = new System.Drawing.Size(233, 57);
            this.pictureBoxGrass.TabIndex = 2;
            this.pictureBoxGrass.TabStop = false;
            // 
            // pictureBoxSkySun
            // 
            this.pictureBoxSkySun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBoxSkySun.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxSkySun.Name = "pictureBoxSkySun";
            this.pictureBoxSkySun.Size = new System.Drawing.Size(233, 70);
            this.pictureBoxSkySun.TabIndex = 1;
            this.pictureBoxSkySun.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(870, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(869, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Стоп";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.onStopClickedButtonTouched);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(869, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Вперед";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.onUpdateCellsOnceButtonTouched);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 460);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxLake);
            this.Controls.Add(this.pictureBoxMountain);
            this.Controls.Add(this.pictureBoxRain3);
            this.Controls.Add(this.pictureBoxRain2);
            this.Controls.Add(this.pictureBoxRain);
            this.Controls.Add(this.pictureBoxGrass);
            this.Controls.Add(this.pictureBoxSkySun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMountain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRain3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRain2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkySun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxSkySun;
        private System.Windows.Forms.PictureBox pictureBoxGrass;
        private System.Windows.Forms.PictureBox pictureBoxRain;
        private System.Windows.Forms.PictureBox pictureBoxRain2;
        private System.Windows.Forms.PictureBox pictureBoxRain3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxMountain;
        private System.Windows.Forms.PictureBox pictureBoxLake;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

