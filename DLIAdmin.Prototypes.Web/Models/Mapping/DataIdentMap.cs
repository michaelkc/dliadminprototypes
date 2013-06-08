using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class DataIdentMap : EntityTypeConfiguration<DataIdent>
    {
        public DataIdentMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Cvr)
                .HasMaxLength(20);

            this.Property(t => t.Value)
                .IsRequired();

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DataIdent");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DataIdentEjerID).HasColumnName("DataIdentEjerID");
            this.Property(t => t.BrugerID).HasColumnName("BrugerID");
            this.Property(t => t.Cvr).HasColumnName("Cvr");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");

            // Relationships
            this.HasOptional(t => t.Bruger)
                .WithMany(t => t.DataIdents)
                .HasForeignKey(d => d.BrugerID);
            this.HasRequired(t => t.DataIdentEjer)
                .WithMany(t => t.DataIdents)
                .HasForeignKey(d => d.DataIdentEjerID);

        }
    }
}
