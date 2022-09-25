using FitYorSelf.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYorSelf.Entities.Concrete
{
    public class UserMeals
    {
        public int UserMealsID { get; set; }

        public DateTime MealDate { get; set; } = DateTime.Now;
        public MealTimes MealTimes { get; set; }

        public string FoodName { get; set; }
        public double Calorie { get; set; }
        public double Fat { get; set; }
        public double Carbonhidrate { get; set; }
        public double Protein { get; set; }
        public double Portion { get; set; }



        public UserInfo UserInfo { get; set; }
        public int UserInfoID { get; set; }


        public List<Foods> Foods { get; set; }






    }
}
