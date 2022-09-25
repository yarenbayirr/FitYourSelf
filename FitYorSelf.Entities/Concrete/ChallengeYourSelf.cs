using FitYorSelf.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYorSelf.Entities.Concrete
{
    public class ChallengeYourSelf
    {

        public ChallengeYourSelf()
        {
            GunFarki = 0;
        }
        public int ChallengeYourSelfID { get; set; }

        public DateTime DateTime { get; set; }

        public ChallengeYourSelfEnum ChallengeYourSelfEnum { get; set; }

        public int? GunFarki { get; set; }
        public DateTime EklenmeTarihi { get; set; }

        public int UserInfoID { get; set; }
        public UserInfo UserInfo { get; set; }





    }
}
