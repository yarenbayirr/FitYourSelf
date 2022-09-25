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
    public class WaterConfiguration : EntityTypeConfiguration<Water>

    {
        public WaterConfiguration()
        {
            this.HasKey(x => x.WaterID);
            this.Property(x => x.WaterID)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            this.Property(x => x.WaterAmount)
                .HasColumnName("İçilen Su Miktarı")
                .IsOptional();
            this.Property(x => x.GlassOfWater)
                .HasColumnName("İçilen Bardak")
                .HasColumnType("int")
                .IsRequired();
            this.Property(x => x.DateTime).HasColumnName("Su İçilen Zaman")
                .HasColumnType("datetime")
                .IsRequired();

          

            this.HasRequired(x => x.UserInfo)
              .WithMany(x => x.Water)
              .HasForeignKey(x => x.UserInfoID);

        }
    }
}
