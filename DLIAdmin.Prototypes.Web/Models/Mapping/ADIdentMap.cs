using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class ADIdentMap : EntityTypeConfiguration<ADIdent>
    {
        public ADIdentMap()
        {
            // Primary Key
            this.HasKey(t => t.NextADIdent);

            // Properties
            this.Property(t => t.NextADIdent)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ADIdent");
            this.Property(t => t.NextADIdent).HasColumnName("NextADIdent");
        }
    }
}
