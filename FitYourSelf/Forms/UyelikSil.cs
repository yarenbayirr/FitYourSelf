using FitYourSelf.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xaml;

namespace FitYourSelf.Forms
{
    public partial class UyelikSil : Form
    {
        public UyelikSil()
        {
            InitializeComponent();
        }

        FitYourSelfContext db;
        private void UyelikSil_Load(object sender, EventArgs e)
        {
            db = new FitYourSelfContext();

        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            
            var sorgu = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault();
            if(sorgu.Password==textBox1.Text&&sorgu.Password==textBox2.Text)
            {
                DialogResult sil = new DialogResult();
                sil = MessageBox.Show("Üyeliğiniz Kalıcı Olarak Silinecektir.Devam Etmek İstiyor Musunuz?","Uyarı",MessageBoxButtons.YesNo);
                if (sil == DialogResult.Yes)
                {
                    db.UserInfo.Remove(sorgu);
                    db.SaveChanges();
                    MessageBox.Show("Üyeliğiniz başarıyla silinmiştir.");
                    Application.Exit();
                }
                
            }
            else
                MessageBox.Show("Şifrenizi Hatalı Girdiniz.");

        }
    }
}
