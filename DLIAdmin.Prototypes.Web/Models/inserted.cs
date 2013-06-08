using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class inserted
    {
        public System.Guid ID { get; set; }
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
        public string Ajourini { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public System.DateTime Navisiontid { get; set; }
    }
}
