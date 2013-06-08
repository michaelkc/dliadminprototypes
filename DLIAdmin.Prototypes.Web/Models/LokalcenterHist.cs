using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class LokalcenterHist
    {
        public System.Guid ID { get; set; }
        public string Navn { get; set; }
        public string Koordinat1 { get; set; }
        public Nullable<decimal> Koordinat2 { get; set; }
        public Nullable<decimal> Koordinat3 { get; set; }
        public int Centernummer { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public string Ajourini { get; set; }
    }
}
