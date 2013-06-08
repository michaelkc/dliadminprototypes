using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class ClaimRelationHistMap : EntityTypeConfiguration<ClaimRelationHist>
    {
        public ClaimRelationHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.ADGruppeNavn, t.ClaimValue, t.Ajourini, t.Ajourtid });

            // Properties
            this.Property(t => t.ADGruppeNavn)
                .IsRequired()
                .HasMaxLength(70);

            this.Property(t => t.ClaimValue)
                .IsRequired()
                .HasMaxLength(70);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("ClaimRelationHist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ADGruppeNavn).HasColumnName("ADGruppeNavn");
            this.Property(t => t.ClaimValue).HasColumnName("ClaimValue");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
        }
    }
}
