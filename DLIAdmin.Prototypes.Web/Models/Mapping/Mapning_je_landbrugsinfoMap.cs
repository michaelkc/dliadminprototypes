using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class Mapning_je_landbrugsinfoMap : EntityTypeConfiguration<Mapning_je_landbrugsinfo>
    {
        public Mapning_je_landbrugsinfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ADLogonname, t.TekniskNavn, t.LogonName, t.BTBajourini, t.BTBajourtid, t.Brugerrelationajourini, t.Brugerrelationajourtid });

            // Properties
            this.Property(t => t.ADLogonname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TekniskNavn)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Navn)
                .HasMaxLength(150);

            this.Property(t => t.LogonName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BTBajourini)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Brugerrelationajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("Mapning je landbrugsinfo");
            this.Property(t => t.ADLogonname).HasColumnName("ADLogonname");
            this.Property(t => t.TekniskNavn).HasColumnName("TekniskNavn");
            this.Property(t => t.Navn).HasColumnName("Navn");
            this.Property(t => t.LogonName).HasColumnName("LogonName");
            this.Property(t => t.BTBajourini).HasColumnName("BTBajourini");
            this.Property(t => t.BTBajourtid).HasColumnName("BTBajourtid");
            this.Property(t => t.Brugerrelationajourini).HasColumnName("Brugerrelationajourini");
            this.Property(t => t.Brugerrelationajourtid).HasColumnName("Brugerrelationajourtid");
        }
    }
}
