using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class AbonnementMap : EntityTypeConfiguration<Abonnement>
    {
        public AbonnementMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Note)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Abonnement");
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

            // Relationships
            this.HasRequired(t => t.Vare)
                .WithMany(t => t.Abonnements)
                .HasForeignKey(d => d.VareID);

        }
    }
}
