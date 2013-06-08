using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class NulstilletPasswordMap : EntityTypeConfiguration<NulstilletPassword>
    {
        public NulstilletPasswordMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.NytPassword)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("NulstilletPassword");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BrugerID).HasColumnName("BrugerID");
            this.Property(t => t.NytPassword).HasColumnName("NytPassword");
            this.Property(t => t.NulstilletDen).HasColumnName("NulstilletDen");
            this.Property(t => t.EksporteretDen).HasColumnName("EksporteretDen");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");

            // Relationships
            this.HasRequired(t => t.Bruger)
                .WithMany(t => t.NulstilletPasswords)
                .HasForeignKey(d => d.BrugerID);

        }
    }
}
