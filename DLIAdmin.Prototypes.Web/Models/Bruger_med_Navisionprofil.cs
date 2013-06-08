using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class Bruger_med_Navisionprofil
    {
        public string ADLogonname { get; set; }
        public int ADIdent { get; set; }
        public string Regnskabsident { get; set; }
        public Nullable<int> Navisionident { get; set; }
        public string Navn { get; set; }
        public string Vejnavn { get; set; }
        public Nullable<int> Husnummer { get; set; }
        public string Postnummer { get; set; }
        public string Bynavn { get; set; }
        public Nullable<short> Medlemsstatus { get; set; }
    }
}
