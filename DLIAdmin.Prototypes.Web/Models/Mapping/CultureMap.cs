using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class CultureMap : EntityTypeConfiguration<Culture>
    {
        public CultureMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Land)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.CultureKey)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("Culture");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Land).HasColumnName("Land");
            this.Property(t => t.CultureKey).HasColumnName("CultureKey");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
        }
    }
}
