namespace FitYourSelf.Forms
{
    partial class UyelikSil
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSifirla = new FitYourSelf.FurkanButtons();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(88, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifrenizi Giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(45, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifrenizi Tekrar Giriniz:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(202, 221);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(202, 267);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 23);
            this.textBox2.TabIndex = 3;
            // 
            // btnSifirla
            // 
            this.btnSifirla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(86)))));
            this.btnSifirla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(86)))));
            this.btnSifirla.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSifirla.BorderRadius = 20;
            this.btnSifirla.BorderSize = 0;
            this.btnSifirla.FlatAppearance.BorderSize = 0;
            this.btnSifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifirla.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifirla.ForeColor = System.Drawing.Color.Black;
            this.btnSifirla.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSifirla.Location = new System.Drawing.Point(247, 301);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(107, 30);
            this.btnSifirla.TabIndex = 4;
            this.btnSifirla.Text = "Üyeliği Sil";
            this.btnSifirla.TextColor = System.Drawing.Color.Black;
            this.btnSifirla.UseVisualStyleBackColor = false;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // UyelikSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FitYourSelf.Properties.Resources.uyeliksilsayfası;
            this.ClientSize = new System.Drawing.Size(438, 418);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UyelikSil";
            this.Text = "UyelikSil";
            this.Load += new System.EventHandler(this.UyelikSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private FurkanButtons btnSifirla;
    }
}