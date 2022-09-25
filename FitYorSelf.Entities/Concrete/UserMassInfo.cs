using FitYorSelf.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYorSelf.Entities.Concrete
{
    public class UserMassInfo
    {
        public int UserMassInfoID { get; set; }
        public double UserMassHeight { get; set; }
        public double UserMassWeight { get; set; }
        public double UserMassBMI { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public BMIStatus BMIStatus { get; set; }

        public UserInfo UserInfo { get; set; }

        public int UserInfoID { get; set; }

    }
}
