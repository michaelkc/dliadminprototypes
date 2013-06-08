using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class ConstantHistMap : EntityTypeConfiguration<ConstantHist>
    {
        public ConstantHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.KeyName, t.Ajourtid, t.Ajourini, t.ID });

            // Properties
            this.Property(t => t.KeyName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("ConstantHist");
            this.Property(t => t.KeyName).HasColumnName("KeyName");
            this.Property(t => t.KeyValue).HasColumnName("KeyValue");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
