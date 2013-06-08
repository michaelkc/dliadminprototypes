using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class C_hypmv_3Map : EntityTypeConfiguration<C_hypmv_3>
    {
        public C_hypmv_3Map()
        {
            // Primary Key
            this.HasKey(t => new { t.C_hypmv_3_col_1, t.C_hypmv_3_col_3, t.C_hypmv_3_col_6, t.C_hypmv_3_col_7, t.C_hypmv_3_col_8, t.C_hypmv_3_col_9 });

            // Properties
            this.Property(t => t.C_hypmv_3_col_2)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.C_hypmv_3_col_3)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.C_hypmv_3_col_5)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("_hypmv_3");
            this.Property(t => t.C_hypmv_3_col_1).HasColumnName("_hypmv_3_col_1");
            this.Property(t => t.C_hypmv_3_col_2).HasColumnName("_hypmv_3_col_2");
            this.Property(t => t.C_hypmv_3_col_3).HasColumnName("_hypmv_3_col_3");
            this.Property(t => t.C_hypmv_3_col_4).HasColumnName("_hypmv_3_col_4");
            this.Property(t => t.C_hypmv_3_col_5).HasColumnName("_hypmv_3_col_5");
            this.Property(t => t.C_hypmv_3_col_6).HasColumnName("_hypmv_3_col_6");
            this.Property(t => t.C_hypmv_3_col_7).HasColumnName("_hypmv_3_col_7");
            this.Property(t => t.C_hypmv_3_col_8).HasColumnName("_hypmv_3_col_8");
            this.Property(t => t.C_hypmv_3_col_9).HasColumnName("_hypmv_3_col_9");
        }
    }
}
