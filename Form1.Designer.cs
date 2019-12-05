namespace TheCarGamev1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.batmobile = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.overz = new System.Windows.Forms.Label();
            this.overImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.boomBox = new System.Windows.Forms.PictureBox();
            this.missle = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.missleBoom = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batmobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missleBoom)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 464);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(181, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 94);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(181, 181);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 89);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(181, 337);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 99);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(377, -2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 464);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // batmobile
            // 
            this.batmobile.Image = ((System.Drawing.Image)(resources.GetObject("batmobile.Image")));
            this.batmobile.Location = new System.Drawing.Point(34, 361);
            this.batmobile.Name = "batmobile";
            this.batmobile.Size = new System.Drawing.Size(42, 75);
            this.batmobile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.batmobile.TabIndex = 6;
            this.batmobile.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(15, 88);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(41, 72);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 7;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(134, 246);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(41, 72);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 8;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(307, 123);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(41, 72);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 9;
            this.enemy3.TabStop = false;
            // 
            // overz
            // 
            this.overz.AutoSize = true;
            this.overz.BackColor = System.Drawing.Color.DarkRed;
            this.overz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.overz.ForeColor = System.Drawing.Color.Black;
            this.overz.Location = new System.Drawing.Point(95, 129);
            this.overz.Name = "overz";
            this.overz.Size = new System.Drawing.Size(186, 31);
            this.overz.TabIndex = 10;
            this.overz.Text = "GAME OVER";
            // 
            // overImage
            // 
            this.overImage.Image = ((System.Drawing.Image)(resources.GetObject("overImage.Image")));
            this.overImage.Location = new System.Drawing.Point(134, 27);
            this.overImage.Name = "overImage";
            this.overImage.Size = new System.Drawing.Size(100, 99);
            this.overImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.overImage.TabIndex = 11;
            this.overImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(127, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 66);
            this.button1.TabIndex = 12;
            this.button1.Text = "Play Again";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boomBox
            // 
            this.boomBox.Image = ((System.Drawing.Image)(resources.GetObject("boomBox.Image")));
            this.boomBox.Location = new System.Drawing.Point(139, 361);
            this.boomBox.Name = "boomBox";
            this.boomBox.Size = new System.Drawing.Size(52, 52);
            this.boomBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boomBox.TabIndex = 13;
            this.boomBox.TabStop = false;
            // 
            // missle
            // 
            this.missle.BackColor = System.Drawing.Color.Gray;
            this.missle.Image = ((System.Drawing.Image)(resources.GetObject("missle.Image")));
            this.missle.Location = new System.Drawing.Point(-2, 416);
            this.missle.Name = "missle";
            this.missle.Size = new System.Drawing.Size(24, 46);
            this.missle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.missle.TabIndex = 14;
            this.missle.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // missleBoom
            // 
            this.missleBoom.Image = ((System.Drawing.Image)(resources.GetObject("missleBoom.Image")));
            this.missleBoom.Location = new System.Drawing.Point(296, 327);
            this.missleBoom.Name = "missleBoom";
            this.missleBoom.Size = new System.Drawing.Size(52, 52);
            this.missleBoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.missleBoom.TabIndex = 15;
            this.missleBoom.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.DarkRed;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.scoreText.Location = new System.Drawing.Point(121, 181);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(0, 25);
            this.scoreText.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.missleBoom);
            this.Controls.Add(this.missle);
            this.Controls.Add(this.boomBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.overImage);
            this.Controls.Add(this.overz);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.batmobile);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Will Batman Escape?";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batmobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missleBoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox batmobile;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.Label overz;
        private System.Windows.Forms.PictureBox overImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox boomBox;
        private System.Windows.Forms.PictureBox missle;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox missleBoom;
        private System.Windows.Forms.Label scoreText;
    }
}

