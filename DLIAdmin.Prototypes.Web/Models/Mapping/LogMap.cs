using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class LogMap : EntityTypeConfiguration<Log>
    {
        public LogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.UdfoertAfIni)
                .HasMaxLength(32);

            this.Property(t => t.UdfoertPaaIni)
                .HasMaxLength(32);

            this.Property(t => t.UdfoertPaaMaskine)
                .HasMaxLength(50);

            this.Property(t => t.UdfoertPaaGruppe)
                .HasMaxLength(70);

            this.Property(t => t.HandlingText)
                .HasMaxLength(1000);

            this.Property(t => t.Detalje)
                .HasMaxLength(1000);

            this.Property(t => t.Note)
                .HasMaxLength(500);

            this.Property(t => t.Ajourini)
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("Log");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UdfoertAfIni).HasColumnName("UdfoertAfIni");
            this.Property(t => t.UdfoertPaaIni).HasColumnName("UdfoertPaaIni");
            this.Property(t => t.UdfoertPaaMaskine).HasColumnName("UdfoertPaaMaskine");
            this.Property(t => t.UdfoertPaaGruppe).HasColumnName("UdfoertPaaGruppe");
            this.Property(t => t.UdfoertTid).HasColumnName("UdfoertTid");
            this.Property(t => t.HandlingText).HasColumnName("HandlingText");
            this.Property(t => t.UdfoertAfSystem).HasColumnName("UdfoertAfSystem");
            this.Property(t => t.LogGruppering).HasColumnName("LogGruppering");
            this.Property(t => t.LogGrupperingSekvens).HasColumnName("LogGrupperingSekvens");
            this.Property(t => t.LogVigtighed).HasColumnName("LogVigtighed");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Detalje).HasColumnName("Detalje");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
        }
    }
}
