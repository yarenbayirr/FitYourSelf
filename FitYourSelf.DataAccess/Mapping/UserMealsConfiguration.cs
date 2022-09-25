using FitYorSelf.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Spatial;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYourSelf.DataAccess.Mapping
{
    public class UserMealsConfiguration : EntityTypeConfiguration<UserMeals>
    {
        public UserMealsConfiguration()
        {
            this.HasKey(x => x.UserMealsID);
            this.Property(c => c.UserMealsID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            this.Property(x => x.MealDate)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("Öğün Zamanı");

            this.Property(x => x.MealTimes)
                .HasColumnName("Öğün İsmi")
                .IsRequired();

            this.HasRequired(x => x.UserInfo)
                .WithMany(x => x.UserMeals)
                .HasForeignKey(x => x.UserInfoID);








        }
    }
}
