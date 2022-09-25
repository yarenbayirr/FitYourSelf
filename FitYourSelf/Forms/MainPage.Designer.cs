using System.Drawing;

namespace FitYourSelf
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.lnklblHakkinda = new System.Windows.Forms.LinkLabel();
            this.furkanButtons1 = new FitYourSelf.FurkanButtons();
            this.furkanButtons2 = new FitYourSelf.FurkanButtons();
            this.SuspendLayout();
            // 
            // lnklblHakkinda
            // 
            resources.ApplyResources(this.lnklblHakkinda, "lnklblHakkinda");
            this.lnklblHakkinda.BackColor = System.Drawing.Color.Transparent;
            this.lnklblHakkinda.Name = "lnklblHakkinda";
            this.lnklblHakkinda.TabStop = true;
            this.lnklblHakkinda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // furkanButtons1
            // 
            this.furkanButtons1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(143)))));
            this.furkanButtons1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(143)))));
            this.furkanButtons1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.furkanButtons1.BorderRadius = 20;
            this.furkanButtons1.BorderSize = 0;
            this.furkanButtons1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.furkanButtons1, "furkanButtons1");
            this.furkanButtons1.ForeColor = System.Drawing.Color.Black;
            this.furkanButtons1.Name = "furkanButtons1";
            this.furkanButtons1.TextColor = System.Drawing.Color.Black;
            this.furkanButtons1.UseVisualStyleBackColor = false;
            this.furkanButtons1.Click += new System.EventHandler(this.furkanButtons1_Click);
            // 
            // furkanButtons2
            // 
            this.furkanButtons2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(86)))));
            this.furkanButtons2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(86)))));
            this.furkanButtons2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.furkanButtons2.BorderRadius = 20;
            this.furkanButtons2.BorderSize = 0;
            this.furkanButtons2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.furkanButtons2, "furkanButtons2");
            this.furkanButtons2.ForeColor = System.Drawing.Color.Black;
            this.furkanButtons2.Name = "furkanButtons2";
            this.furkanButtons2.TextColor = System.Drawing.Color.Black;
            this.furkanButtons2.UseVisualStyleBackColor = false;
            this.furkanButtons2.Click += new System.EventHandler(this.furkanButtons2_Click);
            // 
            // MainPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FitYourSelf.Properties.Resources.GirişSayfasıRevizeSON;
            this.Controls.Add(this.furkanButtons1);
            this.Controls.Add(this.furkanButtons2);
            this.Controls.Add(this.lnklblHakkinda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lnklblHakkinda;
        private FurkanButtons furkanButtons2;
        private FurkanButtons furkanButtons1;
    }
}

