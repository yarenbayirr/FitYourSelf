using FitYorSelf.Entities.Concrete;
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
using System.Drawing.Text;
using System.Windows.Controls;

namespace FitYourSelf.Forms
{
    public partial class TarifBul : Form
    {
        public TarifBul()
        {
            InitializeComponent();
        }
        FitYourSelfContext db;
        int secilenID = 0;
        private void TarifBul_Load(object sender, EventArgs e)
        {
            db = new FitYourSelfContext();
            this.dgwTarifler.DefaultCellStyle.Font = new Font("Montserrat", 12);
            rchName.SelectionAlignment = HorizontalAlignment.Center;

            var sorgu = db.Recipies.ToList();
            dgwTarifler.DataSource = sorgu;
            dgwTarifler.Columns[0].Visible = false;
            dgwTarifler.Columns[2].Visible = false;
            dgwTarifler.Columns[3].Visible = false;
            dgwTarifler.Columns[4].Visible = false;
            dgwTarifler.Columns[5].Visible = false;
            dgwTarifler.DefaultCellStyle.ForeColor = Color.Black;
            dgwTarifler.Columns[1].HeaderText = "Tarif Başlığı";
            this.dgwTarifler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//sütünları grid büyüklüğüne göre oto dolduruyor.
            dgwTarifler.RowHeadersVisible = false;//datagridviewdeki küçük kutucuğu kaldırıyor.


        }


        private void dgwTarifler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenID = (int)dgwTarifler.CurrentRow.Cells[0].Value;
        }

        private void btnTarifDetayGetir1_Click(object sender, EventArgs e)
        {
            if (secilenID != 0)
            {
                Recipies recipies = db.Recipies.Find(secilenID);
                rchName.Text = (recipies.RecipiesName);
                rchName.SelectionAlignment = HorizontalAlignment.Center;
                rchMalzemeler.Text = recipies.RecipeIngredients;
                rchAciklama.Text = recipies.RecipeDetail;
            }
        }

      

      
    }
}
