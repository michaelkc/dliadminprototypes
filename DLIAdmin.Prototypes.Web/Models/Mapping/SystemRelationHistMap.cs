using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class SystemRelationHistMap : EntityTypeConfiguration<SystemRelationHist>
    {
        public SystemRelationHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.TekniskNavn, t.Ajourini, t.Ajourtid });

            // Properties
            this.Property(t => t.TekniskNavn)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Navn)
                .HasMaxLength(150);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("SystemRelationHist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TekniskNavn).HasColumnName("TekniskNavn");
            this.Property(t => t.Navn).HasColumnName("Navn");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
        }
    }
}
