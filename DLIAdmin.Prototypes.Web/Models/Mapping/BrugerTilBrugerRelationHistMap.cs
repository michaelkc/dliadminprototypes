using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class BrugerTilBrugerRelationHistMap : EntityTypeConfiguration<BrugerTilBrugerRelationHist>
    {
        public BrugerTilBrugerRelationHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.BrugerID, t.BrugerRelationID, t.Ajourini, t.Ajourtid });

            // Properties
            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("BrugerTilBrugerRelationHist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BrugerID).HasColumnName("BrugerID");
            this.Property(t => t.BrugerRelationID).HasColumnName("BrugerRelationID");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
        }
    }
}
