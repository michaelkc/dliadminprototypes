using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class SENummer
    {
        public System.Guid ID { get; set; }
        public string SENummer1 { get; set; }
        public System.Guid BrugerID { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public string Ajourini { get; set; }
        public virtual Bruger Bruger { get; set; }
    }
}
