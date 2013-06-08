using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class SubscriptionMap : EntityTypeConfiguration<Subscription>
    {
        public SubscriptionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("Subscription");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Startdate).HasColumnName("Startdate");
            this.Property(t => t.Enddate).HasColumnName("Enddate");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.DataownerID).HasColumnName("DataownerID");
            this.Property(t => t.OrdererID).HasColumnName("OrdererID");
            this.Property(t => t.LastInvoiceDate).HasColumnName("LastInvoiceDate");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");

            // Relationships
            this.HasOptional(t => t.Bruger)
                .WithMany(t => t.Subscriptions)
                .HasForeignKey(d => d.OrdererID);
            this.HasRequired(t => t.Bruger1)
                .WithMany(t => t.Subscriptions1)
                .HasForeignKey(d => d.UserID);
            this.HasOptional(t => t.Bruger2)
                .WithMany(t => t.Subscriptions2)
                .HasForeignKey(d => d.DataownerID);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.Subscriptions)
                .HasForeignKey(d => d.ProductID);

        }
    }
}
