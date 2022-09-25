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
    public partial class AylikTakip : Form
    {
        public AylikTakip()
        {
            InitializeComponent();
        }
        FitYourSelfContext db;    

        private void AylikTakip_Load(object sender, EventArgs e)
        {
            double calorie1 = 0;
            double calorie2 = 0;
            double calorie3 = 0;
            double calorie4 = 0;
            double calorie5 = 0;
            double calorie6 = 0;
            double calorie7 = 0;
            double calorie8 = 0;
            double calorie9 = 0;
            double calorie10 = 0;
            double calorie11 = 0;
            double calorie12 = 0;
            double calorie13 = 0;
            double calorie14 = 0;
            double calorie15 = 0;
            double calorie16 = 0;
            double calorie17 = 0;
            double calorie18 = 0;
            double calorie19 = 0;
            double calorie20 = 0;
            double calorie21 = 0;
            double calorie22 = 0;
            double calorie23 = 0;
            double calorie24 = 0;
            double calorie25 = 0;
            double calorie26 = 0;
            double calorie27 = 0;
            double calorie28 = 0;
            double calorie29 = 0;
            double calorie30 = 0;

            double fat1 = 0;
            double fat2 = 0;
            double fat3 = 0;
            double fat4 = 0;
            double fat5 = 0;
            double fat6 = 0;
            double fat7 = 0;
            double fat8 = 0;
            double fat9 = 0;
            double fat10 = 0;
            double fat11 = 0;
            double fat12 = 0;
            double fat13 = 0;
            double fat14 = 0;
            double fat15 = 0;
            double fat16 = 0;
            double fat17 = 0;
            double fat18 = 0;
            double fat19 = 0;
            double fat20 = 0;
            double fat21 = 0;
            double fat22 = 0;
            double fat23 = 0;
            double fat24 = 0;
            double fat25 = 0;
            double fat26 = 0;
            double fat27 = 0;
            double fat28 = 0;
            double fat29 = 0;
            double fat30 = 0;

            double carbonhydrate1 = 0;
            double carbonhydrate2 = 0;
            double carbonhydrate3 = 0;
            double carbonhydrate4 = 0;
            double carbonhydrate5 = 0;
            double carbonhydrate6 = 0;
            double carbonhydrate7 = 0;
            double carbonhydrate8 = 0;
            double carbonhydrate9 = 0;
            double carbonhydrate10 = 0;
            double carbonhydrate11 = 0;
            double carbonhydrate12 = 0;
            double carbonhydrate13 = 0;
            double carbonhydrate14 = 0;
            double carbonhydrate15 = 0;
            double carbonhydrate16 = 0;
            double carbonhydrate17 = 0;
            double carbonhydrate18 = 0;
            double carbonhydrate19 = 0;
            double carbonhydrate20 = 0;
            double carbonhydrate21 = 0;
            double carbonhydrate22 = 0;
            double carbonhydrate23 = 0;
            double carbonhydrate24 = 0;
            double carbonhydrate25 = 0;
            double carbonhydrate26 = 0;
            double carbonhydrate27 = 0;
            double carbonhydrate28 = 0;
            double carbonhydrate29 = 0;
            double carbonhydrate30 = 0;

            double protein1 = 0;
            double protein2 = 0;
            double protein3 = 0;
            double protein4 = 0;
            double protein5 = 0;
            double protein6 = 0;
            double protein7 = 0;
            double protein8 = 0;
            double protein9 = 0;
            double protein10 = 0;
            double protein11 = 0;
            double protein12 = 0;
            double protein13 = 0;
            double protein14 = 0;
            double protein15 = 0;
            double protein16 = 0;
            double protein17 = 0;
            double protein18 = 0;
            double protein19 = 0;
            double protein20 = 0;
            double protein21 = 0;
            double protein22 = 0;
            double protein23 = 0;
            double protein24 = 0;
            double protein25 = 0;
            double protein26 = 0;
            double protein27 = 0;
            double protein28 = 0;
            double protein29 = 0;
            double protein30 = 0;



            db = new FitYourSelfContext();
            DateTime dt1 = (DateTime)DateTime.Today.AddDays(-29);

            var sorgu = db.UserMeals.Where(x => x.UserInfoID == LoginPage.id).ToList();
            var sorguselo = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate >= dt1).OrderByDescending(x => x.MealDate);





            DateTime dt2 = (DateTime)DateTime.Today;
            DateTime dt3 = (DateTime)DateTime.Today.AddDays(-1);
            DateTime dt4 = (DateTime)DateTime.Today.AddDays(-2);
            DateTime dt5 = (DateTime)DateTime.Today.AddDays(-3);
            DateTime dt6 = (DateTime)DateTime.Today.AddDays(-4);
            DateTime dt7 = (DateTime)DateTime.Today.AddDays(-5);
            DateTime dt8 = (DateTime)DateTime.Today.AddDays(-6);
            DateTime dt9 = (DateTime)DateTime.Today.AddDays(-7);
            DateTime dt10 = (DateTime)DateTime.Today.AddDays(-8);
            DateTime dt11 = (DateTime)DateTime.Today.AddDays(-9);
            DateTime dt12 = (DateTime)DateTime.Today.AddDays(-10);
            DateTime dt13 = (DateTime)DateTime.Today.AddDays(-11);
            DateTime dt14 = (DateTime)DateTime.Today.AddDays(-12);
            DateTime dt15 = (DateTime)DateTime.Today.AddDays(-13);
            DateTime dt16 = (DateTime)DateTime.Today.AddDays(-14);
            DateTime dt17 = (DateTime)DateTime.Today.AddDays(-15);
            DateTime dt18 = (DateTime)DateTime.Today.AddDays(-16);
            DateTime dt19 = (DateTime)DateTime.Today.AddDays(-17);
            DateTime dt20 = (DateTime)DateTime.Today.AddDays(-18);
            DateTime dt21 = (DateTime)DateTime.Today.AddDays(-19);
            DateTime dt22 = (DateTime)DateTime.Today.AddDays(-21);
            DateTime dt23 = (DateTime)DateTime.Today.AddDays(-22);
            DateTime dt24 = (DateTime)DateTime.Today.AddDays(-23);
            DateTime dt25 = (DateTime)DateTime.Today.AddDays(-24);
            DateTime dt26 = (DateTime)DateTime.Today.AddDays(-25);
            DateTime dt27 = (DateTime)DateTime.Today.AddDays(-26);
            DateTime dt28 = (DateTime)DateTime.Today.AddDays(-27);
            DateTime dt29 = (DateTime)DateTime.Today.AddDays(-28);
            DateTime dt30 = (DateTime)DateTime.Today.AddDays(-29);
            DateTime dt31 = (DateTime)DateTime.Today.AddDays(-30);








            var sorgu1 = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt2).ToList();

            foreach (var item in sorgu1)
            {
                calorie1 = calorie1 + item.Calorie;
                fat1 = fat1 + item.Fat;
                carbonhydrate1 = carbonhydrate1 + item.Carbonhidrate;
                protein1 = protein1 + item.Protein;


            }
            var sorgu2 = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt3).ToList();
            foreach (var item in sorgu2)
            {
                calorie2 = calorie2 + item.Calorie;
                fat2 = fat2 + item.Fat;
                carbonhydrate2 = carbonhydrate2 + item.Carbonhidrate;
                protein2 = protein2 + item.Protein;
            }

            var sorgu3 = db.UserMeals
                 .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt4).ToList();

            foreach (var item in sorgu3)
            {
                calorie3 = calorie3 + item.Calorie;
                fat3 = fat3 + item.Fat;
                carbonhydrate3 = carbonhydrate3 + item.Carbonhidrate;
                protein3 = protein3 + item.Protein;
            }
            var sorgu4 = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt5).ToList();
            foreach (var item in sorgu4)
            {
                calorie4 = calorie4 + item.Calorie;
                fat4 = fat4 + item.Fat;
                carbonhydrate4 = carbonhydrate4 + item.Carbonhidrate;
                protein4 = protein4 + item.Protein;
            }
            var sorgu5 = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt6).ToList();

            foreach (var item in sorgu5)
            {
                calorie5 = calorie5 + item.Calorie;
                fat5 = fat5 + item.Fat;
                carbonhydrate5 = carbonhydrate5 + item.Carbonhidrate;
                protein7 = protein7 + item.Protein;
            }
            var sorgu6 = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt7).ToList();
            foreach (var item in sorgu6)
            {
                calorie6 = calorie6 + item.Calorie;
                fat6 = fat6 + item.Fat;
                carbonhydrate6 = carbonhydrate6 + item.Carbonhidrate;
                protein7 = protein7 + item.Protein;
            }

            var sorgu7 = db.UserMeals
                 .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt8).ToList();

            foreach (var item in sorgu7)
            {
                calorie7 = calorie7 + item.Calorie;
                fat7 = fat7 + item.Fat;
                carbonhydrate7 = carbonhydrate7 + item.Carbonhidrate;
                protein7 = protein7 + item.Protein;

            }
            var sorgu8 = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt9).ToList();

            foreach (var item in sorgu1)
            {
                calorie8 = calorie8 + item.Calorie;
                fat8 = fat8 + item.Fat;
                carbonhydrate8 = carbonhydrate8 + item.Carbonhidrate;
                protein8 = protein8 + item.Protein;


            }
            var sorgu9 = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt10).ToList();
            foreach (var item in sorgu2)
            {
                calorie9 = calorie9 + item.Calorie;
                fat9 = fat9 + item.Fat;
                carbonhydrate9 = carbonhydrate9 + item.Carbonhidrate;
                protein9 = protein9 + item.Protein;
            }

            var sorgu10 = db.UserMeals
                 .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt11).ToList();

            foreach (var item in sorgu3)
            {
                calorie10 = calorie10 + item.Calorie;
                fat10 = fat10 + item.Fat;
                carbonhydrate10 = carbonhydrate10 + item.Carbonhidrate;
                protein10 = protein10 + item.Protein;
            }
            var sorgu11 = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt12).ToList();
            foreach (var item in sorgu4)
            {
                calorie11 = calorie11 + item.Calorie;
                fat11 = fat11 + item.Fat;
                carbonhydrate11 = carbonhydrate11 + item.Carbonhidrate;
                protein11 = protein11 + item.Protein;
            }
            var sorgu12 = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt13).ToList();

            foreach (var item in sorgu12)
            {
                calorie12 = calorie12 + item.Calorie;
                fat12 = fat12 + item.Fat;
                carbonhydrate12 = carbonhydrate12 + item.Carbonhidrate;
                protein12 = protein12 + item.Protein;
            }
            var sorgu13 = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt14).ToList();
            foreach (var item in sorgu13)
            {
                calorie13 = calorie13 + item.Calorie;
                fat13 = fat13 + item.Fat;
                carbonhydrate13 = carbonhydrate13 + item.Carbonhidrate;
                protein13 = protein13 + item.Protein;
            }

            var sorgu14 = db.UserMeals
                 .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt15).ToList();

            foreach (var item in sorgu14)
            {
                calorie14 = calorie14 + item.Calorie;
                fat14 = fat14 + item.Fat;
                carbonhydrate14 = carbonhydrate14 + item.Carbonhidrate;
                protein14 = protein14 + item.Protein;

            }

            var sorgu15 = db.UserMeals
             .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt16).ToList();

            foreach (var item in sorgu15)
            {
                calorie15 = calorie15 + item.Calorie;
                fat15 = fat15 + item.Fat;
                carbonhydrate15 = carbonhydrate15 + item.Carbonhidrate;
                protein15 = protein15 + item.Protein;


            }
            var sorgu16 = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt17).ToList();
            foreach (var item in sorgu16)
            {
                calorie16 = calorie16 + item.Calorie;
                fat16 = fat16 + item.Fat;
                carbonhydrate16 = carbonhydrate16 + item.Carbonhidrate;
                protein16 = protein16 + item.Protein;
            }

            var sorgu17 = db.UserMeals
                 .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt18).ToList();

            foreach (var item in sorgu17)
            {
                calorie17 = calorie17 + item.Calorie;
                fat17 = fat17 + item.Fat;
                carbonhydrate17 = carbonhydrate17 + item.Carbonhidrate;
                protein17 = protein17 + item.Protein;
            }
            var sorgu18 = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt19).ToList();
            foreach (var item in sorgu18)
            {
                calorie18 = calorie18 + item.Calorie;
                fat18 = fat18 + item.Fat;
                carbonhydrate18 = carbonhydrate18 + item.Carbonhidrate;
                protein18 = protein18 + item.Protein;
            }
            var sorgu19 = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt20).ToList();

            foreach (var item in sorgu19)
            {
                calorie19 = calorie19 + item.Calorie;
                fat19 = fat19 + item.Fat;
                carbonhydrate19 = carbonhydrate19 + item.Carbonhidrate;
                protein19 = protein19 + item.Protein;
            }
            var sorgu20 = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt21).ToList();
            foreach (var item in sorgu20)
            {
                calorie20 = calorie20 + item.Calorie;
                fat20 = fat20 + item.Fat;
                carbonhydrate20 = carbonhydrate20 + item.Carbonhidrate;
                protein20 = protein20 + item.Protein;
            }

            var sorgu21 = db.UserMeals
                 .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt22).ToList();

            foreach (var item in sorgu21)
            {
                calorie21 = calorie21 + item.Calorie;
                fat21 = fat21 + item.Fat;
                carbonhydrate21 = carbonhydrate21 + item.Carbonhidrate;
                protein21 = protein21 + item.Protein;

            }
            var sorgu22 = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt23).ToList();

            foreach (var item in sorgu22)
            {
                calorie22 = calorie22 + item.Calorie;
                fat22 = fat22 + item.Fat;
                carbonhydrate22 = carbonhydrate22 + item.Carbonhidrate;
                protein22 = protein22 + item.Protein;


            }
            var sorgu23 = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt24).ToList();
            foreach (var item in sorgu23)
            {
                calorie23 = calorie23 + item.Calorie;
                fat23 = fat23 + item.Fat;
                carbonhydrate23 = carbonhydrate23 + item.Carbonhidrate;
                protein23 = protein23 + item.Protein;
            }

            var sorgu24 = db.UserMeals
                 .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt25).ToList();

            foreach (var item in sorgu24)
            {
                calorie24 = calorie10 + item.Calorie;
                fat24 = fat24 + item.Fat;
                carbonhydrate24 = carbonhydrate24 + item.Carbonhidrate;
                protein24 = protein24 + item.Protein;
            }
            var sorgu25 = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt26).ToList();
            foreach (var item in sorgu25)
            {
                calorie25 = calorie11 + item.Calorie;
                fat25 = fat25 + item.Fat;
                carbonhydrate25 = carbonhydrate25 + item.Carbonhidrate;
                protein25 = protein25 + item.Protein;
            }
            var sorgu26 = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt27).ToList();

            foreach (var item in sorgu26)
            {
                calorie26 = calorie26 + item.Calorie;
                fat26 = fat26 + item.Fat;
                carbonhydrate26 = carbonhydrate26 + item.Carbonhidrate;
                protein26 = protein26 + item.Protein;
            }
            var sorgu27 = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt28).ToList();
            foreach (var item in sorgu27)
            {
                calorie27 = calorie27 + item.Calorie;
                fat27 = fat27 + item.Fat;
                carbonhydrate27 = carbonhydrate27 + item.Carbonhidrate;
                protein27 = protein27 + item.Protein;
            }

            var sorgu28 = db.UserMeals
                 .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt29).ToList();

            foreach (var item in sorgu28)
            {

                calorie28 = calorie28 + item.Calorie;
                fat28 = fat28 + item.Fat;
                carbonhydrate28 = carbonhydrate28 + item.Carbonhidrate;
                protein28 = protein28 + item.Protein;

            }

            var sorgu29 = db.UserMeals
                 .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt30).ToList();

            foreach (var item in sorgu29)
            {

                calorie29 = calorie29 + item.Calorie;
                fat29 = fat29 + item.Fat;
                carbonhydrate29 = carbonhydrate29 + item.Carbonhidrate;
                protein29 = protein29 + item.Protein;

            }

            var sorgu30 = db.UserMeals
                 .Where(x => x.UserInfoID == LoginPage.id && x.MealDate == dt31).ToList();

            foreach (var item in sorgu30)
            {

                calorie30 = calorie30 + item.Calorie;
                fat30 = fat30 + item.Fat;
                carbonhydrate30 = carbonhydrate30 + item.Carbonhidrate;
                protein30 = protein30 + item.Protein;

            }


            chart1.Series["Kalori"].Points.AddXY(dt2, calorie1);
            chart1.Series["Kalori"].Points.AddXY(dt3, calorie2);
            chart1.Series["Kalori"].Points.AddXY(dt4, calorie3);
            chart1.Series["Kalori"].Points.AddXY(dt5, calorie4);
            chart1.Series["Kalori"].Points.AddXY(dt6, calorie5);
            chart1.Series["Kalori"].Points.AddXY(dt7, calorie6);
            chart1.Series["Kalori"].Points.AddXY(dt8, calorie7);
            chart1.Series["Kalori"].Points.AddXY(dt9, calorie8);
            chart1.Series["Kalori"].Points.AddXY(dt10, calorie9);
            chart1.Series["Kalori"].Points.AddXY(dt11, calorie10);
            chart1.Series["Kalori"].Points.AddXY(dt12, calorie12);
            chart1.Series["Kalori"].Points.AddXY(dt13, calorie13);
            chart1.Series["Kalori"].Points.AddXY(dt14, calorie14);
            chart1.Series["Kalori"].Points.AddXY(dt15, calorie15);
            chart1.Series["Kalori"].Points.AddXY(dt16, calorie16);
            chart1.Series["Kalori"].Points.AddXY(dt17, calorie17);
            chart1.Series["Kalori"].Points.AddXY(dt18, calorie18);
            chart1.Series["Kalori"].Points.AddXY(dt19, calorie19);
            chart1.Series["Kalori"].Points.AddXY(dt20, calorie20);
            chart1.Series["Kalori"].Points.AddXY(dt21, calorie21);
            chart1.Series["Kalori"].Points.AddXY(dt22, calorie22);
            chart1.Series["Kalori"].Points.AddXY(dt23, calorie23);
            chart1.Series["Kalori"].Points.AddXY(dt24, calorie24);
            chart1.Series["Kalori"].Points.AddXY(dt25, calorie25);
            chart1.Series["Kalori"].Points.AddXY(dt26, calorie26);
            chart1.Series["Kalori"].Points.AddXY(dt27, calorie27);
            chart1.Series["Kalori"].Points.AddXY(dt28, calorie28);
            chart1.Series["Kalori"].Points.AddXY(dt29, calorie29);
            chart1.Series["Kalori"].Points.AddXY(dt30, calorie30);


            chart2.Series["Yağ"].Points.AddXY(dt2, fat1);
            chart2.Series["Yağ"].Points.AddXY(dt3, fat2);
            chart2.Series["Yağ"].Points.AddXY(dt4, fat3);
            chart2.Series["Yağ"].Points.AddXY(dt5, fat4);
            chart2.Series["Yağ"].Points.AddXY(dt6, fat5);
            chart2.Series["Yağ"].Points.AddXY(dt7, fat6);
            chart2.Series["Yağ"].Points.AddXY(dt8, fat7);
            chart2.Series["Yağ"].Points.AddXY(dt9, fat8);
            chart2.Series["Yağ"].Points.AddXY(dt10, fat9);
            chart2.Series["Yağ"].Points.AddXY(dt11, fat10);
            chart2.Series["Yağ"].Points.AddXY(dt12, fat12);
            chart2.Series["Yağ"].Points.AddXY(dt13, fat13);
            chart2.Series["Yağ"].Points.AddXY(dt14, fat14);
            chart2.Series["Yağ"].Points.AddXY(dt15, fat15);
            chart2.Series["Yağ"].Points.AddXY(dt16, fat16);
            chart2.Series["Yağ"].Points.AddXY(dt17, fat17);
            chart2.Series["Yağ"].Points.AddXY(dt18, fat18);
            chart2.Series["Yağ"].Points.AddXY(dt19, fat19);
            chart2.Series["Yağ"].Points.AddXY(dt20, fat20);
            chart2.Series["Yağ"].Points.AddXY(dt21, fat21);
            chart2.Series["Yağ"].Points.AddXY(dt22, fat22);
            chart2.Series["Yağ"].Points.AddXY(dt23, fat23);
            chart2.Series["Yağ"].Points.AddXY(dt24, fat24);
            chart2.Series["Yağ"].Points.AddXY(dt25, fat25);
            chart2.Series["Yağ"].Points.AddXY(dt26, fat26);
            chart2.Series["Yağ"].Points.AddXY(dt27, fat27);
            chart2.Series["Yağ"].Points.AddXY(dt28, fat28);
            chart2.Series["Yağ"].Points.AddXY(dt29, fat29);
            chart2.Series["Yağ"].Points.AddXY(dt30, fat30);

            chart2.Series["Karbonhidrat"].Points.AddXY(dt2, carbonhydrate1);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt3, carbonhydrate2);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt4, carbonhydrate3);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt5, carbonhydrate4);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt6, carbonhydrate5);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt7, carbonhydrate6);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt8, carbonhydrate7);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt9, carbonhydrate8);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt10, carbonhydrate9);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt11, carbonhydrate10);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt12, carbonhydrate12);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt13, carbonhydrate13);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt14, carbonhydrate14);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt15, carbonhydrate15);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt16, carbonhydrate16);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt17, carbonhydrate17);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt18, carbonhydrate18);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt19, carbonhydrate19);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt20, carbonhydrate20);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt21, carbonhydrate21);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt22, carbonhydrate22);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt23, carbonhydrate23);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt24, carbonhydrate24);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt25, carbonhydrate25);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt26, carbonhydrate26);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt27, carbonhydrate27);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt28, carbonhydrate28);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt29, carbonhydrate29);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt30, carbonhydrate30);

            chart2.Series["Protein"].Points.AddXY(dt2, protein1);
            chart2.Series["Protein"].Points.AddXY(dt3, protein2);
            chart2.Series["Protein"].Points.AddXY(dt4, protein3);
            chart2.Series["Protein"].Points.AddXY(dt5, protein4);
            chart2.Series["Protein"].Points.AddXY(dt6, protein5);
            chart2.Series["Protein"].Points.AddXY(dt7, protein6);
            chart2.Series["Protein"].Points.AddXY(dt8, protein7);
            chart2.Series["Protein"].Points.AddXY(dt9, protein8);
            chart2.Series["Protein"].Points.AddXY(dt10, protein9);
            chart2.Series["Protein"].Points.AddXY(dt11, protein10);
            chart2.Series["Protein"].Points.AddXY(dt12, protein12);
            chart2.Series["Protein"].Points.AddXY(dt13, protein13);
            chart2.Series["Protein"].Points.AddXY(dt14, protein14);
            chart2.Series["Protein"].Points.AddXY(dt15, protein15);
            chart2.Series["Protein"].Points.AddXY(dt16, protein16);
            chart2.Series["Protein"].Points.AddXY(dt17, protein17);
            chart2.Series["Protein"].Points.AddXY(dt18, protein18);
            chart2.Series["Protein"].Points.AddXY(dt19, protein19);
            chart2.Series["Protein"].Points.AddXY(dt20, protein20);
            chart2.Series["Protein"].Points.AddXY(dt21, protein21);
            chart2.Series["Protein"].Points.AddXY(dt22, protein22);
            chart2.Series["Protein"].Points.AddXY(dt23, protein23);
            chart2.Series["Protein"].Points.AddXY(dt24, protein24);
            chart2.Series["Protein"].Points.AddXY(dt25, protein25);
            chart2.Series["Protein"].Points.AddXY(dt26, protein26);
            chart2.Series["Protein"].Points.AddXY(dt27, protein27);
            chart2.Series["Protein"].Points.AddXY(dt28, protein28);
            chart2.Series["Protein"].Points.AddXY(dt29, protein29);
            chart2.Series["Protein"].Points.AddXY(dt30, protein30);
        }
    }
}
