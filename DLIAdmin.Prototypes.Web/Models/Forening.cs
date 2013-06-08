using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class Forening
    {
        public System.Guid ID { get; set; }
        public string Navn { get; set; }
        public Nullable<int> Foreningsnr { get; set; }
        public string Koordinat1 { get; set; }
        public Nullable<decimal> Koordinat2 { get; set; }
        public Nullable<decimal> Koordinat3 { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public System.DateTime Navisiontid { get; set; }
        public string Ajourini { get; set; }
    }
}
