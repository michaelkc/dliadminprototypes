using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class SSOBrugerCvrValidatedApplicationKeyMap : EntityTypeConfiguration<SSOBrugerCvrValidatedApplicationKey>
    {
        public SSOBrugerCvrValidatedApplicationKeyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ADLogonname, t.TekniskNavn, t.Value, t.SenesteDataLeverandoer, t.Mastervedligehold });

            // Properties
            this.Property(t => t.ADLogonname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TekniskNavn)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Value)
                .IsRequired();

            this.Property(t => t.SenesteDataLeverandoer)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Mastervedligehold)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SSOBrugerCvrValidatedApplicationKeys");
            this.Property(t => t.ADLogonname).HasColumnName("ADLogonname");
            this.Property(t => t.TekniskNavn).HasColumnName("TekniskNavn");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.SenesteDataLeverandoer).HasColumnName("SenesteDataLeverandoer");
            this.Property(t => t.Mastervedligehold).HasColumnName("Mastervedligehold");
        }
    }
}
