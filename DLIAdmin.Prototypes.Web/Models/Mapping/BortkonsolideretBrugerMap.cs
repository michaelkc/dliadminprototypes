using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class BortkonsolideretBrugerMap : EntityTypeConfiguration<BortkonsolideretBruger>
    {
        public BortkonsolideretBrugerMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.UdgaaetADLogonname)
                .HasMaxLength(50);

            this.Property(t => t.BeholdADLogonname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("BortkonsolideretBruger");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UdgaaetID).HasColumnName("UdgaaetID");
            this.Property(t => t.UdgaaetADLogonname).HasColumnName("UdgaaetADLogonname");
            this.Property(t => t.UdgaaetADIdent).HasColumnName("UdgaaetADIdent");
            this.Property(t => t.BeholdID).HasColumnName("BeholdID");
            this.Property(t => t.BeholdADLogonname).HasColumnName("BeholdADLogonname");
            this.Property(t => t.BeholdADIdent).HasColumnName("BeholdADIdent");
            this.Property(t => t.Tidspunkt).HasColumnName("Tidspunkt");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
        }
    }
}
