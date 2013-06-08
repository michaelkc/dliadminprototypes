using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class BedrifttypeMap : EntityTypeConfiguration<Bedrifttype>
    {
        public BedrifttypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

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
            this.ToTable("Bedrifttype");
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
