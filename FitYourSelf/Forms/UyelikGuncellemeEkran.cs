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
    public partial class UyelikGuncellemeEkran : Form
    {
        public UyelikGuncellemeEkran()
        {
            InitializeComponent();

        }


        FitYourSelfContext db;

        private void UyelikGuncellemeEkran_Load(object sender, EventArgs e)
        {
            db = new FitYourSelfContext();
            var kullanici2 = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault();
            txtBoy.Text = kullanici2.Height.ToString();
            txtKilo.Text = kullanici2.Weight.ToString();
            txtGunlukKaloriIhtiyaci.Text = kullanici2.RequiredCalorie.ToString();


          
           
        }

        

        private double BMIHesapla(double boy, double kilo)
        {
            double mBoy = boy / 100;
            double bmiIndex;
            bmiIndex = Math.Round((kilo / (mBoy * mBoy)), 2);
            return bmiIndex;
        }

        private bool KiloDogruMu()
        {
            if (Convert.ToDouble(txtKilo.Text) <= 20 || Convert.ToDouble(txtKilo.Text) >= 200)
                return false;
            else
                return true;
        }

        private bool BoyDogrumu()
        {
            if (Convert.ToDouble(txtBoy.Text) <= 100 || Convert.ToDouble(txtBoy.Text) >= 220)
                return false;
            else
                return true;


        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

       

        private void txtBoy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
                e.Handled = true;
        }

        private void txtKilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
                e.Handled = true;
        }

        private void txtGunlukKal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
                e.Handled = true;
        }

        

        private bool SifreDogrulama(string sifre, string sifreTekrar)
        {
            if (sifre != sifreTekrar)
                return false;

            else
                return true;
        }



        public bool SifreKontrol(string sifre)
        {
            int totalCharacter = 0, totalLetterChar = 0, totalDigitChar = 0, totalSpecialChar = 0;
            foreach (var item in sifre.ToCharArray())
            {
                if (char.IsDigit(item))
                    totalDigitChar++;
                if (char.IsLetter(item))
                    totalLetterChar++;
                if (!char.IsLetterOrDigit(item))
                    totalSpecialChar++;
                totalCharacter++;
            }
            if (totalCharacter < 8 || totalDigitChar == 0 || totalLetterChar == 0 || totalSpecialChar == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool EskiSifreDogruMu(string sifre, int id) 
        {
            var sorgu = db.UserInfo.Where(x => x.UserInfoID == id).FirstOrDefault();
            if (sifre == sorgu.Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnSifreDegis_Click(object sender, EventArgs e)
        {
            if (txtEskiSifre.Text != "" && txtYeniSifre.Text != "" && txtYeniSifreTekrar.Text != "")
            {
                if (SifreDogrulama(txtYeniSifre.Text, txtYeniSifreTekrar.Text) && SifreKontrol(txtYeniSifre.Text) && EskiSifreDogruMu(txtEskiSifre.Text, LoginPage.id))
                {
                    var sorgu = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault();
                    sorgu.Password = txtYeniSifre.Text;
                    db.SaveChanges();
                    MessageBox.Show("Şifre değiştirme işlemi başarı ile gerçekleştirildi.");
                }
                else
                {
                    if (!EskiSifreDogruMu(txtEskiSifre.Text, LoginPage.id))
                    {
                        MessageBox.Show("Girdiğiniz eski şifre mevcut şifreniz ile aynı değil.");
                    }
                    if (!SifreDogrulama(txtYeniSifre.Text, txtYeniSifreTekrar.Text))
                    {
                        MessageBox.Show("Girdiğiniz yeni şifre ile şifre tekrarı aynı değil.");
                    }
                    if (!SifreKontrol(txtYeniSifre.Text))
                    {
                        MessageBox.Show("Girdiğiniz şifre doğru biçimde değil.");
                    }
                }
            }
            else
            {
                if (txtEskiSifre.Text == "")
                {
                    MessageBox.Show("Eski şifre alanı boş bırakılamaz.");
                }
                else if (txtYeniSifre.Text == "")
                {
                    MessageBox.Show("Yeni şifre alanı boş bırakılamaz.");
                }
                else if (txtYeniSifreTekrar.Text != "")
                {
                    MessageBox.Show("Yeni tekrar şifre alanı boş bırakılamaz.");
                }
            }
        }

        private void furkanButtons1_Click(object sender, EventArgs e)
        {
            var kullanici = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault();

            if (txtBoy.Text != "" && txtKilo.Text != "" && txtGunlukKaloriIhtiyaci.Text != "")
            {
                if (BoyDogrumu() && KiloDogruMu())
                {

                    kullanici.Height = Convert.ToInt32(txtBoy.Text);
                    kullanici.Weight = Convert.ToDouble(txtKilo.Text);
                    kullanici.BodyMassIndex = BMIHesapla(kullanici.Height, kullanici.Weight);
                    kullanici.RequiredCalorie = Convert.ToDouble(txtGunlukKaloriIhtiyaci.Text);

                }

                else
                {
                    if (Convert.ToDouble(txtBoy.Text) <= 100 || Convert.ToDouble(txtBoy.Text) >= 220)
                        MessageBox.Show("Lütfen boy için 100 ila 220 cm arası bir değer giriniz.");
                    if (Convert.ToDouble(txtKilo.Text) <= 20 || Convert.ToDouble(txtKilo.Text) >= 200)
                        MessageBox.Show("Lütfen kilo için 20 ila 200 kg arası bir değer giriniz.");
                }
            }
            else
            {
                kullanici.Height = kullanici.Height;
                kullanici.Weight = kullanici.Weight;
                kullanici.RequiredCalorie = kullanici.RequiredCalorie;
            }

            AnaSayfa.anaSayfa.lblVKI.Text = kullanici.BodyMassIndex.ToString();
            AnaSayfa.anaSayfa.lblBoy.Text = kullanici.Height.ToString();
            AnaSayfa.anaSayfa.lblKilo.Text = kullanici.Weight.ToString();
            AnaSayfa.anaSayfa.lblGunlukKalori.Text = kullanici.RequiredCalorie.ToString();

            if (kullanici.BodyMassIndex >= 0 && kullanici.BodyMassIndex <= 18.4)
            {
                kullanici.BMIStatus = BMIStatus.Zayıf;
                AnaSayfa.anaSayfa.lblDurum.Text = BMIStatus.Zayıf.GetDisplayName();
            }
            if (kullanici.BodyMassIndex > 18.4 && kullanici.BodyMassIndex <= 24.9)
            {
                kullanici.BMIStatus = BMIStatus.NormalKilolu;
                AnaSayfa.anaSayfa.lblDurum.Text = BMIStatus.NormalKilolu.GetDisplayName();
            }
            if (kullanici.BodyMassIndex > 25 && kullanici.BodyMassIndex <= 29.9)
            {
                kullanici.BMIStatus = BMIStatus.FazlaKilolu;
                AnaSayfa.anaSayfa.lblDurum.Text = BMIStatus.FazlaKilolu.GetDisplayName();
            }
            if (kullanici.BodyMassIndex > 30 && kullanici.BodyMassIndex <= 34.9)
            {
                kullanici.BMIStatus = BMIStatus.BirinciDereceObezite;
                AnaSayfa.anaSayfa.lblDurum.Text = BMIStatus.BirinciDereceObezite.GetDisplayName();
            }
            if (kullanici.BodyMassIndex > 35 && kullanici.BodyMassIndex <= 39.9)
            {
                kullanici.BMIStatus = BMIStatus.İkinciDereceObezite;
                AnaSayfa.anaSayfa.lblDurum.Text = BMIStatus.İkinciDereceObezite.GetDisplayName();
            }
            if (kullanici.BodyMassIndex > 40)
            {
                kullanici.BMIStatus = BMIStatus.ÜçüncüDereceObezite;
                AnaSayfa.anaSayfa.lblDurum.Text = BMIStatus.ÜçüncüDereceObezite.GetDisplayName();
            }

            UserMassInfo yenikullanici = new UserMassInfo();
            yenikullanici.UserMassHeight = Convert.ToInt32(txtBoy.Text);
            yenikullanici.UserMassWeight = Convert.ToDouble(txtKilo.Text);
            yenikullanici.UserMassBMI = BMIHesapla(yenikullanici.UserMassHeight, yenikullanici.UserMassWeight);
            if (yenikullanici.UserMassBMI >= 0 && yenikullanici.UserMassBMI <= 18.4)
            {
                yenikullanici.BMIStatus = BMIStatus.Zayıf;

            }
            if (yenikullanici.UserMassBMI > 18.4 && yenikullanici.UserMassBMI <= 24.9)
            {
                yenikullanici.BMIStatus = BMIStatus.NormalKilolu;

            }
            if (yenikullanici.UserMassBMI > 25 && yenikullanici.UserMassBMI <= 29.9)
            {
                yenikullanici.BMIStatus = BMIStatus.FazlaKilolu;

            }
            if (yenikullanici.UserMassBMI > 30 && yenikullanici.UserMassBMI <= 34.9)
            {
                yenikullanici.BMIStatus = BMIStatus.BirinciDereceObezite;

            }
            if (yenikullanici.UserMassBMI > 35 && yenikullanici.UserMassBMI <= 39.9)
            {
                yenikullanici.BMIStatus = BMIStatus.İkinciDereceObezite;

            }
            if (yenikullanici.UserMassBMI > 40)
            {
                yenikullanici.BMIStatus = BMIStatus.ÜçüncüDereceObezite;

            }
            yenikullanici.DateTime = DateTime.Now;
            yenikullanici.UserInfoID = LoginPage.id;
            db.UserMassInfo.Add(yenikullanici); 
            db.SaveChanges();
            AnaSayfa.anaSayfa.lblKalanKaloriMiktari.Text = (kullanici.RequiredCalorie - kullanici.DailyCalorie).ToString();
            AnaSayfa.anaSayfa.hrpKal.Percentage = (int)(kullanici.DailyCalorie * 100 / kullanici.RequiredCalorie);
            if (kullanici.RequiredCalorie - kullanici.DailyCalorie < 0)
                AnaSayfa.anaSayfa.lblKalanKaloriMiktari.Text = 0.ToString();

            MessageBox.Show("Kişisel bilgiler başarılı bir şekilde güncellendi.");
        }
    }
}
