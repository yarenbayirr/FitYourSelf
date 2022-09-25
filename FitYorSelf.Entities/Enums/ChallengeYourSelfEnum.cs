using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYorSelf.Entities.Enums
{
    public enum ChallengeYourSelfEnum
    {
        [Display(Name = "Şeker Yok")]
        ŞekerYok=1,
        [Display(Name = "Gluten Yok")]
        GlutenYok,

        Egzersiz,

        [Display(Name = "Su İç")]
        Suİç,

        [Display(Name = "Kahveyi Azalt")]
        KahveyiAzalt



    }
}
