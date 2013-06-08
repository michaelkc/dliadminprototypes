using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class VareMap : EntityTypeConfiguration<Vare>
    {
        public VareMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Navn)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Beskrivelse)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.ADGruppe)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Varenummer)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.RegnskabsIdent)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("Vare");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Navn).HasColumnName("Navn");
            this.Property(t => t.Beskrivelse).HasColumnName("Beskrivelse");
            this.Property(t => t.ADGruppe).HasColumnName("ADGruppe");
            this.Property(t => t.Varenummer).HasColumnName("Varenummer");
            this.Property(t => t.RegnskabsIdent).HasColumnName("RegnskabsIdent");
            this.Property(t => t.Betaler).HasColumnName("Betaler");
            this.Property(t => t.AntalDagesAdgang).HasColumnName("AntalDagesAdgang");
            this.Property(t => t.MaaIkkeGentegneIndenForDage).HasColumnName("MaaIkkeGentegneIndenForDage");
            this.Property(t => t.GenbrugAbonnementIndenForDage).HasColumnName("GenbrugAbonnementIndenForDage");
            this.Property(t => t.StartPris).HasColumnName("StartPris");
            this.Property(t => t.AbonnementPris).HasColumnName("AbonnementPris");
            this.Property(t => t.AbonnementPeriode).HasColumnName("AbonnementPeriode");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.KraeverEmail).HasColumnName("KraeverEmail");
            this.Property(t => t.KraeverMobil).HasColumnName("KraeverMobil");
            this.Property(t => t.BrugerSkalHaveSystemRelationID).HasColumnName("BrugerSkalHaveSystemRelationID");
            this.Property(t => t.DataejerSkalHaveSystemRelationID).HasColumnName("DataejerSkalHaveSystemRelationID");

            // Relationships
            this.HasOptional(t => t.SystemRelation)
                .WithMany(t => t.Vares)
                .HasForeignKey(d => d.BrugerSkalHaveSystemRelationID);
            this.HasOptional(t => t.SystemRelation1)
                .WithMany(t => t.Vares1)
                .HasForeignKey(d => d.DataejerSkalHaveSystemRelationID);

        }
    }
}
