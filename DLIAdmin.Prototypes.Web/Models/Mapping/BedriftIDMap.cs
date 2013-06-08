using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class BedriftIDMap : EntityTypeConfiguration<BedriftID>
    {
        public BedriftIDMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BedriftID1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Navn)
                .HasMaxLength(50);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Ekstra1)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("BedriftID");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BedriftID1).HasColumnName("BedriftID");
            this.Property(t => t.Navn).HasColumnName("Navn");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.EjerID).HasColumnName("EjerID");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Ekstra1).HasColumnName("Ekstra1");

            // Relationships
            this.HasRequired(t => t.Bedrifttype)
                .WithMany(t => t.BedriftIDs)
                .HasForeignKey(d => d.TypeID);
            this.HasRequired(t => t.Bruger)
                .WithMany(t => t.BedriftIDs)
                .HasForeignKey(d => d.EjerID);

        }
    }
}
