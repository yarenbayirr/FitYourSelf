using FitYourSelf.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitYourSelf
{
    public  partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();           
        }

        
       
       

        private void OpenSignUpPage()
        {
            SignUpPage signUpPage = new SignUpPage();
            signUpPage.Show();
            this.Hide();
        }

           

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Bu uygulama 2022 yılında Kızartma Yazılım Danışmanlık A.Ş tarafından geliştirilmiştir. Uygulamanın amacı şekersiz/düşük şekerli beslenme tarzını benimseyen kişilerin kalori, besin makro, su takiplerini kolaylaştırmak ve onları sağlıklı yaşam tarzına teşvik etmektir. Bizi tercih ettiğiniz için teşekkür eder, şekersiz günler dileriz!");
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGirisYap_Click_1(object sender, EventArgs e)
        {
            
        }

        private void OpenLoginPage()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void furkanButtons2_Click(object sender, EventArgs e)
        {
            OpenLoginPage();
        }

        private void furkanButtons1_Click(object sender, EventArgs e)
        {
            OpenSignUpPage();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
