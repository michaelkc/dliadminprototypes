using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class BedriftIDHist
    {
        public System.Guid ID { get; set; }
        public int BedriftID { get; set; }
        public string Navn { get; set; }
        public System.Guid TypeID { get; set; }
        public System.Guid EjerID { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public string Ajourini { get; set; }
        public string Ekstra1 { get; set; }
    }
}
