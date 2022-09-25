using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYorSelf.Entities.Concrete
{
    public class Recipies
    {
        public int RecipiesID { get; set; }
        public string RecipiesName { get; set; }
        public string RecipeIngredients { get; set; }
        public string RecipeDetail { get; set; }


        public int UserInfoID { get; set; }
        public UserInfo UserInfo { get; set; }
        



    }
}
