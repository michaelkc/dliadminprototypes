using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class SENummerMap : EntityTypeConfiguration<SENummer>
    {
        public SENummerMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.SENummer1)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("SENummer");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SENummer1).HasColumnName("SENummer");
            this.Property(t => t.BrugerID).HasColumnName("BrugerID");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");

            // Relationships
            this.HasRequired(t => t.Bruger)
                .WithMany(t => t.SENummers)
                .HasForeignKey(d => d.BrugerID);

        }
    }
}
