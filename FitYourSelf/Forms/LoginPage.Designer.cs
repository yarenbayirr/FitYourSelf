namespace FitYourSelf.Forms
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.txtGirisEmail = new System.Windows.Forms.TextBox();
            this.txtGirisSifre = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGirisYap = new FitYourSelf.FurkanButtons();
            this.btnGeriDon = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGeriDon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGirisEmail
            // 
            this.txtGirisEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGirisEmail.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGirisEmail.Location = new System.Drawing.Point(52, 12);
            this.txtGirisEmail.Name = "txtGirisEmail";
            this.txtGirisEmail.Size = new System.Drawing.Size(209, 24);
            this.txtGirisEmail.TabIndex = 8;
            this.txtGirisEmail.Text = "E-Mail";
            this.txtGirisEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtGirisEmail_MouseClick);
            // 
            // txtGirisSifre
            // 
            this.txtGirisSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGirisSifre.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGirisSifre.Location = new System.Drawing.Point(52, 11);
            this.txtGirisSifre.Name = "txtGirisSifre";
            this.txtGirisSifre.Size = new System.Drawing.Size(209, 24);
            this.txtGirisSifre.TabIndex = 10;
            this.txtGirisSifre.Text = "Şifre";
            this.txtGirisSifre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtGirisSifre_MouseClick);
            this.txtGirisSifre.TextChanged += new System.EventHandler(this.txtGirisSifre_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtGirisSifre);
            this.panel3.Location = new System.Drawing.Point(139, 381);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 45);
            this.panel3.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtGirisEmail);
            this.panel2.Location = new System.Drawing.Point(139, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 45);
            this.panel2.TabIndex = 20;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(86)))));
            this.btnGirisYap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(86)))));
            this.btnGirisYap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGirisYap.BorderRadius = 20;
            this.btnGirisYap.BorderSize = 0;
            this.btnGirisYap.FlatAppearance.BorderSize = 0;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.ForeColor = System.Drawing.Color.Black;
            this.btnGirisYap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGirisYap.Location = new System.Drawing.Point(192, 461);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(165, 40);
            this.btnGirisYap.TabIndex = 88;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.TextColor = System.Drawing.Color.Black;
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click_1);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.Transparent;
            this.btnGeriDon.Image = global::FitYourSelf.Properties.Resources.gersontusuPNG;
            this.btnGeriDon.Location = new System.Drawing.Point(12, 12);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(45, 45);
            this.btnGeriDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGeriDon.TabIndex = 90;
            this.btnGeriDon.TabStop = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click_1);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 681);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Sayfası";
            this.Load += new System.EventHandler(this.LoginPage_Load_1);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGeriDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtGirisSifre;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtGirisEmail;
        private FurkanButtons btnGirisYap;
        private System.Windows.Forms.PictureBox btnGeriDon;
    }
}