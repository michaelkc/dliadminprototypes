using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class ArbejdsomraadeHistMap : EntityTypeConfiguration<ArbejdsomraadeHist>
    {
        public ArbejdsomraadeHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Ajourtid, t.Ajourini });

            // Properties
            this.Property(t => t.Arbejdsomraadenavn)
                .HasMaxLength(50);

            this.Property(t => t.ArbejdsomraadenavnUK)
                .HasMaxLength(50);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("ArbejdsomraadeHist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Arbejdsomraadenavn).HasColumnName("Arbejdsomraadenavn");
            this.Property(t => t.ArbejdsomraadenavnUK).HasColumnName("ArbejdsomraadenavnUK");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
        }
    }
}
