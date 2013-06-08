using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class BedriftIDRettighedPersonMap : EntityTypeConfiguration<BedriftIDRettighedPerson>
    {
        public BedriftIDRettighedPersonMap()
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
            this.ToTable("BedriftIDRettighedPerson");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HarAdgang).HasColumnName("HarAdgang");
            this.Property(t => t.BrugerID).HasColumnName("BrugerID");
            this.Property(t => t.BedriftID).HasColumnName("BedriftID");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");

            // Relationships
            this.HasRequired(t => t.BedriftID1)
                .WithMany(t => t.BedriftIDRettighedPersons)
                .HasForeignKey(d => d.BedriftID);
            this.HasRequired(t => t.Bruger)
                .WithMany(t => t.BedriftIDRettighedPersons)
                .HasForeignKey(d => d.BrugerID);

        }
    }
}
