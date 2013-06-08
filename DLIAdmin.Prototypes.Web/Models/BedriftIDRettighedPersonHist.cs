using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class BedriftIDRettighedPersonHist
    {
        public System.Guid ID { get; set; }
        public string HarAdgang { get; set; }
        public System.Guid BrugerID { get; set; }
        public System.Guid BedriftID { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public string Ajourini { get; set; }
    }
}
