using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class SSOBrugerNonValidatedApplicationKeyMap : EntityTypeConfiguration<SSOBrugerNonValidatedApplicationKey>
    {
        public SSOBrugerNonValidatedApplicationKeyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ADLogonName, t.TekniskNavn, t.Value });

            // Properties
            this.Property(t => t.ADLogonName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TekniskNavn)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Value)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("SSOBrugerNonValidatedApplicationKeys");
            this.Property(t => t.ADLogonName).HasColumnName("ADLogonName");
            this.Property(t => t.TekniskNavn).HasColumnName("TekniskNavn");
            this.Property(t => t.Value).HasColumnName("Value");
        }
    }
}
