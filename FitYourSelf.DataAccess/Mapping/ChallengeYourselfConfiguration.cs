using FitYorSelf.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace FitYourSelf.DataAccess.Mapping
{
    public class ChallengeYourselfConfiguration : EntityTypeConfiguration<ChallengeYourSelf>
    {
        public ChallengeYourselfConfiguration()
        {
            this.HasKey(c => c.ChallengeYourSelfID);
            this.Property(c => c.ChallengeYourSelfID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            this.Property(c => c.DateTime)
                .HasColumnType("datetime2").IsRequired()
                .HasColumnName("Meydan Okuma Başlangıcı");

            this.Property(c => c.ChallengeYourSelfEnum)
                .HasColumnName("Meydan Okumalar")
                .IsRequired();

            this.HasRequired(u => u.UserInfo)
                .WithMany(s => s.ChallengeYourSelf)
                .HasForeignKey(u => u.UserInfoID);
        }
    }
}
