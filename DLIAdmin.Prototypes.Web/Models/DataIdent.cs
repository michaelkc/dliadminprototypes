using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class DataIdent
    {
        public System.Guid ID { get; set; }
        public System.Guid DataIdentEjerID { get; set; }
        public Nullable<System.Guid> BrugerID { get; set; }
        public string Cvr { get; set; }
        public string Value { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public string Ajourini { get; set; }
        public virtual Bruger Bruger { get; set; }
        public virtual DataIdentEjer DataIdentEjer { get; set; }
    }
}
