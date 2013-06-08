using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class SSOBrugerMaxMap : EntityTypeConfiguration<SSOBrugerMax>
    {
        public SSOBrugerMaxMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ADLogonname, t.Initialer, t.DyrkerKartofler, t.DyrkerGroentsager, t.DyrkerFrugt, t.AntalPelsdyr, t.AntalHoens, t.AntalKyllinger, t.AntalSheep, t.AntalHeste, t.maxmedlem, t.SenesteDataLeverandoer });

            // Properties
            this.Property(t => t.ADLogonname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.navn)
                .HasMaxLength(50);

            this.Property(t => t.Initialer)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.titel)
                .HasMaxLength(30);

            this.Property(t => t.Telefon)
                .HasMaxLength(30);

            this.Property(t => t.Mobil)
                .HasMaxLength(30);

            this.Property(t => t.Fax)
                .HasMaxLength(30);

            this.Property(t => t.Email)
                .HasMaxLength(256);

            this.Property(t => t.CPR)
                .HasMaxLength(11);

            this.Property(t => t.CVR)
                .HasMaxLength(20);

            this.Property(t => t.vejnavn)
                .HasMaxLength(50);

            this.Property(t => t.postnummer)
                .HasMaxLength(20);

            this.Property(t => t.bynavn)
                .HasMaxLength(30);

            this.Property(t => t.landekode)
                .HasMaxLength(10);

            this.Property(t => t.gaardnavn)
                .HasMaxLength(30);

            this.Property(t => t.opgang)
                .HasMaxLength(3);

            this.Property(t => t.etage)
                .HasMaxLength(2);

            this.Property(t => t.sidelejlighed)
                .HasMaxLength(4);

            this.Property(t => t.stednavn)
                .HasMaxLength(30);

            this.Property(t => t.Firmanavn)
                .HasMaxLength(64);

            this.Property(t => t.AntalPelsdyr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AntalHoens)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AntalKyllinger)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AntalSheep)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AntalHeste)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.maxmedlem)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UrlStortBillede)
                .HasMaxLength(100);

            this.Property(t => t.UrlLilleBillede)
                .HasMaxLength(100);

            this.Property(t => t.SenesteDataLeverandoer)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SSOBrugerMax");
            this.Property(t => t.ADLogonname).HasColumnName("ADLogonname");
            this.Property(t => t.navn).HasColumnName("navn");
            this.Property(t => t.Initialer).HasColumnName("Initialer");
            this.Property(t => t.titel).HasColumnName("titel");
            this.Property(t => t.Telefon).HasColumnName("Telefon");
            this.Property(t => t.Mobil).HasColumnName("Mobil");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.CPR).HasColumnName("CPR");
            this.Property(t => t.CVR).HasColumnName("CVR");
            this.Property(t => t.CHRNummer).HasColumnName("CHRNummer");
            this.Property(t => t.centernr).HasColumnName("centernr");
            this.Property(t => t.vejnavn).HasColumnName("vejnavn");
            this.Property(t => t.husnummer).HasColumnName("husnummer");
            this.Property(t => t.postnummer).HasColumnName("postnummer");
            this.Property(t => t.bynavn).HasColumnName("bynavn");
            this.Property(t => t.landekode).HasColumnName("landekode");
            this.Property(t => t.gaardnavn).HasColumnName("gaardnavn");
            this.Property(t => t.opgang).HasColumnName("opgang");
            this.Property(t => t.etage).HasColumnName("etage");
            this.Property(t => t.sidelejlighed).HasColumnName("sidelejlighed");
            this.Property(t => t.stednavn).HasColumnName("stednavn");
            this.Property(t => t.Firmanr).HasColumnName("Firmanr");
            this.Property(t => t.Firmanavn).HasColumnName("Firmanavn");
            this.Property(t => t.DyrkerVaarbyg).HasColumnName("DyrkerVaarbyg");
            this.Property(t => t.DyrkerVaarhvede).HasColumnName("DyrkerVaarhvede");
            this.Property(t => t.DyrkerVaarraps).HasColumnName("DyrkerVaarraps");
            this.Property(t => t.DyrkerHavre).HasColumnName("DyrkerHavre");
            this.Property(t => t.DyrkerTriticale).HasColumnName("DyrkerTriticale");
            this.Property(t => t.DyrkerVinterbyg).HasColumnName("DyrkerVinterbyg");
            this.Property(t => t.DyrkerVinterhvede).HasColumnName("DyrkerVinterhvede");
            this.Property(t => t.DyrkerRug).HasColumnName("DyrkerRug");
            this.Property(t => t.DyrkerVinterraps).HasColumnName("DyrkerVinterraps");
            this.Property(t => t.DyrkerMarkaert).HasColumnName("DyrkerMarkaert");
            this.Property(t => t.DyrkerFroeafgroeder).HasColumnName("DyrkerFroeafgroeder");
            this.Property(t => t.DyrkerSukkerroer).HasColumnName("DyrkerSukkerroer");
            this.Property(t => t.DyrkerFoderroer).HasColumnName("DyrkerFoderroer");
            this.Property(t => t.DyrkerMajs).HasColumnName("DyrkerMajs");
            this.Property(t => t.DyrkerKloeverOgSlaetgraes).HasColumnName("DyrkerKloeverOgSlaetgraes");
            this.Property(t => t.DyrkerKartofler).HasColumnName("DyrkerKartofler");
            this.Property(t => t.DyrkerGroentsager).HasColumnName("DyrkerGroentsager");
            this.Property(t => t.DyrkerFrugt).HasColumnName("DyrkerFrugt");
            this.Property(t => t.AntaMalkekoeer).HasColumnName("AntaMalkekoeer");
            this.Property(t => t.AntalAmmekoeer).HasColumnName("AntalAmmekoeer");
            this.Property(t => t.AntalMindreDyr).HasColumnName("AntalMindreDyr");
            this.Property(t => t.AntalAndetKvaeg).HasColumnName("AntalAndetKvaeg");
            this.Property(t => t.AntalSoeer).HasColumnName("AntalSoeer");
            this.Property(t => t.AntalSlagtekvaeg).HasColumnName("AntalSlagtekvaeg");
            this.Property(t => t.AntalSlagtesvin).HasColumnName("AntalSlagtesvin");
            this.Property(t => t.AntalAarssoeer).HasColumnName("AntalAarssoeer");
            this.Property(t => t.AntalDyreenhedeIOevrigt).HasColumnName("AntalDyreenhedeIOevrigt");
            this.Property(t => t.AntalPelsdyr).HasColumnName("AntalPelsdyr");
            this.Property(t => t.AntalHoens).HasColumnName("AntalHoens");
            this.Property(t => t.AntalKyllinger).HasColumnName("AntalKyllinger");
            this.Property(t => t.AntalSheep).HasColumnName("AntalSheep");
            this.Property(t => t.AntalHeste).HasColumnName("AntalHeste");
            this.Property(t => t.Vejloebenummer).HasColumnName("Vejloebenummer");
            this.Property(t => t.Produktionsform).HasColumnName("Produktionsform");
            this.Property(t => t.maxmedlem).HasColumnName("maxmedlem");
            this.Property(t => t.UrlStortBillede).HasColumnName("UrlStortBillede");
            this.Property(t => t.UrlLilleBillede).HasColumnName("UrlLilleBillede");
            this.Property(t => t.Heltidslandmand).HasColumnName("Heltidslandmand");
            this.Property(t => t.Foedselsaar).HasColumnName("Foedselsaar");
            this.Property(t => t.FastansatMedhjaelp).HasColumnName("FastansatMedhjaelp");
            this.Property(t => t.AarligOmsaetning).HasColumnName("AarligOmsaetning");
            this.Property(t => t.HektarDrevet).HasColumnName("HektarDrevet");
            this.Property(t => t.Ejendomsvaerdi).HasColumnName("Ejendomsvaerdi");
            this.Property(t => t.SenesteDataLeverandoer).HasColumnName("SenesteDataLeverandoer");
        }
    }
}
