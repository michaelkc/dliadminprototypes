using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DLIAdmin.Prototypes.Web.Models.Mapping
{
    public class BrugerMap : EntityTypeConfiguration<Bruger>
    {
        public BrugerMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ADLogonname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UrlStortBillede)
                .HasMaxLength(100);

            this.Property(t => t.UrlLilleBillede)
                .HasMaxLength(100);

            this.Property(t => t.Specialiteter)
                .HasMaxLength(500);

            this.Property(t => t.TitelUK)
                .HasMaxLength(50);

            this.Property(t => t.Hjemmetelefon)
                .HasMaxLength(50);

            this.Property(t => t.HjemmeFax)
                .HasMaxLength(50);

            this.Property(t => t.Hjemmemobil)
                .HasMaxLength(50);

            this.Property(t => t.HjemmeEmail)
                .HasMaxLength(80);

            this.Property(t => t.LinkTilCV)
                .HasMaxLength(50);

            this.Property(t => t.Koordinat1)
                .HasMaxLength(50);

            this.Property(t => t.Ajourini)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Kodeord)
                .HasMaxLength(1000);

            this.Property(t => t.ADPath)
                .HasMaxLength(260);

            this.Property(t => t.Telefon)
                .HasMaxLength(30);

            this.Property(t => t.Fax)
                .HasMaxLength(30);

            this.Property(t => t.Email)
                .HasMaxLength(256);

            this.Property(t => t.CVR)
                .HasMaxLength(20);

            this.Property(t => t.CPR)
                .HasMaxLength(11);

            this.Property(t => t.Mobil)
                .HasMaxLength(30);

            this.Property(t => t.Firmanavn)
                .HasMaxLength(64);

            this.Property(t => t.Note)
                .IsRequired()
                .HasMaxLength(800);

            this.Property(t => t.Initialer)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Bruger");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ADLogonname).HasColumnName("ADLogonname");
            this.Property(t => t.ADGuid).HasColumnName("ADGuid");
            this.Property(t => t.ADIdent).HasColumnName("ADIdent");
            this.Property(t => t.PrimaeradresseID).HasColumnName("PrimaeradresseID");
            this.Property(t => t.PrimaertForeningsnr).HasColumnName("PrimaertForeningsnr");
            this.Property(t => t.UrlStortBillede).HasColumnName("UrlStortBillede");
            this.Property(t => t.UrlLilleBillede).HasColumnName("UrlLilleBillede");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Specialiteter).HasColumnName("Specialiteter");
            this.Property(t => t.Praesentation).HasColumnName("Praesentation");
            this.Property(t => t.Sortering).HasColumnName("Sortering");
            this.Property(t => t.TitelUK).HasColumnName("TitelUK");
            this.Property(t => t.VisPrivateOplysninger).HasColumnName("VisPrivateOplysninger");
            this.Property(t => t.HjemmeadresseID).HasColumnName("HjemmeadresseID");
            this.Property(t => t.Hjemmetelefon).HasColumnName("Hjemmetelefon");
            this.Property(t => t.HjemmeFax).HasColumnName("HjemmeFax");
            this.Property(t => t.Hjemmemobil).HasColumnName("Hjemmemobil");
            this.Property(t => t.HjemmeEmail).HasColumnName("HjemmeEmail");
            this.Property(t => t.LinkTilCV).HasColumnName("LinkTilCV");
            this.Property(t => t.ArbejdsomraaderID).HasColumnName("ArbejdsomraaderID");
            this.Property(t => t.AntaMalkekoeer).HasColumnName("AntaMalkekoeer");
            this.Property(t => t.AntalAmmekoeer).HasColumnName("AntalAmmekoeer");
            this.Property(t => t.AntalMindreDyr).HasColumnName("AntalMindreDyr");
            this.Property(t => t.AntalAndetKvaeg).HasColumnName("AntalAndetKvaeg");
            this.Property(t => t.AntalSoeer).HasColumnName("AntalSoeer");
            this.Property(t => t.AntalSlagtekvaeg).HasColumnName("AntalSlagtekvaeg");
            this.Property(t => t.AntalSlagtesvin).HasColumnName("AntalSlagtesvin");
            this.Property(t => t.Ejendomsvaerdi).HasColumnName("Ejendomsvaerdi");
            this.Property(t => t.ArealInklForpagtning).HasColumnName("ArealInklForpagtning");
            this.Property(t => t.ArealTilBortforpagtet).HasColumnName("ArealTilBortforpagtet");
            this.Property(t => t.Oekolog).HasColumnName("Oekolog");
            this.Property(t => t.Planteavl).HasColumnName("Planteavl");
            this.Property(t => t.Kvaegavl).HasColumnName("Kvaegavl");
            this.Property(t => t.Svineavl).HasColumnName("Svineavl");
            this.Property(t => t.CHRNummer).HasColumnName("CHRNummer");
            this.Property(t => t.Heltidslandmand).HasColumnName("Heltidslandmand");
            this.Property(t => t.Foedselsaar).HasColumnName("Foedselsaar");
            this.Property(t => t.Produktionsform).HasColumnName("Produktionsform");
            this.Property(t => t.FastansatMedhjaelp).HasColumnName("FastansatMedhjaelp");
            this.Property(t => t.AarligOmsaetning).HasColumnName("AarligOmsaetning");
            this.Property(t => t.HektarDrevet).HasColumnName("HektarDrevet");
            this.Property(t => t.AntalAarssoeer).HasColumnName("AntalAarssoeer");
            this.Property(t => t.AntalDyreenhedeIOevrigt).HasColumnName("AntalDyreenhedeIOevrigt");
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
            this.Property(t => t.Koordinat1).HasColumnName("Koordinat1");
            this.Property(t => t.Koordinat2).HasColumnName("Koordinat2");
            this.Property(t => t.Koordinat3).HasColumnName("Koordinat3");
            this.Property(t => t.Ajourini).HasColumnName("Ajourini");
            this.Property(t => t.Ajourtid).HasColumnName("Ajourtid");
            this.Property(t => t.Navisiontid).HasColumnName("Navisiontid");
            this.Property(t => t.Kodeord).HasColumnName("Kodeord");
            this.Property(t => t.VisFotoPaaInternettet).HasColumnName("VisFotoPaaInternettet");
            this.Property(t => t.AntalPelsdyr).HasColumnName("AntalPelsdyr");
            this.Property(t => t.AntalHoens).HasColumnName("AntalHoens");
            this.Property(t => t.AntalKyllinger).HasColumnName("AntalKyllinger");
            this.Property(t => t.AntalSheep).HasColumnName("AntalSheep");
            this.Property(t => t.AntalHeste).HasColumnName("AntalHeste");
            this.Property(t => t.DyrkerKartofler).HasColumnName("DyrkerKartofler");
            this.Property(t => t.DyrkerGroentsager).HasColumnName("DyrkerGroentsager");
            this.Property(t => t.DyrkerFrugt).HasColumnName("DyrkerFrugt");
            this.Property(t => t.SidsteLogon).HasColumnName("SidsteLogon");
            this.Property(t => t.SidsteKodeordsskift).HasColumnName("SidsteKodeordsskift");
            this.Property(t => t.ADPath).HasColumnName("ADPath");
            this.Property(t => t.Telefon).HasColumnName("Telefon");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.CVR).HasColumnName("CVR");
            this.Property(t => t.CPR).HasColumnName("CPR");
            this.Property(t => t.LeveringsAdresseID).HasColumnName("LeveringsAdresseID");
            this.Property(t => t.Mobil).HasColumnName("Mobil");
            this.Property(t => t.CultureID).HasColumnName("CultureID");
            this.Property(t => t.Mastervedligehold).HasColumnName("Mastervedligehold");
            this.Property(t => t.Slettet).HasColumnName("Slettet");
            this.Property(t => t.Firmanavn).HasColumnName("Firmanavn");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Initialer).HasColumnName("Initialer");
            this.Property(t => t.SenesteDataLeverandoer).HasColumnName("SenesteDataLeverandoer");

            // Relationships
            this.HasOptional(t => t.Culture)
                .WithMany(t => t.Brugers)
                .HasForeignKey(d => d.CultureID);

        }
    }
}
