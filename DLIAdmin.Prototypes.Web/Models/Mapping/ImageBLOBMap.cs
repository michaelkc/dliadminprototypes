using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class ImageBLOBMap : EntityTypeConfiguration<ImageBLOB>
    {
        public ImageBLOBMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Filename, t.BLOBData, t.Ajourtid, t.Ajourini });

            // Properties
            this.Property(t => t.Filename)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.BLOBData)
                .IsRequired();

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("ImageBLOB");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Filename).HasColumnName("Filename");
            this.Property(t => t.BLOBData).HasColumnName("BLOBData");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
        }
    }
}
