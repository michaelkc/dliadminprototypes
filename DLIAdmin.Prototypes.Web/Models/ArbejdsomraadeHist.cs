using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class ArbejdsomraadeHist
    {
        public System.Guid ID { get; set; }
        public string Arbejdsomraadenavn { get; set; }
        public string ArbejdsomraadenavnUK { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public string Ajourini { get; set; }
    }
}
