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
    public class FoodsConfiguration : EntityTypeConfiguration<Foods>
    {
        public FoodsConfiguration()
        {
            this.HasKey(f => f.FoodID);

            this.Property(f => f.FoodID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            this.Property(f => f.FoodName)
                .HasColumnType("nvarchar")
                .HasColumnName("Yiyecek İsmi")
                .HasMaxLength(100)
                .IsRequired();

            this.Property(f => f.Calorie)
                .HasColumnName("Kalori")
                .IsRequired();

            this.Property(f => f.Carbonhidrate)                
                .HasColumnName("Karbonhidrat")
                .IsRequired();


            this.Property(f => f.Protein)                
                .HasColumnName("Protein")
                .IsRequired();

            this.Property(f => f.Fat)                
                .HasColumnName("Yağ")
                .IsRequired();

            this.Property(f => f.Description)
             .HasColumnName("Açıklama")
             .IsOptional();

            //bir yemeğin bir kategorisi olur bireçokun biri 

            this.HasRequired(f => f.FoodCategory)
                .WithMany(fc => fc.Foods)          //bir kategorinin bir çok yemeği olabilir
                .HasForeignKey(f => f.FoodCategoryID);


            this.HasMany(x => x.UserMeals)
                .WithMany(x => x.Foods)
                .Map(x =>
                {
                    x.MapLeftKey("UserMealsID");
                    x.MapRightKey("FoodsID");
                    x.ToTable("UserMealsAndFoods");
                });







        }
    }
}
