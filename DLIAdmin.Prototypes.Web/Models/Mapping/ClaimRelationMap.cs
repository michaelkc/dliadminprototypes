using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class ClaimRelationMap : EntityTypeConfiguration<ClaimRelation>
    {
        public ClaimRelationMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

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
            this.ToTable("ClaimRelation");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ADGruppeNavn).HasColumnName("ADGruppeNavn");
            this.Property(t => t.ClaimValue).HasColumnName("ClaimValue");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
        }
    }
}
