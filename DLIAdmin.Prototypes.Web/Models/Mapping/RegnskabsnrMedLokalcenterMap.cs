using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class RegnskabsnrMedLokalcenterMap : EntityTypeConfiguration<RegnskabsnrMedLokalcenter>
    {
        public RegnskabsnrMedLokalcenterMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Navn, t.Regnskabsident, t.NavisionImportSekvensnr, t.NavisionEksportSekvensnr, t.ID });

            // Properties
            this.Property(t => t.Navn)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Regnskabsident)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.NavisionImportSekvensnr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NavisionEksportSekvensnr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("RegnskabsnrMedLokalcenter");
            this.Property(t => t.Navn).HasColumnName("Navn");
            this.Property(t => t.Regnskabsident).HasColumnName("Regnskabsident");
            this.Property(t => t.NavisionImportSekvensnr).HasColumnName("NavisionImportSekvensnr");
            this.Property(t => t.NavisionEksportSekvensnr).HasColumnName("NavisionEksportSekvensnr");
            this.Property(t => t.NavisionUdtraekstidspunkt).HasColumnName("NavisionUdtraekstidspunkt");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LokalcenterID).HasColumnName("LokalcenterID");
        }
    }
}
