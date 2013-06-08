using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class BedriftIDRettighedPersonHistMap : EntityTypeConfiguration<BedriftIDRettighedPersonHist>
    {
        public BedriftIDRettighedPersonHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.HarAdgang, t.BrugerID, t.BedriftID, t.Ajourtid, t.Ajourini });

            // Properties
            this.Property(t => t.HarAdgang)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("BedriftIDRettighedPersonHist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HarAdgang).HasColumnName("HarAdgang");
            this.Property(t => t.BrugerID).HasColumnName("BrugerID");
            this.Property(t => t.BedriftID).HasColumnName("BedriftID");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
        }
    }
}
