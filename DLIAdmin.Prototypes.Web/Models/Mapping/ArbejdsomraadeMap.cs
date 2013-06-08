using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class ArbejdsomraadeMap : EntityTypeConfiguration<Arbejdsomraade>
    {
        public ArbejdsomraadeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Arbejdsomraadenavn)
                .HasMaxLength(50);

            this.Property(t => t.ArbejdsomraadenavnUK)
                .HasMaxLength(50);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("Arbejdsomraade");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Arbejdsomraadenavn).HasColumnName("Arbejdsomraadenavn");
            this.Property(t => t.ArbejdsomraadenavnUK).HasColumnName("ArbejdsomraadenavnUK");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
        }
    }
}
