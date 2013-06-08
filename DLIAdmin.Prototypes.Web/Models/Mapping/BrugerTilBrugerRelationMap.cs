using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class BrugerTilBrugerRelationMap : EntityTypeConfiguration<BrugerTilBrugerRelation>
    {
        public BrugerTilBrugerRelationMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("BrugerTilBrugerRelation");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BrugerID).HasColumnName("BrugerID");
            this.Property(t => t.BrugerRelationID).HasColumnName("BrugerRelationID");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");

            // Relationships
            this.HasRequired(t => t.Bruger)
                .WithMany(t => t.BrugerTilBrugerRelations)
                .HasForeignKey(d => d.BrugerID);
            this.HasRequired(t => t.BrugerRelation)
                .WithMany(t => t.BrugerTilBrugerRelations)
                .HasForeignKey(d => d.BrugerRelationID);

        }
    }
}
