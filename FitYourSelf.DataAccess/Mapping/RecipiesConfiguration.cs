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
    public class RecipiesConfiguration:EntityTypeConfiguration<Recipies>
    {
        public RecipiesConfiguration()
        {
           this.HasKey(r => r.RecipiesID);

            this.Property(r => r.RecipiesID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            this.Property(r => r.RecipiesName)
                .HasColumnType("nvarchar")
                .HasColumnName("Tarif Başlığı")
                .HasMaxLength(250)
                .IsRequired();

            this.Property(r => r.RecipeIngredients)
                .HasColumnType("ntext")
                .HasColumnName("Tarif Malzemeleri")
                .IsRequired();

            this.Property(r => r.RecipeDetail)
                .HasColumnType("ntext")
                .HasColumnName("Tarif Detayları")
                .IsRequired();

            this.HasRequired(x => x.UserInfo)
                .WithMany(r => r.Recipies)
                .HasForeignKey(x => x.UserInfoID);
                
        }
    }
}
