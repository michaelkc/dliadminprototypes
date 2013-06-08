using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class BrugerIBrugerMap : EntityTypeConfiguration<BrugerIBruger>
    {
        public BrugerIBrugerMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("BrugerIBruger");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BrugerID).HasColumnName("BrugerID");
            this.Property(t => t.PaaVegneAfBrugerID).HasColumnName("PaaVegneAfBrugerID");
            this.Property(t => t.DataIdentEjerID).HasColumnName("DataIdentEjerID");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");

            // Relationships
            this.HasRequired(t => t.Bruger)
                .WithMany(t => t.BrugerIBrugers)
                .HasForeignKey(d => d.BrugerID);
            this.HasRequired(t => t.Bruger1)
                .WithMany(t => t.BrugerIBrugers1)
                .HasForeignKey(d => d.PaaVegneAfBrugerID);
            this.HasRequired(t => t.DataIdentEjer)
                .WithMany(t => t.BrugerIBrugers)
                .HasForeignKey(d => d.DataIdentEjerID);

        }
    }
}
