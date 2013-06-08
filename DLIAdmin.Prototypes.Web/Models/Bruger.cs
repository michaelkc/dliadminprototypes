using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class Bruger
    {
        public Bruger()
        {
            this.BedriftIDs = new List<BedriftID>();
            this.BedriftIDRettighedPersons = new List<BedriftIDRettighedPerson>();
            this.Subscriptions = new List<Subscription>();
            this.Subscriptions1 = new List<Subscription>();
            this.Subscriptions2 = new List<Subscription>();
            this.BrugerIBrugers = new List<BrugerIBruger>();
            this.BrugerIBrugers1 = new List<BrugerIBruger>();
            this.BrugerTilBrugerRelations = new List<BrugerTilBrugerRelation>();
            this.CVRNummers = new List<CVRNummer>();
            this.CVRValideringers = new List<CVRValideringer>();
            this.DataIdents = new List<DataIdent>();
            this.Gruppeudmeldings = new List<Gruppeudmelding>();
            this.Navisionprofils = new List<Navisionprofil>();
            this.NulstilletPasswords = new List<NulstilletPassword>();
            this.SENummers = new List<SENummer>();
        }

        public System.Guid ID { get; set; }
        public string ADLogonname { get; set; }
        public Nullable<System.Guid> ADGuid { get; set; }
        public int ADIdent { get; set; }
        public System.Guid PrimaeradresseID { get; set; }
        public Nullable<int> PrimaertForeningsnr { get; set; }
        public string UrlStortBillede { get; set; }
        public string UrlLilleBillede { get; set; }
        public Nullable<int> Type { get; set; }
        public string Specialiteter { get; set; }
        public Nullable<byte> Praesentation { get; set; }
        public Nullable<int> Sortering { get; set; }
        public string TitelUK { get; set; }
        public Nullable<byte> VisPrivateOplysninger { get; set; }
        public Nullable<System.Guid> HjemmeadresseID { get; set; }
        public string Hjemmetelefon { get; set; }
        public string HjemmeFax { get; set; }
        public string Hjemmemobil { get; set; }
        public string HjemmeEmail { get; set; }
        public string LinkTilCV { get; set; }
        public Nullable<System.Guid> ArbejdsomraaderID { get; set; }
        public Nullable<decimal> AntaMalkekoeer { get; set; }
        public Nullable<decimal> AntalAmmekoeer { get; set; }
        public Nullable<decimal> AntalMindreDyr { get; set; }
        public Nullable<decimal> AntalAndetKvaeg { get; set; }
        public Nullable<decimal> AntalSoeer { get; set; }
        public Nullable<decimal> AntalSlagtekvaeg { get; set; }
        public Nullable<decimal> AntalSlagtesvin { get; set; }
        public Nullable<int> Ejendomsvaerdi { get; set; }
        public Nullable<decimal> ArealInklForpagtning { get; set; }
        public Nullable<decimal> ArealTilBortforpagtet { get; set; }
        public Nullable<byte> Oekolog { get; set; }
        public Nullable<byte> Planteavl { get; set; }
        public Nullable<byte> Kvaegavl { get; set; }
        public Nullable<byte> Svineavl { get; set; }
        public Nullable<decimal> CHRNummer { get; set; }
        public Nullable<byte> Heltidslandmand { get; set; }
        public Nullable<short> Foedselsaar { get; set; }
        public Nullable<short> Produktionsform { get; set; }
        public Nullable<byte> FastansatMedhjaelp { get; set; }
        public Nullable<short> AarligOmsaetning { get; set; }
        public Nullable<short> HektarDrevet { get; set; }
        public Nullable<decimal> AntalAarssoeer { get; set; }
        public Nullable<decimal> AntalDyreenhedeIOevrigt { get; set; }
        public Nullable<byte> DyrkerVaarbyg { get; set; }
        public Nullable<byte> DyrkerVaarhvede { get; set; }
        public Nullable<byte> DyrkerVaarraps { get; set; }
        public Nullable<byte> DyrkerHavre { get; set; }
        public Nullable<byte> DyrkerTriticale { get; set; }
        public Nullable<byte> DyrkerVinterbyg { get; set; }
        public Nullable<byte> DyrkerVinterhvede { get; set; }
        public Nullable<byte> DyrkerRug { get; set; }
        public Nullable<byte> DyrkerVinterraps { get; set; }
        public Nullable<byte> DyrkerMarkaert { get; set; }
        public Nullable<byte> DyrkerFroeafgroeder { get; set; }
        public Nullable<byte> DyrkerSukkerroer { get; set; }
        public Nullable<byte> DyrkerFoderroer { get; set; }
        public Nullable<byte> DyrkerMajs { get; set; }
        public Nullable<byte> DyrkerKloeverOgSlaetgraes { get; set; }
        public string Koordinat1 { get; set; }
        public Nullable<decimal> Koordinat2 { get; set; }
        public Nullable<decimal> Koordinat3 { get; set; }
        public string Ajourini { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public System.DateTime Navisiontid { get; set; }
        public string Kodeord { get; set; }
        public byte VisFotoPaaInternettet { get; set; }
        public decimal AntalPelsdyr { get; set; }
        public decimal AntalHoens { get; set; }
        public decimal AntalKyllinger { get; set; }
        public decimal AntalSheep { get; set; }
        public decimal AntalHeste { get; set; }
        public byte DyrkerKartofler { get; set; }
        public byte DyrkerGroentsager { get; set; }
        public byte DyrkerFrugt { get; set; }
        public Nullable<System.DateTime> SidsteLogon { get; set; }
        public Nullable<System.DateTime> SidsteKodeordsskift { get; set; }
        public string ADPath { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string CVR { get; set; }
        public string CPR { get; set; }
        public Nullable<System.Guid> LeveringsAdresseID { get; set; }
        public string Mobil { get; set; }
        public Nullable<System.Guid> CultureID { get; set; }
        public int Mastervedligehold { get; set; }
        public byte Slettet { get; set; }
        public string Firmanavn { get; set; }
        public string Note { get; set; }
        public string Initialer { get; set; }
        public int SenesteDataLeverandoer { get; set; }
        public virtual ICollection<BedriftID> BedriftIDs { get; set; }
        public virtual ICollection<BedriftIDRettighedPerson> BedriftIDRettighedPersons { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
        public virtual ICollection<Subscription> Subscriptions1 { get; set; }
        public virtual ICollection<Subscription> Subscriptions2 { get; set; }
        public virtual Culture Culture { get; set; }
        public virtual ICollection<BrugerIBruger> BrugerIBrugers { get; set; }
        public virtual ICollection<BrugerIBruger> BrugerIBrugers1 { get; set; }
        public virtual ICollection<BrugerTilBrugerRelation> BrugerTilBrugerRelations { get; set; }
        public virtual ICollection<CVRNummer> CVRNummers { get; set; }
        public virtual ICollection<CVRValideringer> CVRValideringers { get; set; }
        public virtual ICollection<DataIdent> DataIdents { get; set; }
        public virtual ICollection<Gruppeudmelding> Gruppeudmeldings { get; set; }
        public virtual ICollection<Navisionprofil> Navisionprofils { get; set; }
        public virtual ICollection<NulstilletPassword> NulstilletPasswords { get; set; }
        public virtual ICollection<SENummer> SENummers { get; set; }
    }
}
