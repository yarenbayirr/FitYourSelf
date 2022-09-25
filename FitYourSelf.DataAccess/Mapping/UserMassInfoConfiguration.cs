using FitYorSelf.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYourSelf.DataAccess.Mapping
{
    public class UserMassInfoConfiguration : EntityTypeConfiguration<UserMassInfo>
    {
        public UserMassInfoConfiguration()
        {
            this.HasKey(x => x.UserMassInfoID);
            this.Property(x => x.UserMassInfoID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(x => x.UserMassWeight).IsRequired();
            this.Property(x => x.UserMassHeight).IsRequired();
            this.Property(x => x.UserMassBMI).IsRequired();
            this.Property(x => x.BMIStatus).IsRequired();
            this.Property(x => x.DateTime).IsRequired();

            this.HasRequired(u => u.UserInfo)
                .WithMany(s => s.UserMassInfo)
                .HasForeignKey(u => u.UserInfoID);

        }
    }
}
