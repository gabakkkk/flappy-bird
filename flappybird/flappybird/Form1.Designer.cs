namespace flappybird
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
            this.Kus = new System.Windows.Forms.PictureBox();
            this.Zemin = new System.Windows.Forms.PictureBox();
            this.BoruAlt = new System.Windows.Forms.PictureBox();
            this.BoruUst = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Kus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).BeginInit();
            this.SuspendLayout();
            // 
            // Kus
            // 
            this.Kus.Image = ((System.Drawing.Image)(resources.GetObject("Kus.Image")));
            this.Kus.Location = new System.Drawing.Point(107, 44);
            this.Kus.Name = "Kus";
            this.Kus.Size = new System.Drawing.Size(45, 38);
            this.Kus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kus.TabIndex = 0;
            this.Kus.TabStop = false;
            // 
            // Zemin
            // 
            this.Zemin.Image = ((System.Drawing.Image)(resources.GetObject("Zemin.Image")));
            this.Zemin.Location = new System.Drawing.Point(1, 354);
            this.Zemin.Name = "Zemin";
            this.Zemin.Size = new System.Drawing.Size(797, 50);
            this.Zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zemin.TabIndex = 1;
            this.Zemin.TabStop = false;
            // 
            // BoruAlt
            // 
            this.BoruAlt.Image = ((System.Drawing.Image)(resources.GetObject("BoruAlt.Image")));
            this.BoruAlt.Location = new System.Drawing.Point(485, 243);
            this.BoruAlt.Name = "BoruAlt";
            this.BoruAlt.Size = new System.Drawing.Size(53, 115);
            this.BoruAlt.TabIndex = 2;
            this.BoruAlt.TabStop = false;
            // 
            // BoruUst
            // 
            this.BoruUst.Image = ((System.Drawing.Image)(resources.GetObject("BoruUst.Image")));
            this.BoruUst.Location = new System.Drawing.Point(514, -4);
            this.BoruUst.Name = "BoruUst";
            this.BoruUst.Size = new System.Drawing.Size(52, 104);
            this.BoruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruUst.TabIndex = 3;
            this.BoruUst.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreText.Location = new System.Drawing.Point(22, 411);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(93, 25);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score:0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.BoruUst);
            this.Controls.Add(this.BoruAlt);
            this.Controls.Add(this.Zemin);
            this.Controls.Add(this.Kus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Kus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Kus;
        private System.Windows.Forms.PictureBox Zemin;
        private System.Windows.Forms.PictureBox BoruAlt;
        private System.Windows.Forms.PictureBox BoruUst;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

