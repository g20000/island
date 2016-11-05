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
            this.pictureBoxSkySun = new System.Windows.Forms.PictureBox();
            this.pictureBoxGrass = new System.Windows.Forms.PictureBox();
            this.pictureBoxRain = new System.Windows.Forms.PictureBox();
            this.pictureBoxRain2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxRain3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkySun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRain2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRain3)).BeginInit();
            this.SuspendLayout();
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
            // pictureBoxGrass
            // 
            this.pictureBoxGrass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBoxGrass.Location = new System.Drawing.Point(12, 76);
            this.pictureBoxGrass.Name = "pictureBoxGrass";
            this.pictureBoxGrass.Size = new System.Drawing.Size(233, 57);
            this.pictureBoxGrass.TabIndex = 2;
            this.pictureBoxGrass.TabStop = false;
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 460);
            this.Controls.Add(this.pictureBoxRain3);
            this.Controls.Add(this.pictureBoxRain2);
            this.Controls.Add(this.pictureBoxRain);
            this.Controls.Add(this.pictureBoxGrass);
            this.Controls.Add(this.pictureBoxSkySun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkySun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRain2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRain3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxSkySun;
        private System.Windows.Forms.PictureBox pictureBoxGrass;
        private System.Windows.Forms.PictureBox pictureBoxRain;
        private System.Windows.Forms.PictureBox pictureBoxRain2;
        private System.Windows.Forms.PictureBox pictureBoxRain3;
        private System.Windows.Forms.Timer timer1;
    }
}

