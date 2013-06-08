using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class DataIdentEjerHistMap : EntityTypeConfiguration<DataIdentEjerHist>
    {
        public DataIdentEjerHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Navn, t.TekniskNavn, t.KortNavn, t.SystemId, t.BrugerIBruger, t.Ajourtid, t.Ajourini });

            // Properties
            this.Property(t => t.Navn)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.TekniskNavn)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.KortNavn)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.SystemId)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DataIdentEjerHist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Navn).HasColumnName("Navn");
            this.Property(t => t.TekniskNavn).HasColumnName("TekniskNavn");
            this.Property(t => t.KortNavn).HasColumnName("KortNavn");
            this.Property(t => t.SystemId).HasColumnName("SystemId");
            this.Property(t => t.BrugerIBruger).HasColumnName("BrugerIBruger");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
        }
    }
}
