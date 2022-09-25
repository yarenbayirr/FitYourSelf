using FitYorSelf.Entities.Concrete;
using FitYourSelf.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FitYourSelf.Forms
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        FitYourSelfContext db;
        AnaSayfa anaSayfa = new AnaSayfa();

        public static int id;
        public static string userName;

       
        private void LoginPage_Load_1(object sender, EventArgs e)
        {            
            db = new FitYourSelfContext();
            txtGirisSifre.Text = "Şifre";
            txtGirisSifre.UseSystemPasswordChar = false;
            txtGirisEmail.Text = "frknydn22@icloud.com";
            txtGirisSifre.Text = "Kizartma_22";

        }

        private void btnGirisYap_Click_1(object sender, EventArgs e)
        {
            var sorgulama = db.UserInfo.Where(x => x.Email == txtGirisEmail.Text).FirstOrDefault();
            userName = sorgulama.UserName;
            id = sorgulama.UserInfoID;
            GirisYapKontrol();
        }

      

        private void OpenMainPage()
        {
            MainPage main = new MainPage();
            main.Show();
            this.Hide();
        }        

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtGirisSifre_TextChanged(object sender, EventArgs e)
        {

            txtGirisSifre.UseSystemPasswordChar = true;
        }

        private void txtGirisSifre_MouseClick(object sender, MouseEventArgs e)
        {
            txtGirisSifre.Clear();
        }

        private void txtGirisEmail_MouseClick(object sender, MouseEventArgs e)
        {
            txtGirisEmail.Clear();
        }

        private void GirisYapKontrol()
        {
            var emailKontrol = db.UserInfo.Where(x => x.Email == txtGirisEmail.Text).FirstOrDefault();
            var sifreKontrol = db.UserInfo.Where(x => x.Password == txtGirisSifre.Text).FirstOrDefault();

            if (emailKontrol != null)
            {
                if (emailKontrol.Password == txtGirisSifre.Text)
                {
                    MessageBox.Show("Giriş başarılı");
                    anaSayfa = new AnaSayfa();
                    anaSayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şifre ya da Email hatalı!\n"
                        +"Lütfen tekrar deneyiniz.");
                }



            }
            else
                MessageBox.Show("Kayıtlı kullanıcı bulunamadı");
        }

        

        private void btnGeriDon_Click_1(object sender, EventArgs e)
        {
            OpenMainPage();
        }
    }


}

