using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class NulstilletPasswordHist
    {
        public System.Guid ID { get; set; }
        public System.Guid BrugerID { get; set; }
        public string NytPassword { get; set; }
        public System.DateTime NulstilletDen { get; set; }
        public Nullable<System.DateTime> EksporteretDen { get; set; }
        public string Ajourini { get; set; }
        public System.DateTime Ajourtid { get; set; }
    }
}
