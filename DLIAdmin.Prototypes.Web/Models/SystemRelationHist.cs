using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class SystemRelationHist
    {
        public System.Guid ID { get; set; }
        public string TekniskNavn { get; set; }
        public string Navn { get; set; }
        public string Ajourini { get; set; }
        public System.DateTime Ajourtid { get; set; }
    }
}
