using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class CVRValideringerHistMap : EntityTypeConfiguration<CVRValideringerHist>
    {
        public CVRValideringerHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.ADLogonName, t.BrugerID, t.Type, t.Modtager, t.Forsendelse, t.Antal, t.Forespoergselsdato, t.Autoritet });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ADLogonName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Modtager)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Forsendelse)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Antal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Autoritet)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("CVRValideringerHist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ADLogonName).HasColumnName("ADLogonName");
            this.Property(t => t.BrugerID).HasColumnName("BrugerID");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Modtager).HasColumnName("Modtager");
            this.Property(t => t.Forsendelse).HasColumnName("Forsendelse");
            this.Property(t => t.Antal).HasColumnName("Antal");
            this.Property(t => t.Forespoergselsdato).HasColumnName("Forespoergselsdato");
            this.Property(t => t.Autoritet).HasColumnName("Autoritet");
            this.Property(t => t.Udsendelsesdato).HasColumnName("Udsendelsesdato");
        }
    }
}
