using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class PortalRegelMap : EntityTypeConfiguration<PortalRegel>
    {
        public PortalRegelMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

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
            this.ToTable("PortalRegel");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.PortalID).HasColumnName("PortalID");
            this.Property(t => t.Regelbeskrivelse).HasColumnName("Regelbeskrivelse");
            this.Property(t => t.Regel).HasColumnName("Regel");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
        }
    }
}
