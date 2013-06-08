using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class SENummerHistMap : EntityTypeConfiguration<SENummerHist>
    {
        public SENummerHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.SENummer, t.BrugerID, t.Ajourtid, t.Ajourini });

            // Properties
            this.Property(t => t.SENummer)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("SENummerHist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SENummer).HasColumnName("SENummer");
            this.Property(t => t.BrugerID).HasColumnName("BrugerID");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
        }
    }
}
