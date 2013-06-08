using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class ButikHistMap : EntityTypeConfiguration<ButikHist>
    {
        public ButikHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Butiknr, t.Teknisknavn, t.UrlTilBetingelser, t.Ajourini, t.Ajourtid });

            // Properties
            this.Property(t => t.Butiknr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Teknisknavn)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UrlTilBetingelser)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("ButikHist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Butiknr).HasColumnName("Butiknr");
            this.Property(t => t.Teknisknavn).HasColumnName("Teknisknavn");
            this.Property(t => t.UrlTilBetingelser).HasColumnName("UrlTilBetingelser");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
        }
    }
}
