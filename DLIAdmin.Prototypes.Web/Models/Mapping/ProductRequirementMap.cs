using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class ProductRequirementMap : EntityTypeConfiguration<ProductRequirement>
    {
        public ProductRequirementMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RequiredADGroupname)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductRequirement");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.RequiredProductID).HasColumnName("RequiredProductID");
            this.Property(t => t.RequiredADGroupname).HasColumnName("RequiredADGroupname");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductRequirements)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.Product1)
                .WithMany(t => t.ProductRequirements1)
                .HasForeignKey(d => d.RequiredProductID);

        }
    }
}
