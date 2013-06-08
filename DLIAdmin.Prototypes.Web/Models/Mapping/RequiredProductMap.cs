using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class RequiredProductMap : EntityTypeConfiguration<RequiredProduct>
    {
        public RequiredProductMap()
        {
            // Primary Key
            this.HasKey(t => new { t.roductID, t.RequireProductID, t.RequireADGroup });

            // Properties
            this.Property(t => t.RequireADGroup)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RequiredProduct");
            this.Property(t => t.roductID).HasColumnName("roductID");
            this.Property(t => t.RequireProductID).HasColumnName("RequireProductID");
            this.Property(t => t.RequireADGroup).HasColumnName("RequireADGroup");
        }
    }
}
