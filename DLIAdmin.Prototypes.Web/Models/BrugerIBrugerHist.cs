using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class BrugerIBrugerHist
    {
        public System.Guid ID { get; set; }
        public System.Guid BrugerID { get; set; }
        public System.Guid PaaVegneAfBrugerID { get; set; }
        public System.Guid DataIdentEjerID { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public string Ajourini { get; set; }
    }
}
