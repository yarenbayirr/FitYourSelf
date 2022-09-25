using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYorSelf.Entities.Enums
{
    public enum BMIStatus
    {
        a=0,

        Zayıf ,

        [Display(Name="Normal Kilolu")]
        NormalKilolu,

        [Display(Name="Fazla Kilolu")]
        FazlaKilolu,

        [Display(Name="1.Derece Obezite")]
        BirinciDereceObezite,

        [Display(Name="2.Derece Obezite")]
        İkinciDereceObezite,

        [Display(Name="3.Derece Obezite")]
        ÜçüncüDereceObezite
    }
}
