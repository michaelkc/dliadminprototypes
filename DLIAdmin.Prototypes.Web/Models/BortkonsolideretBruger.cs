using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class BortkonsolideretBruger
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> UdgaaetID { get; set; }
        public string UdgaaetADLogonname { get; set; }
        public int UdgaaetADIdent { get; set; }
        public System.Guid BeholdID { get; set; }
        public string BeholdADLogonname { get; set; }
        public int BeholdADIdent { get; set; }
        public System.DateTime Tidspunkt { get; set; }
        public string Ajourini { get; set; }
        public System.DateTime Ajourtid { get; set; }
    }
}
