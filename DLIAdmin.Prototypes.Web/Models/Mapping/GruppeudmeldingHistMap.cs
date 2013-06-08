using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class GruppeudmeldingHistMap : EntityTypeConfiguration<GruppeudmeldingHist>
    {
        public GruppeudmeldingHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.FjernFraGruppe, t.UdlobsDato, t.EmailTo, t.EmailCC, t.EmailSubject, t.EmailBody, t.EmailFrom, t.Status, t.BrugerID, t.Ajourtid, t.Ajourini, t.ActionKode });

            // Properties
            this.Property(t => t.FjernFraGruppe)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EmailTo)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.EmailCC)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.EmailSubject)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.EmailBody)
                .IsRequired()
                .HasMaxLength(1024);

            this.Property(t => t.EmailFrom)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.Status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.ActionKode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("GruppeudmeldingHist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FjernFraGruppe).HasColumnName("FjernFraGruppe");
            this.Property(t => t.UdlobsDato).HasColumnName("UdlobsDato");
            this.Property(t => t.EmailTo).HasColumnName("EmailTo");
            this.Property(t => t.EmailCC).HasColumnName("EmailCC");
            this.Property(t => t.EmailSubject).HasColumnName("EmailSubject");
            this.Property(t => t.EmailBody).HasColumnName("EmailBody");
            this.Property(t => t.EmailFrom).HasColumnName("EmailFrom");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.BrugerID).HasColumnName("BrugerID");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.ActionKode).HasColumnName("ActionKode");
        }
    }
}
