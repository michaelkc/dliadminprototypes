using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.ADGroupname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Productno)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Accountingid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("Product");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ADGroupname).HasColumnName("ADGroupname");
            this.Property(t => t.Productno).HasColumnName("Productno");
            this.Property(t => t.Accountingid).HasColumnName("Accountingid");
            this.Property(t => t.Payer).HasColumnName("Payer");
            this.Property(t => t.NoDaysAccess).HasColumnName("NoDaysAccess");
            this.Property(t => t.CannotResubscribeWithinNoDays).HasColumnName("CannotResubscribeWithinNoDays");
            this.Property(t => t.ReuseSubscriptionWithinNoDays).HasColumnName("ReuseSubscriptionWithinNoDays");
            this.Property(t => t.StartPrice).HasColumnName("StartPrice");
            this.Property(t => t.SubscriptionPrice).HasColumnName("SubscriptionPrice");
            this.Property(t => t.SubscriptionPeriod).HasColumnName("SubscriptionPeriod");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
        }
    }
}
