using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class DataIdentHistMap : EntityTypeConfiguration<DataIdentHist>
    {
        public DataIdentHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.DataIdentEjerID, t.Value, t.Ajourtid, t.Ajourini });

            // Properties
            this.Property(t => t.Cvr)
                .HasMaxLength(20);

            this.Property(t => t.Value)
                .IsRequired();

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DataIdentHist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DataIdentEjerID).HasColumnName("DataIdentEjerID");
            this.Property(t => t.BrugerID).HasColumnName("BrugerID");
            this.Property(t => t.Cvr).HasColumnName("Cvr");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
        }
    }
}
