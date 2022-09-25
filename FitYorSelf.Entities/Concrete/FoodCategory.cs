
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYorSelf.Entities.Concrete
{
    public class FoodCategory
    {
        public int FoodCategoryId { get; set; }
        public string CategoryName { get; set; }


        public List<Foods> Foods { get; set; }
    }
}
