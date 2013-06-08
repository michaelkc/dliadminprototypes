using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class PortalRegelHistMap : EntityTypeConfiguration<PortalRegelHist>
    {
        public PortalRegelHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.PortalID, t.Regelbeskrivelse, t.Regel, t.Ajourtid, t.Ajourini });

            // Properties
            this.Property(t => t.PortalID)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Regelbeskrivelse)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.Regel)
                .IsRequired()
                .HasMaxLength(3000);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("PortalRegelHist");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.PortalID).HasColumnName("PortalID");
            this.Property(t => t.Regelbeskrivelse).HasColumnName("Regelbeskrivelse");
            this.Property(t => t.Regel).HasColumnName("Regel");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
        }
    }
}
