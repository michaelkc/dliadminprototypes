using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class SSOBrugerIBrugerMap : EntityTypeConfiguration<SSOBrugerIBruger>
    {
        public SSOBrugerIBrugerMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BrugerADLogonname, t.MaaAgereI, t.PaaVegneAfADLogonName });

            // Properties
            this.Property(t => t.BrugerADLogonname)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.MaaAgereI)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.PaaVegneAfADLogonName)
                .IsRequired()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("SSOBrugerIBruger");
            this.Property(t => t.BrugerADLogonname).HasColumnName("BrugerADLogonname");
            this.Property(t => t.MaaAgereI).HasColumnName("MaaAgereI");
            this.Property(t => t.PaaVegneAfADLogonName).HasColumnName("PaaVegneAfADLogonName");
        }
    }
}
