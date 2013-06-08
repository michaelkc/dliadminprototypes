using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class DQS_Ekstern
    {
        public System.Guid ID { get; set; }
        public string BrugerID { get; set; }
        public string Navn { get; set; }
        public string Titel { get; set; }
        public string Vejnavn { get; set; }
        public Nullable<int> Vejloebenummer { get; set; }
        public Nullable<int> Husnummer { get; set; }
        public string Opgang { get; set; }
        public string Etage { get; set; }
        public string SideLejlighed { get; set; }
        public string Gaardnavn { get; set; }
        public string Stednavn { get; set; }
        public string Postnummer { get; set; }
        public string Bynavn { get; set; }
        public string Landekode { get; set; }
        public string Mobil { get; set; }
        public string CPR { get; set; }
        public string CVR { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Telefon { get; set; }
        public string System { get; set; }
        public string BrugerID_Ekstern { get; set; }
        public string Ajourini { get; set; }
        public System.DateTime Ajourtid { get; set; }
    }
}
