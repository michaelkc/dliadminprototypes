using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class BedrifttypeHistMap : EntityTypeConfiguration<BedrifttypeHist>
    {
        public BedrifttypeHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Ajourtid, t.Ajourini, t.Globalident });

            // Properties
            this.Property(t => t.Navn)
                .HasMaxLength(50);

            this.Property(t => t.Adgruppe)
                .HasMaxLength(50);

            this.Property(t => t.Adgruppeadm)
                .HasMaxLength(50);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("BedrifttypeHist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Navn).HasColumnName("Navn");
            this.Property(t => t.Adgruppe).HasColumnName("Adgruppe");
            this.Property(t => t.Adgruppeadm).HasColumnName("Adgruppeadm");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Globalident).HasColumnName("Globalident");
        }
    }
}
