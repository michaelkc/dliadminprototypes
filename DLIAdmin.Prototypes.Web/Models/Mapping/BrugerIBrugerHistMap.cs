using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class BrugerIBrugerHistMap : EntityTypeConfiguration<BrugerIBrugerHist>
    {
        public BrugerIBrugerHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.BrugerID, t.PaaVegneAfBrugerID, t.DataIdentEjerID, t.Ajourtid, t.Ajourini });

            // Properties
            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("BrugerIBrugerHist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BrugerID).HasColumnName("BrugerID");
            this.Property(t => t.PaaVegneAfBrugerID).HasColumnName("PaaVegneAfBrugerID");
            this.Property(t => t.DataIdentEjerID).HasColumnName("DataIdentEjerID");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
        }
    }
}
