using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class BrugerRelationMap : EntityTypeConfiguration<BrugerRelation>
    {
        public BrugerRelationMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.LogonName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("BrugerRelation");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SystemRelationID).HasColumnName("SystemRelationID");
            this.Property(t => t.LogonName).HasColumnName("LogonName");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.UserValidationLevel).HasColumnName("UserValidationLevel");

            // Relationships
            this.HasRequired(t => t.SystemRelation)
                .WithMany(t => t.BrugerRelations)
                .HasForeignKey(d => d.SystemRelationID);

        }
    }
}
