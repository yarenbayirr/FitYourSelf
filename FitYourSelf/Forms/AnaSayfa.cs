using FitYorSelf.Entities.Concrete;
using FitYorSelf.Entities.Enums;
using FitYourSelf.DataAccess.Context;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitYourSelf.Forms
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
            anaSayfa = this;
        }

        FitYourSelfContext db;

        public static AnaSayfa anaSayfa;
        private void Takip_Load(object sender, EventArgs e)
        {


            btnSifirla.BackColor = Color.FromArgb(248, 175, 86);

            db = new FitYourSelfContext();
            lblIsım.Text = LoginPage.userName;
            var sorgu = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault();
            lblBoy.Text = sorgu.Height.ToString();
            lblKilo.Text = sorgu.Weight.ToString();
            lblVKI.Text = sorgu.BodyMassIndex.ToString();
            lblDurum.Text = sorgu.BMIStatus.GetDisplayName();
            lblGunlukKalori.Text = sorgu.RequiredCalorie.ToString();

            cysHallet();           
            cysprogressBar();
            suProgressBar();
            kaloriProgressBar();


            DateTime currentTimeStamp = new DateTime();

            using (var db = new FitYourSelfContext())
            {
                foreach (var datenow in db.Water)
                    currentTimeStamp = datenow.DateTime;
                foreach (var datenow in db.UserMeals)
                {
                    currentTimeStamp = datenow.MealDate;
                }
            }
            DateTime currentNow = DateTime.Now;
            int changeDay = currentNow.Day;
            if (currentTimeStamp.Day != changeDay)
            {
                FitYourSelfContext.ResetItem();

            }

            lblTopKalori.Text = sorgu.DailyCalorie.ToString();
            lblKarbonh.Text = sorgu.DailyCarbonhidrate.ToString();
            lblTopProtein.Text = sorgu.DailyProtein.ToString();
            lblTopYag.Text = sorgu.DailyFat.ToString();


            if (sorgu.WaterAmount == 0)
            {
                lblSuLitre.Text = "BUGÜN HİÇ SU İÇMEDİN";
                pictureBox2.Enabled = false;
            }
            else
            {
                lblSuLitre.Text = $"İÇİLEN SU MİKTARI: {sorgu.WaterAmount} LİTRE ";
            }
            

            lblKalanKaloriMiktari.Text = (sorgu.RequiredCalorie - sorgu.DailyCalorie).ToString();
            if (sorgu.RequiredCalorie - sorgu.DailyCalorie < 0)
                lblKalanKaloriMiktari.Text = 0.ToString();
        }

       

        private void öğünGirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgunGiris ogun = new OgunGiris();
            ogun.ShowDialog();
        }
       

        private void haftalıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HaftalikTakip HaftalikTakip = new HaftalikTakip();
            HaftalikTakip.ShowDialog();
        }

        private void aylikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AylikTakip aylikTakip = new AylikTakip();
            aylikTakip.ShowDialog();
        }

        private void tarifGirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TarifBul tarifBul = new TarifBul();
            tarifBul.ShowDialog();
        }

        private void tarifEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TarifEkle tarifEkle = new TarifEkle();
            tarifEkle.ShowDialog();
        }

        private void meydanOkumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KendineMeydanOku kmo = new KendineMeydanOku();
            kmo.ShowDialog();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yardim yardim = new Yardim();
            yardim.ShowDialog();
        }

        private void üyelikBilgileriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyelikGuncellemeEkran uge = new UyelikGuncellemeEkran();
            uge.ShowDialog();
        }

        private void üyelikSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyelikSil uyelikSil = new UyelikSil();
            uyelikSil.ShowDialog();
        }

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! METHODS !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        private void RenkleriAyarla()
        {
            groupBox1.BackColor = Color.FromArgb(243, 222, 195);

        }




        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! METHODS !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        private void AnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void lblKalanKaloriMiktari_Click(object sender, EventArgs e)
        {

        }

 



        int glassOfWater = 0;

        DateTime startDateTime = DateTime.Today; //Today at 00:00:00
        DateTime endDateTime = DateTime.Today.AddDays(1).AddTicks(-1); //Today at 23:59:59


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*İlk Kayıt Olduğunuzda Boy, Kilo ve varsa Günlük Kalori İhtiyacı bilgileriniz 0(sıfır) gösterilecektir.\n" +
                "*Boy, kilo ve günlük kalori ihtiyacınızı güncellemek için Üyelik Bilgileri sekmesinden " +
                "Üyelik Bilgileri Güncelle sayfasından ulaşabilirsiniz. Böylelikle Vücut Kitle İndeksiniz otomatik olarak hesaplanacaktır.", "İlk Kayıt Olunduğunda Yapılacaklar");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox2.Enabled = true;
            glassOfWater++;
            Water water = new Water()
            {
                GlassOfWater = 1,
                WaterAmount = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault().WaterAmount + 0.25,
                DateTime = DateTime.Today,
                UserInfoID = LoginPage.id

            };

            db.Water.Add(water);
            db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault().WaterAmount =
                (double)water.WaterAmount;



            //var deneme = db.Water.Where(x => x.UserInfoID == LoginPage.id && x.DateTime > startDateTime && x.DateTime < endDateTime).OrderByDescending(x => x.WaterAmount);
            //int sayac = 0;

            //foreach (var item in deneme)
            //{
            //    sayac++;
            //    db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault().WaterAmount = (double)item.WaterAmount;
            //    if (sayac == 1)
            //    {
            //        break;
            //    }            //}


            //var sorgu = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault();
            //sorgu.WaterAmount = (double)water.WaterAmount;


            db.SaveChanges();


            hrpSu.Percentage += 13;

            lblSuLitre.Text = $"İÇİLEN SU MİKTARI:   {db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault().WaterAmount}  LİTRE";
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var sorgu = db.Water.Where(x => x.UserInfoID == LoginPage.id).OrderByDescending(x => x.WaterAmount);
            var sorgu2 = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault().WaterAmount;


            int sayac = 0;
            foreach (var item in sorgu)
            {
                sayac++;
                db.Water.Remove(item);
                if (sayac == 1)

                    break;

            }
            double yenisayi = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault().WaterAmount - 0.25;
            if (yenisayi <= 0)
            {
                yenisayi = 0;
                pictureBox2.Enabled = false;
            }

            db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault().WaterAmount = yenisayi;



            db.SaveChanges();

            //var sorgu2 = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault().WaterAmount;
            //int sayac2 = 0;
            //foreach (var item in sorgu)
            //{
            //    sayac2++;
            //    sorgu2 =Convert.ToDouble(sorgu - 0.25);
            //    if (sayac2 == 1)
            //        break;

            //}
            //db.SaveChanges();
            if (sorgu2 <= 2)
            {
                hrpSu.Percentage -= 13;
            }
            else
                hrpSu.Percentage = 100;




            lblSuLitre.Text = $"İÇİLEN SU MİKTARI:  {db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault().WaterAmount}  LİTRE";
        }
        private void suProgressBar()
        {
            var sorgu = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault();

            if (sorgu.WaterAmount >= 2)
                hrpSu.Percentage = 100;
            else if (sorgu.WaterAmount == 1.75)
                hrpSu.Percentage = 87;
            else if (sorgu.WaterAmount == 1.5)
                hrpSu.Percentage = 74;
            else if (sorgu.WaterAmount == 1.25)
                hrpSu.Percentage = 61;
            else if (sorgu.WaterAmount == 1)
                hrpSu.Percentage = 50;
            else if (sorgu.WaterAmount == 0.75)
                hrpSu.Percentage = 37;
            else if (sorgu.WaterAmount == 0.5)
                hrpSu.Percentage = 24;
            else if (sorgu.WaterAmount == 0.25)
                hrpSu.Percentage = 11;
            else
                hrpSu.Percentage = 0;
        }



        private void furkanButtons1_Click(object sender, EventArgs e)
        {
            ChallengeYourSelf cys = new ChallengeYourSelf()
            {
                UserInfoID = LoginPage.id,
                DateTime = DateTime.Today,
                EklenmeTarihi = DateTime.Now,
                GunFarki = 0,
                ChallengeYourSelfEnum = 0

            };
            db.ChallengeYourSelf.Add(cys);
            db.SaveChanges();
            hrpCYS.Percentage = 0;
            lblCYSGunSayisi.Text = "0. GÜN";
            lblHedef.Text = "Henüz Hedef Belirlemediniz";
        }
        private void cysHallet()
        {
            var cysorgu = db.ChallengeYourSelf.Where(x => x.UserInfoID == LoginPage.id).OrderByDescending(x => x.EklenmeTarihi).FirstOrDefault();
           
           

            if (cysorgu.ChallengeYourSelfEnum == 0)
            {

                AnaSayfa.anaSayfa.lblHedef.Text = "HENÜZ SEÇİM YAPMADIN";

            }
            if (cysorgu.ChallengeYourSelfEnum == ChallengeYourSelfEnum.Egzersiz)
            {
               
                AnaSayfa.anaSayfa.lblHedef.Text = "EGZERSİZE BAŞLADIN";

            }
            if (cysorgu.ChallengeYourSelfEnum == ChallengeYourSelfEnum.GlutenYok)
            {
                
                AnaSayfa.anaSayfa.lblHedef.Text = "GLUTENSİZ HAYATA BAŞLADIN";

            }
            if (cysorgu.ChallengeYourSelfEnum == ChallengeYourSelfEnum.KahveyiAzalt)
            {
                
                AnaSayfa.anaSayfa.lblHedef.Text = "KAFEİNSİZ BİR HAYATA BAŞLADIN";

            }
            if (cysorgu.ChallengeYourSelfEnum == ChallengeYourSelfEnum.ŞekerYok)
            {
                
                AnaSayfa.anaSayfa.lblHedef.Text = "ŞEKERSİZ GÜNLERE MERHABA";

            }
            if (cysorgu.ChallengeYourSelfEnum == ChallengeYourSelfEnum.Suİç)
            {
                
                AnaSayfa.anaSayfa.lblHedef.Text = "BÖBREKLERİN BAYRAM EDECEK";

            }

            if(cysorgu.EklenmeTarihi<DateTime.Today)
            {
                cysorgu.GunFarki = (DateTime.Now.DayOfYear - cysorgu.EklenmeTarihi.DayOfYear);
            }

            if (cysorgu.GunFarki == 0)
            {
                lblCYSGunSayisi.Text = "0.GÜN";
            }
            else
                lblCYSGunSayisi.Text = $"{cysorgu.GunFarki}" + ".Gün";

        }

        private void cysprogressBar()
        {
            var cysorgu = db.ChallengeYourSelf.Where(x => x.UserInfoID == LoginPage.id).OrderByDescending(x => x.EklenmeTarihi).FirstOrDefault();
            hrpCYS.Percentage = (int)((cysorgu.GunFarki * 100) / KendineMeydanOku.aliskanlikSuresi);
        }

        private void kaloriProgressBar()
        {
            var sorgu = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault();
            hrpKal.Percentage = (int)((sorgu.DailyCalorie / sorgu.RequiredCalorie) * 100);
        }

    }
}