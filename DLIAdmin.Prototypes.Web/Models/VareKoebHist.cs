using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class VareKoebHist
    {
        public System.Guid ID { get; set; }
        public int VarekoebID { get; set; }
        public string Brugerid { get; set; }
        public Nullable<System.DateTime> AdgangTilDato { get; set; }
        public string BestiltAf { get; set; }
        public Nullable<int> NavisionIdent { get; set; }
        public string RegnskabIdent { get; set; }
        public string VareGruppe { get; set; }
        public string VareNummer { get; set; }
        public decimal Pris { get; set; }
        public decimal SpecialPris { get; set; }
        public decimal VareAntal { get; set; }
        public string Navn { get; set; }
        public string Titel { get; set; }
        public Nullable<System.Guid> AdresseID { get; set; }
        public string Faktureringsnavn { get; set; }
        public Nullable<System.Guid> FaktureringsadresseID { get; set; }
        public int Faktureringstype { get; set; }
        public System.DateTime Oprettelsesdato { get; set; }
        public string Beskrivelse { get; set; }
        public string Beskrivelse2 { get; set; }
        public int Kundetype { get; set; }
        public string KundetypeTekst { get; set; }
        public int Varetype { get; set; }
        public string VaretypeTekst { get; set; }
        public string Ekstra1 { get; set; }
        public int Ordrenummer { get; set; }
        public string Ajourini { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public System.DateTime Navisiontid { get; set; }
        public int Status { get; set; }
        public Nullable<System.Guid> AbonnementID { get; set; }
        public Nullable<System.DateTime> OverfoeretDato { get; set; }
    }
}
