using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class DQS_EksternMap : EntityTypeConfiguration<DQS_Ekstern>
    {
        public DQS_EksternMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BrugerID)
                .HasMaxLength(50);

            this.Property(t => t.Navn)
                .HasMaxLength(30);

            this.Property(t => t.Titel)
                .HasMaxLength(30);

            this.Property(t => t.Vejnavn)
                .HasMaxLength(30);

            this.Property(t => t.Opgang)
                .HasMaxLength(3);

            this.Property(t => t.Etage)
                .HasMaxLength(2);

            this.Property(t => t.SideLejlighed)
                .HasMaxLength(4);

            this.Property(t => t.Gaardnavn)
                .HasMaxLength(30);

            this.Property(t => t.Stednavn)
                .HasMaxLength(30);

            this.Property(t => t.Postnummer)
                .HasMaxLength(20);

            this.Property(t => t.Bynavn)
                .HasMaxLength(30);

            this.Property(t => t.Landekode)
                .HasMaxLength(10);

            this.Property(t => t.Mobil)
                .HasMaxLength(30);

            this.Property(t => t.CPR)
                .HasMaxLength(11);

            this.Property(t => t.CVR)
                .HasMaxLength(20);

            this.Property(t => t.Email)
                .HasMaxLength(256);

            this.Property(t => t.Fax)
                .HasMaxLength(30);

            this.Property(t => t.Telefon)
                .HasMaxLength(30);

            this.Property(t => t.System)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BrugerID_Ekstern)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DQS_Ekstern");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BrugerID).HasColumnName("BrugerID");
            this.Property(t => t.Navn).HasColumnName("Navn");
            this.Property(t => t.Titel).HasColumnName("Titel");
            this.Property(t => t.Vejnavn).HasColumnName("Vejnavn");
            this.Property(t => t.Vejloebenummer).HasColumnName("Vejloebenummer");
            this.Property(t => t.Husnummer).HasColumnName("Husnummer");
            this.Property(t => t.Opgang).HasColumnName("Opgang");
            this.Property(t => t.Etage).HasColumnName("Etage");
            this.Property(t => t.SideLejlighed).HasColumnName("SideLejlighed");
            this.Property(t => t.Gaardnavn).HasColumnName("Gaardnavn");
            this.Property(t => t.Stednavn).HasColumnName("Stednavn");
            this.Property(t => t.Postnummer).HasColumnName("Postnummer");
            this.Property(t => t.Bynavn).HasColumnName("Bynavn");
            this.Property(t => t.Landekode).HasColumnName("Landekode");
            this.Property(t => t.Mobil).HasColumnName("Mobil");
            this.Property(t => t.CPR).HasColumnName("CPR");
            this.Property(t => t.CVR).HasColumnName("CVR");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.Telefon).HasColumnName("Telefon");
            this.Property(t => t.System).HasColumnName("System");
            this.Property(t => t.BrugerID_Ekstern).HasColumnName("BrugerID_Ekstern");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
        }
    }
}
