namespace FitYourSelf.Forms
{
    partial class OgunGiris
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
            this.dgwYiyecekler = new System.Windows.Forms.DataGridView();
            this.cmbOgun = new System.Windows.Forms.ComboBox();
            this.dgwOgunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPorsiyon = new System.Windows.Forms.ComboBox();
            this.lblTopKalori = new System.Windows.Forms.Label();
            this.lblTopProtein = new System.Windows.Forms.Label();
            this.lblTopYag = new System.Windows.Forms.Label();
            this.lblTopKarb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnListele1 = new FitYourSelf.FurkanButtons();
            this.btnSil1 = new FitYourSelf.FurkanButtons();
            this.btnGuncelle2 = new FitYourSelf.FurkanButtons();
            this.btnEkle1 = new FitYourSelf.FurkanButtons();
            ((System.ComponentModel.ISupportInitialize)(this.dgwYiyecekler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgunler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwYiyecekler
            // 
            this.dgwYiyecekler.BackgroundColor = System.Drawing.Color.White;
            this.dgwYiyecekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwYiyecekler.Location = new System.Drawing.Point(635, 90);
            this.dgwYiyecekler.Name = "dgwYiyecekler";
            this.dgwYiyecekler.RowHeadersWidth = 51;
            this.dgwYiyecekler.Size = new System.Drawing.Size(788, 304);
            this.dgwYiyecekler.TabIndex = 3;
            this.dgwYiyecekler.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwYiyecekler_CellMouseClick);
            // 
            // cmbOgun
            // 
            this.cmbOgun.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOgun.FormattingEnabled = true;
            this.cmbOgun.Location = new System.Drawing.Point(482, 269);
            this.cmbOgun.Name = "cmbOgun";
            this.cmbOgun.Size = new System.Drawing.Size(142, 29);
            this.cmbOgun.TabIndex = 4;
            // 
            // dgwOgunler
            // 
            this.dgwOgunler.BackgroundColor = System.Drawing.Color.White;
            this.dgwOgunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOgunler.Location = new System.Drawing.Point(635, 482);
            this.dgwOgunler.Name = "dgwOgunler";
            this.dgwOgunler.RowHeadersWidth = 51;
            this.dgwOgunler.Size = new System.Drawing.Size(790, 150);
            this.dgwOgunler.TabIndex = 10;
            this.dgwOgunler.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(372, 272);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Öğün :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(372, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kategori :";
            // 
            // cmbKategori
            // 
            this.cmbKategori.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(479, 108);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(142, 29);
            this.cmbKategori.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(372, 315);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Porsiyon :";
            // 
            // cmbPorsiyon
            // 
            this.cmbPorsiyon.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPorsiyon.FormattingEnabled = true;
            this.cmbPorsiyon.Location = new System.Drawing.Point(482, 309);
            this.cmbPorsiyon.Name = "cmbPorsiyon";
            this.cmbPorsiyon.Size = new System.Drawing.Size(75, 29);
            this.cmbPorsiyon.TabIndex = 4;
            // 
            // lblTopKalori
            // 
            this.lblTopKalori.BackColor = System.Drawing.Color.Transparent;
            this.lblTopKalori.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopKalori.Location = new System.Drawing.Point(394, 711);
            this.lblTopKalori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTopKalori.Name = "lblTopKalori";
            this.lblTopKalori.Size = new System.Drawing.Size(66, 19);
            this.lblTopKalori.TabIndex = 17;
            this.lblTopKalori.Text = "0";
            // 
            // lblTopProtein
            // 
            this.lblTopProtein.BackColor = System.Drawing.Color.Transparent;
            this.lblTopProtein.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopProtein.Location = new System.Drawing.Point(901, 711);
            this.lblTopProtein.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTopProtein.Name = "lblTopProtein";
            this.lblTopProtein.Size = new System.Drawing.Size(45, 19);
            this.lblTopProtein.TabIndex = 17;
            this.lblTopProtein.Text = "0";
            // 
            // lblTopYag
            // 
            this.lblTopYag.BackColor = System.Drawing.Color.Transparent;
            this.lblTopYag.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopYag.Location = new System.Drawing.Point(644, 711);
            this.lblTopYag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTopYag.Name = "lblTopYag";
            this.lblTopYag.Size = new System.Drawing.Size(45, 19);
            this.lblTopYag.TabIndex = 17;
            this.lblTopYag.Text = "0";
            // 
            // lblTopKarb
            // 
            this.lblTopKarb.BackColor = System.Drawing.Color.Transparent;
            this.lblTopKarb.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopKarb.Location = new System.Drawing.Point(1203, 711);
            this.lblTopKarb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTopKarb.Name = "lblTopKarb";
            this.lblTopKarb.Size = new System.Drawing.Size(77, 19);
            this.lblTopKarb.TabIndex = 17;
            this.lblTopKarb.Text = "0";
            this.lblTopKarb.Click += new System.EventHandler(this.lblTopKarb_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(244, 711);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Toplam Kalori:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(487, 711);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Toplam Yağ:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(725, 711);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Toplam Protein:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(982, 711);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Toplam Karbonhidrat:";
            // 
            // btnListele1
            // 
            this.btnListele1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(86)))));
            this.btnListele1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(86)))));
            this.btnListele1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnListele1.BorderRadius = 20;
            this.btnListele1.BorderSize = 0;
            this.btnListele1.FlatAppearance.BorderSize = 0;
            this.btnListele1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele1.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele1.ForeColor = System.Drawing.Color.Black;
            this.btnListele1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListele1.Location = new System.Drawing.Point(505, 156);
            this.btnListele1.Name = "btnListele1";
            this.btnListele1.Size = new System.Drawing.Size(116, 40);
            this.btnListele1.TabIndex = 93;
            this.btnListele1.Text = "Listele";
            this.btnListele1.TextColor = System.Drawing.Color.Black;
            this.btnListele1.UseVisualStyleBackColor = false;
            this.btnListele1.Click += new System.EventHandler(this.btnListele1_Click);
            // 
            // btnSil1
            // 
            this.btnSil1.BackColor = System.Drawing.Color.White;
            this.btnSil1.BackgroundColor = System.Drawing.Color.White;
            this.btnSil1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSil1.BorderRadius = 20;
            this.btnSil1.BorderSize = 0;
            this.btnSil1.FlatAppearance.BorderSize = 0;
            this.btnSil1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil1.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil1.ForeColor = System.Drawing.Color.Black;
            this.btnSil1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSil1.Location = new System.Drawing.Point(505, 530);
            this.btnSil1.Name = "btnSil1";
            this.btnSil1.Size = new System.Drawing.Size(116, 40);
            this.btnSil1.TabIndex = 92;
            this.btnSil1.Text = "Sil";
            this.btnSil1.TextColor = System.Drawing.Color.Black;
            this.btnSil1.UseVisualStyleBackColor = false;
            this.btnSil1.Click += new System.EventHandler(this.btnSil1_Click);
            // 
            // btnGuncelle2
            // 
            this.btnGuncelle2.BackColor = System.Drawing.Color.White;
            this.btnGuncelle2.BackgroundColor = System.Drawing.Color.White;
            this.btnGuncelle2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuncelle2.BorderRadius = 20;
            this.btnGuncelle2.BorderSize = 0;
            this.btnGuncelle2.FlatAppearance.BorderSize = 0;
            this.btnGuncelle2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle2.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle2.ForeColor = System.Drawing.Color.Black;
            this.btnGuncelle2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGuncelle2.Location = new System.Drawing.Point(376, 530);
            this.btnGuncelle2.Name = "btnGuncelle2";
            this.btnGuncelle2.Size = new System.Drawing.Size(116, 40);
            this.btnGuncelle2.TabIndex = 91;
            this.btnGuncelle2.Text = "Güncelle";
            this.btnGuncelle2.TextColor = System.Drawing.Color.Black;
            this.btnGuncelle2.UseVisualStyleBackColor = false;
            this.btnGuncelle2.Click += new System.EventHandler(this.btnGuncelle2_Click);
            // 
            // btnEkle1
            // 
            this.btnEkle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(86)))));
            this.btnEkle1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(86)))));
            this.btnEkle1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEkle1.BorderRadius = 15;
            this.btnEkle1.BorderSize = 0;
            this.btnEkle1.FlatAppearance.BorderSize = 0;
            this.btnEkle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle1.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle1.ForeColor = System.Drawing.Color.Black;
            this.btnEkle1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEkle1.Location = new System.Drawing.Point(508, 344);
            this.btnEkle1.Name = "btnEkle1";
            this.btnEkle1.Size = new System.Drawing.Size(116, 40);
            this.btnEkle1.TabIndex = 89;
            this.btnEkle1.Text = "Ekle";
            this.btnEkle1.TextColor = System.Drawing.Color.Black;
            this.btnEkle1.UseVisualStyleBackColor = false;
            this.btnEkle1.Click += new System.EventHandler(this.btnEkle1_Click);
            // 
            // OgunGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FitYourSelf.Properties.Resources.ogungirisdeneme2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1437, 793);
            this.Controls.Add(this.btnListele1);
            this.Controls.Add(this.btnSil1);
            this.Controls.Add(this.btnGuncelle2);
            this.Controls.Add(this.btnEkle1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTopKarb);
            this.Controls.Add(this.lblTopYag);
            this.Controls.Add(this.lblTopProtein);
            this.Controls.Add(this.lblTopKalori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwOgunler);
            this.Controls.Add(this.cmbPorsiyon);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.cmbOgun);
            this.Controls.Add(this.dgwYiyecekler);
            this.Name = "OgunGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgunGiris";
            this.Load += new System.EventHandler(this.OgunGiris_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgwYiyecekler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwYiyecekler;
        private System.Windows.Forms.ComboBox cmbOgun;
        private System.Windows.Forms.DataGridView dgwOgunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPorsiyon;
        private System.Windows.Forms.Label lblTopKalori;
        private System.Windows.Forms.Label lblTopProtein;
        private System.Windows.Forms.Label lblTopYag;
        private System.Windows.Forms.Label lblTopKarb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private FurkanButtons btnEkle1;
        private FurkanButtons btnGuncelle2;
        private FurkanButtons btnSil1;
        private FurkanButtons btnListele1;
    }
}