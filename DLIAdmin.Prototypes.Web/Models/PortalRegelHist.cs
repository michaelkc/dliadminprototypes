using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class PortalRegelHist
    {
        public System.Guid id { get; set; }
        public string PortalID { get; set; }
        public string Regelbeskrivelse { get; set; }
        public string Regel { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public string Ajourini { get; set; }
    }
}
