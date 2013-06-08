using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class Subscription
    {
        public System.Guid ID { get; set; }
        public Nullable<System.DateTime> Startdate { get; set; }
        public Nullable<System.DateTime> Enddate { get; set; }
        public System.DateTime CreationDate { get; set; }
        public System.Guid ProductID { get; set; }
        public System.Guid UserID { get; set; }
        public Nullable<System.Guid> DataownerID { get; set; }
        public Nullable<System.Guid> OrdererID { get; set; }
        public System.DateTime LastInvoiceDate { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public string Ajourini { get; set; }
        public virtual Bruger Bruger { get; set; }
        public virtual Bruger Bruger1 { get; set; }
        public virtual Bruger Bruger2 { get; set; }
        public virtual Product Product { get; set; }
    }
}
