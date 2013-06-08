using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class LokalcenterHistMap : EntityTypeConfiguration<LokalcenterHist>
    {
        public LokalcenterHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Navn, t.Centernummer, t.Ajourtid, t.Ajourini });

            // Properties
            this.Property(t => t.Navn)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Koordinat1)
                .HasMaxLength(3);

            this.Property(t => t.Centernummer)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("LokalcenterHist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Navn).HasColumnName("Navn");
            this.Property(t => t.Koordinat1).HasColumnName("Koordinat1");
            this.Property(t => t.Koordinat2).HasColumnName("Koordinat2");
            this.Property(t => t.Koordinat3).HasColumnName("Koordinat3");
            this.Property(t => t.Centernummer).HasColumnName("Centernummer");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
        }
    }
}
