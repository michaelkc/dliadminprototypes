using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class BedrifttypeHist
    {
        public System.Guid ID { get; set; }
        public string Navn { get; set; }
        public string Adgruppe { get; set; }
        public string Adgruppeadm { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public string Ajourini { get; set; }
        public System.Guid Globalident { get; set; }
    }
}
