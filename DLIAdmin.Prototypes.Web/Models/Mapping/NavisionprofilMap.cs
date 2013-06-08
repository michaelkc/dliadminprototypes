using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class NavisionprofilMap : EntityTypeConfiguration<Navisionprofil>
    {
        public NavisionprofilMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Regnskabsident)
                .HasMaxLength(10);

            this.Property(t => t.Debitornummer)
                .HasMaxLength(20);

            this.Property(t => t.Samlever)
                .HasMaxLength(30);

            this.Property(t => t.Telefon)
                .HasMaxLength(30);

            this.Property(t => t.Mobiltelefon)
                .HasMaxLength(30);

            this.Property(t => t.EMail)
                .HasMaxLength(80);

            this.Property(t => t.Foreningsnummer)
                .HasMaxLength(10);

            this.Property(t => t.Abonnentnr)
                .HasMaxLength(20);

            this.Property(t => t.Kreds)
                .HasMaxLength(4);

            this.Property(t => t.O90Nummer)
                .HasMaxLength(10);

            this.Property(t => t.CVRNummer)
                .HasMaxLength(20);

            this.Property(t => t.SENummer)
                .HasMaxLength(20);

            this.Property(t => t.Ekstra2)
                .HasMaxLength(250);

            this.Property(t => t.Ekstra3)
                .HasMaxLength(250);

            this.Property(t => t.Ekstra4)
                .HasMaxLength(250);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.CPR)
                .HasMaxLength(11);

            // Table & Column Mappings
            this.ToTable("Navisionprofil");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Regnskabsident).HasColumnName("Regnskabsident");
            this.Property(t => t.Navisionident).HasColumnName("Navisionident");
            this.Property(t => t.Debitornummer).HasColumnName("Debitornummer");
            this.Property(t => t.Samlever).HasColumnName("Samlever");
            this.Property(t => t.Telefon).HasColumnName("Telefon");
            this.Property(t => t.Mobiltelefon).HasColumnName("Mobiltelefon");
            this.Property(t => t.EMail).HasColumnName("EMail");
            this.Property(t => t.Indmeldt).HasColumnName("Indmeldt");
            this.Property(t => t.Udmeldt).HasColumnName("Udmeldt");
            this.Property(t => t.Slettet).HasColumnName("Slettet");
            this.Property(t => t.Foreningsnummer).HasColumnName("Foreningsnummer");
            this.Property(t => t.ErEllerHarVaeretMedlem).HasColumnName("ErEllerHarVaeretMedlem");
            this.Property(t => t.Medlemsstatus).HasColumnName("Medlemsstatus");
            this.Property(t => t.Blad).HasColumnName("Blad");
            this.Property(t => t.Abonnentnr).HasColumnName("Abonnentnr");
            this.Property(t => t.Kreds).HasColumnName("Kreds");
            this.Property(t => t.O90Nummer).HasColumnName("O90Nummer");
            this.Property(t => t.CVRNummer).HasColumnName("CVRNummer");
            this.Property(t => t.SENummer).HasColumnName("SENummer");
            this.Property(t => t.Ekstra2).HasColumnName("Ekstra2");
            this.Property(t => t.Ekstra3).HasColumnName("Ekstra3");
            this.Property(t => t.Ekstra4).HasColumnName("Ekstra4");
            this.Property(t => t.BrugerID).HasColumnName("BrugerID");
            this.Property(t => t.AdresseID).HasColumnName("AdresseID");
            this.Property(t => t.LeveringsadresseID).HasColumnName("LeveringsadresseID");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Navisiontid).HasColumnName("Navisiontid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.IndmelddatoDL).HasColumnName("IndmelddatoDL");
            this.Property(t => t.UdmelddatoDL).HasColumnName("UdmelddatoDL");
            this.Property(t => t.Gruppeliv).HasColumnName("Gruppeliv");
            this.Property(t => t.GruppelivAegtefaelle).HasColumnName("GruppelivAegtefaelle");
            this.Property(t => t.Foedselsdato).HasColumnName("Foedselsdato");
            this.Property(t => t.FoedselsdatoAegtefaelle).HasColumnName("FoedselsdatoAegtefaelle");
            this.Property(t => t.CPR).HasColumnName("CPR");
            this.Property(t => t.ReferenceNavisionident).HasColumnName("ReferenceNavisionident");

            // Relationships
            this.HasOptional(t => t.Adresse)
                .WithMany(t => t.Navisionprofils)
                .HasForeignKey(d => d.LeveringsadresseID);
            this.HasOptional(t => t.Adresse1)
                .WithMany(t => t.Navisionprofils1)
                .HasForeignKey(d => d.AdresseID);
            this.HasOptional(t => t.Bruger)
                .WithMany(t => t.Navisionprofils)
                .HasForeignKey(d => d.BrugerID);

        }
    }
}
