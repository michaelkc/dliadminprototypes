using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class BrugerRelationHistMap : EntityTypeConfiguration<BrugerRelationHist>
    {
        public BrugerRelationHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.SystemRelationID, t.LogonName, t.Ajourini, t.Ajourtid, t.UserValidationLevel });

            // Properties
            this.Property(t => t.LogonName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.UserValidationLevel)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BrugerRelationHist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SystemRelationID).HasColumnName("SystemRelationID");
            this.Property(t => t.LogonName).HasColumnName("LogonName");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.UserValidationLevel).HasColumnName("UserValidationLevel");
        }
    }
}
