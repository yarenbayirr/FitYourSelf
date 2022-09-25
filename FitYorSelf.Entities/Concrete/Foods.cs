
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYorSelf.Entities.Concrete
{
    public class Foods
    {
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public double Calorie { get; set; }
        public double Fat { get; set; }
        public double Carbonhidrate { get; set; }
        public double Protein { get; set; }
        public string Description { get; set; }


        public int FoodCategoryID { get; set; }
        public FoodCategory FoodCategory { get; set; }

        public List<UserMeals> UserMeals { get; set; }




    }
}
