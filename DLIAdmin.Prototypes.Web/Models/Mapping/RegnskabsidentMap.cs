using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class RegnskabsidentMap : EntityTypeConfiguration<Regnskabsident>
    {
        public RegnskabsidentMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Regnskabsident1)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("Regnskabsident");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Regnskabsident1).HasColumnName("Regnskabsident");
            this.Property(t => t.LokalcenterID).HasColumnName("LokalcenterID");
            this.Property(t => t.NavisionImportSekvensnr).HasColumnName("NavisionImportSekvensnr");
            this.Property(t => t.NavisionEksportSekvensnr).HasColumnName("NavisionEksportSekvensnr");
            this.Property(t => t.NavisionUdtraekstidspunkt).HasColumnName("NavisionUdtraekstidspunkt");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");

            // Relationships
            this.HasOptional(t => t.Lokalcenter)
                .WithMany(t => t.Regnskabsidents)
                .HasForeignKey(d => d.LokalcenterID);

        }
    }
}
