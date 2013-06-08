using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class insertedxMap : EntityTypeConfiguration<insertedx>
    {
        public insertedxMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Ajourini, t.Ajourtid, t.Navisiontid });

            // Properties
            this.Property(t => t.Navn)
                .HasMaxLength(50);

            this.Property(t => t.Titel)
                .HasMaxLength(30);

            this.Property(t => t.Vejnavn)
                .HasMaxLength(50);

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

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("insertedx");
            this.Property(t => t.ID).HasColumnName("ID");
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
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Navisiontid).HasColumnName("Navisiontid");
        }
    }
}
