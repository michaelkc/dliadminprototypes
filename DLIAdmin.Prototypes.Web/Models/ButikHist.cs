using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class ButikHist
    {
        public System.Guid ID { get; set; }
        public int Butiknr { get; set; }
        public string Teknisknavn { get; set; }
        public string UrlTilBetingelser { get; set; }
        public string Ajourini { get; set; }
        public System.DateTime Ajourtid { get; set; }
    }
}
