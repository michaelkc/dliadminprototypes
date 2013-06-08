using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class Bruger_med_NavisionprofilMap : EntityTypeConfiguration<Bruger_med_Navisionprofil>
    {
        public Bruger_med_NavisionprofilMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ADLogonname, t.ADIdent });

            // Properties
            this.Property(t => t.ADLogonname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ADIdent)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Regnskabsident)
                .HasMaxLength(10);

            this.Property(t => t.Navn)
                .HasMaxLength(30);

            this.Property(t => t.Vejnavn)
                .HasMaxLength(30);

            this.Property(t => t.Postnummer)
                .HasMaxLength(20);

            this.Property(t => t.Bynavn)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Bruger med Navisionprofil");
            this.Property(t => t.ADLogonname).HasColumnName("ADLogonname");
            this.Property(t => t.ADIdent).HasColumnName("ADIdent");
            this.Property(t => t.Regnskabsident).HasColumnName("Regnskabsident");
            this.Property(t => t.Navisionident).HasColumnName("Navisionident");
            this.Property(t => t.Navn).HasColumnName("Navn");
            this.Property(t => t.Vejnavn).HasColumnName("Vejnavn");
            this.Property(t => t.Husnummer).HasColumnName("Husnummer");
            this.Property(t => t.Postnummer).HasColumnName("Postnummer");
            this.Property(t => t.Bynavn).HasColumnName("Bynavn");
            this.Property(t => t.Medlemsstatus).HasColumnName("Medlemsstatus");
        }
    }
}
