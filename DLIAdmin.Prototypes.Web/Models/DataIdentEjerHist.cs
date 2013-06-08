using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class DataIdentEjerHist
    {
        public System.Guid ID { get; set; }
        public string Navn { get; set; }
        public string TekniskNavn { get; set; }
        public string KortNavn { get; set; }
        public string SystemId { get; set; }
        public bool BrugerIBruger { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public string Ajourini { get; set; }
    }
}
