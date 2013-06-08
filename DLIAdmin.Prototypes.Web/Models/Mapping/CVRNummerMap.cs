using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class CVRNummerMap : EntityTypeConfiguration<CVRNummer>
    {
        public CVRNummerMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CVRNummer1)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("CVRNummer");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CVRNummer1).HasColumnName("CVRNummer");
            this.Property(t => t.BrugerID).HasColumnName("BrugerID");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");

            // Relationships
            this.HasRequired(t => t.Bruger)
                .WithMany(t => t.CVRNummers)
                .HasForeignKey(d => d.BrugerID);

        }
    }
}
