using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class BedriftIDRettighedLokalcenterMap : EntityTypeConfiguration<BedriftIDRettighedLokalcenter>
    {
        public BedriftIDRettighedLokalcenterMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.HarAdgang)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("BedriftIDRettighedLokalcenter");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HarAdgang).HasColumnName("HarAdgang");
            this.Property(t => t.LokalcenterID).HasColumnName("LokalcenterID");
            this.Property(t => t.BedriftID).HasColumnName("BedriftID");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");

            // Relationships
            this.HasRequired(t => t.BedriftID1)
                .WithMany(t => t.BedriftIDRettighedLokalcenters)
                .HasForeignKey(d => d.BedriftID);
            this.HasRequired(t => t.Lokalcenter)
                .WithMany(t => t.BedriftIDRettighedLokalcenters)
                .HasForeignKey(d => d.LokalcenterID);

        }
    }
}
