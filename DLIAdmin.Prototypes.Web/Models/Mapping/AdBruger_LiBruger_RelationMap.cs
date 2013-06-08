using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class AdBruger_LiBruger_RelationMap : EntityTypeConfiguration<AdBruger_LiBruger_Relation>
    {
        public AdBruger_LiBruger_RelationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Bruger_ID, t.ADLogonname, t.ADIdent, t.PrimaeradresseID, t.BrugerTilBrugerRelation_ID, t.BrugerID, t.BrugerRelationID, t.BrugerRelation_ID, t.SystemRelationID, t.LogonName, t.SystemRelation_ID, t.TekniskNavn });

            // Properties
            this.Property(t => t.ADLogonname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ADIdent)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LogonName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TekniskNavn)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Navn)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("AdBruger_LiBruger_Relation");
            this.Property(t => t.Bruger_ID).HasColumnName("Bruger_ID");
            this.Property(t => t.ADLogonname).HasColumnName("ADLogonname");
            this.Property(t => t.ADGuid).HasColumnName("ADGuid");
            this.Property(t => t.ADIdent).HasColumnName("ADIdent");
            this.Property(t => t.PrimaeradresseID).HasColumnName("PrimaeradresseID");
            this.Property(t => t.PrimaertForeningsnr).HasColumnName("PrimaertForeningsnr");
            this.Property(t => t.BrugerTilBrugerRelation_ID).HasColumnName("BrugerTilBrugerRelation_ID");
            this.Property(t => t.BrugerID).HasColumnName("BrugerID");
            this.Property(t => t.BrugerRelationID).HasColumnName("BrugerRelationID");
            this.Property(t => t.BrugerRelation_ID).HasColumnName("BrugerRelation_ID");
            this.Property(t => t.SystemRelationID).HasColumnName("SystemRelationID");
            this.Property(t => t.LogonName).HasColumnName("LogonName");
            this.Property(t => t.SystemRelation_ID).HasColumnName("SystemRelation_ID");
            this.Property(t => t.TekniskNavn).HasColumnName("TekniskNavn");
            this.Property(t => t.Navn).HasColumnName("Navn");
        }
    }
}
