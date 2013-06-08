using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class BrugerTilBrugerRelationHist
    {
        public System.Guid ID { get; set; }
        public System.Guid BrugerID { get; set; }
        public System.Guid BrugerRelationID { get; set; }
        public string Ajourini { get; set; }
        public System.DateTime Ajourtid { get; set; }
    }
}
