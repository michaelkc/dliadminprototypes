using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class SSOUserRelationKeyMap : EntityTypeConfiguration<SSOUserRelationKey>
    {
        public SSOUserRelationKeyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.LogonName, t.ADLogonname, t.TekniskNavn });

            // Properties
            this.Property(t => t.LogonName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ADLogonname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Navn)
                .HasMaxLength(150);

            this.Property(t => t.TekniskNavn)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SSOUserRelationKeys");
            this.Property(t => t.LogonName).HasColumnName("LogonName");
            this.Property(t => t.ADLogonname).HasColumnName("ADLogonname");
            this.Property(t => t.Navn).HasColumnName("Navn");
            this.Property(t => t.TekniskNavn).HasColumnName("TekniskNavn");
        }
    }
}
