using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class VareKoebMap : EntityTypeConfiguration<VareKoeb>
    {
        public VareKoebMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.VarekoebID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Brugerid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BestiltAf)
                .HasMaxLength(50);

            this.Property(t => t.RegnskabIdent)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VareGruppe)
                .HasMaxLength(64);

            this.Property(t => t.VareNummer)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Navn)
                .HasMaxLength(50);

            this.Property(t => t.Titel)
                .HasMaxLength(30);

            this.Property(t => t.Faktureringsnavn)
                .HasMaxLength(50);

            this.Property(t => t.Beskrivelse)
                .HasMaxLength(50);

            this.Property(t => t.Beskrivelse2)
                .HasMaxLength(50);

            this.Property(t => t.KundetypeTekst)
                .HasMaxLength(50);

            this.Property(t => t.VaretypeTekst)
                .HasMaxLength(50);

            this.Property(t => t.Ekstra1)
                .HasMaxLength(250);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("VareKoeb");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.VarekoebID).HasColumnName("VarekoebID");
            this.Property(t => t.Brugerid).HasColumnName("Brugerid");
            this.Property(t => t.AdgangTilDato).HasColumnName("AdgangTilDato");
            this.Property(t => t.BestiltAf).HasColumnName("BestiltAf");
            this.Property(t => t.NavisionIdent).HasColumnName("NavisionIdent");
            this.Property(t => t.RegnskabIdent).HasColumnName("RegnskabIdent");
            this.Property(t => t.VareGruppe).HasColumnName("VareGruppe");
            this.Property(t => t.VareNummer).HasColumnName("VareNummer");
            this.Property(t => t.Pris).HasColumnName("Pris");
            this.Property(t => t.SpecialPris).HasColumnName("SpecialPris");
            this.Property(t => t.VareAntal).HasColumnName("VareAntal");
            this.Property(t => t.Navn).HasColumnName("Navn");
            this.Property(t => t.Titel).HasColumnName("Titel");
            this.Property(t => t.AdresseID).HasColumnName("AdresseID");
            this.Property(t => t.Faktureringsnavn).HasColumnName("Faktureringsnavn");
            this.Property(t => t.FaktureringsadresseID).HasColumnName("FaktureringsadresseID");
            this.Property(t => t.Faktureringstype).HasColumnName("Faktureringstype");
            this.Property(t => t.Oprettelsesdato).HasColumnName("Oprettelsesdato");
            this.Property(t => t.Beskrivelse).HasColumnName("Beskrivelse");
            this.Property(t => t.Beskrivelse2).HasColumnName("Beskrivelse2");
            this.Property(t => t.Kundetype).HasColumnName("Kundetype");
            this.Property(t => t.KundetypeTekst).HasColumnName("KundetypeTekst");
            this.Property(t => t.Varetype).HasColumnName("Varetype");
            this.Property(t => t.VaretypeTekst).HasColumnName("VaretypeTekst");
            this.Property(t => t.Ekstra1).HasColumnName("Ekstra1");
            this.Property(t => t.Ordrenummer).HasColumnName("Ordrenummer");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Navisiontid).HasColumnName("Navisiontid");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.AbonnementID).HasColumnName("AbonnementID");
            this.Property(t => t.OverfoeretDato).HasColumnName("OverfoeretDato");

            // Relationships
            this.HasOptional(t => t.Adresse)
                .WithMany(t => t.VareKoebs)
                .HasForeignKey(d => d.AdresseID);
            this.HasOptional(t => t.Adresse1)
                .WithMany(t => t.VareKoebs1)
                .HasForeignKey(d => d.FaktureringsadresseID);

        }
    }
}
