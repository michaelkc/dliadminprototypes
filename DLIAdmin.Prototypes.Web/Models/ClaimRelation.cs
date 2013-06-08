using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class ClaimRelation
    {
        public System.Guid ID { get; set; }
        public string ADGruppeNavn { get; set; }
        public string ClaimValue { get; set; }
        public string Ajourini { get; set; }
        public System.DateTime Ajourtid { get; set; }
    }
}
