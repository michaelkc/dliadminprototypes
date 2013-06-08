using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class DQS_Output
    {
        public System.Guid ID { get; set; }
        public string Tabel1 { get; set; }
        public string Tabel2 { get; set; }
        public System.Guid Key1 { get; set; }
        public System.Guid Key2 { get; set; }
        public string Type { get; set; }
        public string HitColumn { get; set; }
        public Nullable<int> HitProcent { get; set; }
        public System.DateTime AjourtidDQS { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> AjourtidAdmin { get; set; }
        public string AjouriniAdmin { get; set; }
    }
}
