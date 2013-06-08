using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class EmailSkabelonMap : EntityTypeConfiguration<EmailSkabelon>
    {
        public EmailSkabelonMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.From)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CC)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BCC)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Subject)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Body)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("EmailSkabelon");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Forsendelsestidspunkt).HasColumnName("Forsendelsestidspunkt");
            this.Property(t => t.From).HasColumnName("From");
            this.Property(t => t.ToKode).HasColumnName("ToKode");
            this.Property(t => t.CC).HasColumnName("CC");
            this.Property(t => t.BCC).HasColumnName("BCC");
            this.Property(t => t.Subject).HasColumnName("Subject");
            this.Property(t => t.Body).HasColumnName("Body");
            this.Property(t => t.VareID).HasColumnName("VareID");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");

            // Relationships
            this.HasRequired(t => t.Vare)
                .WithMany(t => t.EmailSkabelons)
                .HasForeignKey(d => d.VareID);

        }
    }
}
