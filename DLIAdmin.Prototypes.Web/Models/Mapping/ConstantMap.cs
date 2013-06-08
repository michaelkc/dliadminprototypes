using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class ConstantMap : EntityTypeConfiguration<Constant>
    {
        public ConstantMap()
        {
            // Primary Key
            this.HasKey(t => t.KeyName);

            // Properties
            this.Property(t => t.KeyName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("Constant");
            this.Property(t => t.KeyName).HasColumnName("KeyName");
            this.Property(t => t.KeyValue).HasColumnName("KeyValue");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
