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
    public class UserInfoConfiguration:EntityTypeConfiguration<UserInfo>
    {
        public UserInfoConfiguration()
        {
            this.HasKey(x => x.UserInfoID);

            this.Property(x => x.UserInfoID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();


            this.Property(x => x.UserName)
                .HasColumnName("Kullanıcı Adı")
                .HasColumnType("nvarchar")
                .HasMaxLength(18)               
                .IsRequired();

            this.Property(x => x.Height)                
                .HasColumnName("Boy")
                .IsOptional();

            this.Property(x=>x.Weight)                
                .HasColumnName("Kilo")
                .IsOptional();

            this.Property(x => x.WaterAmount)
                  .IsOptional();

            this.Property(x => x.BodyMassIndex)
                .HasColumnName("Vücut Kitle İndeksi");


            this.Property(x => x.Email)
               .HasColumnType("nvarchar")
               .IsRequired();

            this.Property(x => x.Password)
                .HasColumnType("nvarchar")
                .HasColumnName("Şifre")
                .IsRequired();

            this.Property(x => x.BMIStatus);

            this.Property(x => x.DailyCalorie)
                .IsOptional();
            this.Property(x => x.RequiredCalorie)
                .IsOptional();         


            this.HasMany(x => x.UserMeals)
            .WithRequired(x => x.UserInfo)
            .HasForeignKey(x => x.UserInfoID);

            this.HasMany(x => x.Water)
           .WithRequired(x => x.UserInfo)
           .HasForeignKey(x => x.UserInfoID);

            this.HasMany(x => x.Recipies)
           .WithRequired(x => x.UserInfo)
           .HasForeignKey(x => x.UserInfoID);

            this.HasMany(x => x.ChallengeYourSelf)
           .WithRequired(x => x.UserInfo)
           .HasForeignKey(x => x.UserInfoID);

            this.HasMany(x => x.UserMassInfo)
                       .WithRequired(x => x.UserInfo)
                       .HasForeignKey(x => x.UserInfoID);





        }


    }
}
