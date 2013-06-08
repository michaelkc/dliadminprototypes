using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class SSOBrugerMap : EntityTypeConfiguration<SSOBruger>
    {
        public SSOBrugerMap()
        {
            // Primary Key
            this.HasKey(t => t.ADLogonname);

            // Properties
            this.Property(t => t.ADLogonname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Kodeord)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("SSOBruger");
            this.Property(t => t.ADLogonname).HasColumnName("ADLogonname");
            this.Property(t => t.Kodeord).HasColumnName("Kodeord");
        }
    }
}
