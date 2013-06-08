using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class SSOBrugerMax
    {
        public string ADLogonname { get; set; }
        public string navn { get; set; }
        public string Initialer { get; set; }
        public string titel { get; set; }
        public string Telefon { get; set; }
        public string Mobil { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public Nullable<int> Type { get; set; }
        public string CPR { get; set; }
        public string CVR { get; set; }
        public Nullable<decimal> CHRNummer { get; set; }
        public Nullable<int> centernr { get; set; }
        public string vejnavn { get; set; }
        public Nullable<int> husnummer { get; set; }
        public string postnummer { get; set; }
        public string bynavn { get; set; }
        public string landekode { get; set; }
        public string gaardnavn { get; set; }
        public string opgang { get; set; }
        public string etage { get; set; }
        public string sidelejlighed { get; set; }
        public string stednavn { get; set; }
        public Nullable<int> Firmanr { get; set; }
        public string Firmanavn { get; set; }
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
        public byte DyrkerKartofler { get; set; }
        public byte DyrkerGroentsager { get; set; }
        public byte DyrkerFrugt { get; set; }
        public Nullable<decimal> AntaMalkekoeer { get; set; }
        public Nullable<decimal> AntalAmmekoeer { get; set; }
        public Nullable<decimal> AntalMindreDyr { get; set; }
        public Nullable<decimal> AntalAndetKvaeg { get; set; }
        public Nullable<decimal> AntalSoeer { get; set; }
        public Nullable<decimal> AntalSlagtekvaeg { get; set; }
        public Nullable<decimal> AntalSlagtesvin { get; set; }
        public Nullable<decimal> AntalAarssoeer { get; set; }
        public Nullable<decimal> AntalDyreenhedeIOevrigt { get; set; }
        public decimal AntalPelsdyr { get; set; }
        public decimal AntalHoens { get; set; }
        public decimal AntalKyllinger { get; set; }
        public decimal AntalSheep { get; set; }
        public decimal AntalHeste { get; set; }
        public Nullable<int> Vejloebenummer { get; set; }
        public Nullable<short> Produktionsform { get; set; }
        public int maxmedlem { get; set; }
        public string UrlStortBillede { get; set; }
        public string UrlLilleBillede { get; set; }
        public Nullable<byte> Heltidslandmand { get; set; }
        public Nullable<short> Foedselsaar { get; set; }
        public Nullable<byte> FastansatMedhjaelp { get; set; }
        public Nullable<short> AarligOmsaetning { get; set; }
        public Nullable<short> HektarDrevet { get; set; }
        public Nullable<int> Ejendomsvaerdi { get; set; }
        public int SenesteDataLeverandoer { get; set; }
    }
}
