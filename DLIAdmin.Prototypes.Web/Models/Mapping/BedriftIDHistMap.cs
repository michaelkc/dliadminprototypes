using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class BedriftIDHistMap : EntityTypeConfiguration<BedriftIDHist>
    {
        public BedriftIDHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.BedriftID, t.TypeID, t.EjerID, t.Ajourtid, t.Ajourini });

            // Properties
            this.Property(t => t.BedriftID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Navn)
                .HasMaxLength(50);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Ekstra1)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("BedriftIDHist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BedriftID).HasColumnName("BedriftID");
            this.Property(t => t.Navn).HasColumnName("Navn");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.EjerID).HasColumnName("EjerID");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Ekstra1).HasColumnName("Ekstra1");
        }
    }
}
