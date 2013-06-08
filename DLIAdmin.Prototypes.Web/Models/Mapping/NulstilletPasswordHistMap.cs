using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class NulstilletPasswordHistMap : EntityTypeConfiguration<NulstilletPasswordHist>
    {
        public NulstilletPasswordHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.BrugerID, t.NytPassword, t.NulstilletDen, t.Ajourini, t.Ajourtid });

            // Properties
            this.Property(t => t.NytPassword)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("NulstilletPasswordHist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BrugerID).HasColumnName("BrugerID");
            this.Property(t => t.NytPassword).HasColumnName("NytPassword");
            this.Property(t => t.NulstilletDen).HasColumnName("NulstilletDen");
            this.Property(t => t.EksporteretDen).HasColumnName("EksporteretDen");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
        }
    }
}
