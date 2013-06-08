using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class CVRNummerHistMap : EntityTypeConfiguration<CVRNummerHist>
    {
        public CVRNummerHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.CVRNummer, t.BrugerID, t.Ajourtid, t.Ajourini });

            // Properties
            this.Property(t => t.CVRNummer)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("CVRNummerHist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CVRNummer).HasColumnName("CVRNummer");
            this.Property(t => t.BrugerID).HasColumnName("BrugerID");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
        }
    }
}
