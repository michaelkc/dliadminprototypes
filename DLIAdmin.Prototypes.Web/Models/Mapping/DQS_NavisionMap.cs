using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class DQS_NavisionMap : EntityTypeConfiguration<DQS_Navision>
    {
        public DQS_NavisionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Vejloebenummer, t.Husnummer, t.Opgang, t.Etage, t.SideLejlighed, t.CPR, t.Fax, t.AjourtidNavision });

            // Properties
            this.Property(t => t.BrugerID)
                .HasMaxLength(50);

            this.Property(t => t.Navn)
                .HasMaxLength(50);

            this.Property(t => t.Vejnavn)
                .HasMaxLength(93);

            this.Property(t => t.Vejloebenummer)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Husnummer)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Postnummer)
                .HasMaxLength(20);

            this.Property(t => t.Bynavn)
                .HasMaxLength(30);

            this.Property(t => t.Titel)
                .HasMaxLength(30);

            this.Property(t => t.Opgang)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Etage)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.SideLejlighed)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Gaardnavn)
                .HasMaxLength(30);

            this.Property(t => t.Stednavn)
                .HasMaxLength(30);

            this.Property(t => t.Landekode)
                .HasMaxLength(10);

            this.Property(t => t.Mobil)
                .HasMaxLength(30);

            this.Property(t => t.CPR)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.CVR)
                .HasMaxLength(20);

            this.Property(t => t.EMail)
                .HasMaxLength(80);

            this.Property(t => t.Fax)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Telefon)
                .HasMaxLength(30);

            this.Property(t => t.Ajourini)
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DQS_Navision");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BrugerID).HasColumnName("BrugerID");
            this.Property(t => t.DLI_Ident).HasColumnName("DLI_Ident");
            this.Property(t => t.Navn).HasColumnName("Navn");
            this.Property(t => t.Vejnavn).HasColumnName("Vejnavn");
            this.Property(t => t.Vejloebenummer).HasColumnName("Vejloebenummer");
            this.Property(t => t.Husnummer).HasColumnName("Husnummer");
            this.Property(t => t.Postnummer).HasColumnName("Postnummer");
            this.Property(t => t.Bynavn).HasColumnName("Bynavn");
            this.Property(t => t.Titel).HasColumnName("Titel");
            this.Property(t => t.Opgang).HasColumnName("Opgang");
            this.Property(t => t.Etage).HasColumnName("Etage");
            this.Property(t => t.SideLejlighed).HasColumnName("SideLejlighed");
            this.Property(t => t.Gaardnavn).HasColumnName("Gaardnavn");
            this.Property(t => t.Stednavn).HasColumnName("Stednavn");
            this.Property(t => t.Landekode).HasColumnName("Landekode");
            this.Property(t => t.Mobil).HasColumnName("Mobil");
            this.Property(t => t.CPR).HasColumnName("CPR");
            this.Property(t => t.CVR).HasColumnName("CVR");
            this.Property(t => t.EMail).HasColumnName("EMail");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.Telefon).HasColumnName("Telefon");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.AjourtidBruger).HasColumnName("AjourtidBruger");
            this.Property(t => t.AjourtidNavision).HasColumnName("AjourtidNavision");
        }
    }
}
