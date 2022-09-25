using FitYorSelf.Entities.Concrete;
using FitYorSelf.Entities.Enums;
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

namespace FitYourSelf.Forms
{
    
    public partial class KendineMeydanOku : Form
    {
        public static int aliskanlikSuresi = 21;
        public KendineMeydanOku()
        {
            InitializeComponent();
        }

        FitYourSelfContext db;

        private void KendineMeydanOku_Load_1(object sender, EventArgs e)
        {            
            db = new FitYourSelfContext();
            rdbSekerYok.Checked = true;
        }
       

      
        private void btnBasla1_Click(object sender, EventArgs e)
        {
            ChallengeYourSelf CYS = new ChallengeYourSelf()
            {                
                UserInfoID = LoginPage.id,
                EklenmeTarihi = DateTime.Now
                
            };
            if (dtpTarih.Value > DateTime.Today)
            {
                MessageBox.Show("İleri tarihi seçemezsiniz.");
            }
            else
                CYS.DateTime = dtpTarih.Value;


            if (rdbEgzersiz.Checked == true)
            {
                CYS.ChallengeYourSelfEnum = ChallengeYourSelfEnum.Egzersiz;
                AnaSayfa.anaSayfa.lblHedef.Text = "EGZERSİZE BAŞLADIN";               

            }
            if (rdbGlutenYok.Checked == true)
            {
                CYS.ChallengeYourSelfEnum = ChallengeYourSelfEnum.GlutenYok;
                AnaSayfa.anaSayfa.lblHedef.Text = "GLUTENSİZ HAYATA BAŞLADIN";

            }
            if (rdbKahveyiAzalt.Checked == true)
            {
                CYS.ChallengeYourSelfEnum = ChallengeYourSelfEnum.KahveyiAzalt;
                AnaSayfa.anaSayfa.lblHedef.Text = "KAFEİNSİZ BİR HAYATA BAŞLADIN";

            }
            if (rdbSekerYok.Checked == true)
            {
                CYS.ChallengeYourSelfEnum = ChallengeYourSelfEnum.ŞekerYok;
                AnaSayfa.anaSayfa.lblHedef.Text = "ŞEKERSİZ GÜNLERE MERHABA";

            }
            if (rdbSu.Checked == true)
            {
                CYS.ChallengeYourSelfEnum = ChallengeYourSelfEnum.Suİç;
                AnaSayfa.anaSayfa.lblHedef.Text = "BÖBREKLERİN BAYRAM EDECEK";

            }

            CYS.GunFarki = DateTime.Now.DayOfYear - CYS.DateTime.DayOfYear;           
            db.ChallengeYourSelf.Add(CYS);
            db.SaveChanges();
            var sorgu = db.ChallengeYourSelf.Where(x => x.UserInfoID == LoginPage.id).OrderByDescending(x => x.EklenmeTarihi).FirstOrDefault();
            
            AnaSayfa.anaSayfa.hrpCYS.Percentage = (int)((sorgu.GunFarki * 100) / aliskanlikSuresi);

            AnaSayfa.anaSayfa.lblCYSGunSayisi.Text = ($"{CYS.GunFarki}" + ".Gün");
        }
    }
}
