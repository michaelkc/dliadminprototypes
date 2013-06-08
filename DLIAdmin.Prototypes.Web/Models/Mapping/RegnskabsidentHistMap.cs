using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class RegnskabsidentHistMap : EntityTypeConfiguration<RegnskabsidentHist>
    {
        public RegnskabsidentHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Regnskabsident, t.NavisionImportSekvensnr, t.NavisionEksportSekvensnr, t.Ajourtid, t.Ajourini });

            // Properties
            this.Property(t => t.Regnskabsident)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.NavisionImportSekvensnr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NavisionEksportSekvensnr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("RegnskabsidentHist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Regnskabsident).HasColumnName("Regnskabsident");
            this.Property(t => t.LokalcenterID).HasColumnName("LokalcenterID");
            this.Property(t => t.NavisionImportSekvensnr).HasColumnName("NavisionImportSekvensnr");
            this.Property(t => t.NavisionEksportSekvensnr).HasColumnName("NavisionEksportSekvensnr");
            this.Property(t => t.NavisionUdtraekstidspunkt).HasColumnName("NavisionUdtraekstidspunkt");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
        }
    }
}
