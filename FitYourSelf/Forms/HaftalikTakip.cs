using FitYourSelf.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FitYourSelf.Forms
{
    public partial class HaftalikTakip : Form
    {
        public HaftalikTakip()
        {
            InitializeComponent();
        }
        FitYourSelfContext db;
        private void HaftalikTakip_Load(object sender, EventArgs e)
        {
            double calorie1 = 0;
            double calorie2 = 0;
            double calorie3 = 0;
            double calorie4 = 0;
            double calorie5 = 0;
            double calorie6 = 0;
            double calorie7 = 0;
            double fat1 = 0;
            double fat2 = 0;
            double fat3 = 0;
            double fat4 = 0;
            double fat5 = 0;
            double fat6 = 0;
            double fat7 = 0;
            double carbonhydrate1 = 0;
            double carbonhydrate2 = 0;
            double carbonhydrate3 = 0;
            double carbonhydrate4 = 0;
            double carbonhydrate5 = 0;
            double carbonhydrate6 = 0;
            double carbonhydrate7 = 0;
            double protein1 = 0;
            double protein2 = 0;
            double protein3 = 0;
            double protein4 = 0;
            double protein5 = 0;
            double protein6 = 0;
            double protein7 = 0;
            db = new FitYourSelfContext();
            DateTime dt1 = (DateTime)DateTime.Today.AddDays(-6);
            
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



            chart1.Series["Kalori"].Points.AddXY(dt2, calorie1);
            chart1.Series["Kalori"].Points.AddXY(dt3, calorie2);
            chart1.Series["Kalori"].Points.AddXY(dt4, calorie3);
            chart1.Series["Kalori"].Points.AddXY(dt5, calorie4);
            chart1.Series["Kalori"].Points.AddXY(dt6, calorie5);
            chart1.Series["Kalori"].Points.AddXY(dt7, calorie6);
            chart1.Series["Kalori"].Points.AddXY(dt8, calorie7);
            chart2.Series["Yağ"].Points.AddXY(dt2, fat1);
            chart2.Series["Yağ"].Points.AddXY(dt3, fat2);
            chart2.Series["Yağ"].Points.AddXY(dt4, fat3);
            chart2.Series["Yağ"].Points.AddXY(dt5, fat4);
            chart2.Series["Yağ"].Points.AddXY(dt6, fat5);
            chart2.Series["Yağ"].Points.AddXY(dt7, fat6);
            chart2.Series["Yağ"].Points.AddXY(dt8, fat7);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt2, carbonhydrate1);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt3, carbonhydrate2);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt4, carbonhydrate3);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt5, carbonhydrate4);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt6, carbonhydrate5);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt7, carbonhydrate6);
            chart2.Series["Karbonhidrat"].Points.AddXY(dt8, carbonhydrate7);
            chart2.Series["Protein"].Points.AddXY(dt2, protein1);
            chart2.Series["Protein"].Points.AddXY(dt3, protein2);
            chart2.Series["Protein"].Points.AddXY(dt4, protein3);
            chart2.Series["Protein"].Points.AddXY(dt5, protein4);
            chart2.Series["Protein"].Points.AddXY(dt6, protein5);
            chart2.Series["Protein"].Points.AddXY(dt7, protein6);
            chart2.Series["Protein"].Points.AddXY(dt8, protein7);

            //double calorie = 0,
            //        fat = 0,
            //        protein = 0,
            //        carbonhydrate = 0;




            //chart1.Series["Kalori"].Points.Add(calorie);


            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{

            //    calorie += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            //    fat += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
            //    carbonhydrate += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
            //    protein += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
            //}
            //dataGridView1.Rows.Add(calorie, fat, carbonhydrate,protein);
            //chart1.Series["Kalori"].Points.AddY(calorie);
            //chart1.Series["Karbonhidrat"].Points.AddY(carbonhydrate);
            //chart1.Series["Yağ"].Points.AddY(fat);
            //chart1.Series["Protein"].Points.AddY(protein);






            //for (int i = 0; i < 6; i++)
            //{
            //    chart1.Series["Günler"].Points[i].AxisLabel = DateTime.Today.AddDays(i).ToString();
            //}






        }


    }
}
