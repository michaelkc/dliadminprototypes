using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class DQS_OutputMap : EntityTypeConfiguration<DQS_Output>
    {
        public DQS_OutputMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Tabel1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Tabel2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .HasMaxLength(250);

            this.Property(t => t.HitColumn)
                .HasMaxLength(250);

            this.Property(t => t.Status)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Note)
                .HasMaxLength(250);

            this.Property(t => t.AjouriniAdmin)
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("DQS_Output");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Tabel1).HasColumnName("Tabel1");
            this.Property(t => t.Tabel2).HasColumnName("Tabel2");
            this.Property(t => t.Key1).HasColumnName("Key1");
            this.Property(t => t.Key2).HasColumnName("Key2");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.HitColumn).HasColumnName("HitColumn");
            this.Property(t => t.HitProcent).HasColumnName("HitProcent");
            this.Property(t => t.AjourtidDQS).HasColumnName("AjourtidDQS");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.AjourtidAdmin).HasColumnName("AjourtidAdmin");
            this.Property(t => t.AjouriniAdmin).HasColumnName("AjouriniAdmin");
        }
    }
}
