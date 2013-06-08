using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class AbonnementHistMap : EntityTypeConfiguration<AbonnementHist>
    {
        public AbonnementHistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.OprettelsesDato, t.VareID, t.BrugerID, t.SidstFaktureretDato, t.Ajourtid, t.Ajourini, t.Note, t.Status });

            // Properties
            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Note)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AbonnementHist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Startdato).HasColumnName("Startdato");
            this.Property(t => t.Slutdato).HasColumnName("Slutdato");
            this.Property(t => t.OprettelsesDato).HasColumnName("OprettelsesDato");
            this.Property(t => t.VareID).HasColumnName("VareID");
            this.Property(t => t.BrugerID).HasColumnName("BrugerID");
            this.Property(t => t.DataejerID).HasColumnName("DataejerID");
            this.Property(t => t.BestillerID).HasColumnName("BestillerID");
            this.Property(t => t.SidstFaktureretDato).HasColumnName("SidstFaktureretDato");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
