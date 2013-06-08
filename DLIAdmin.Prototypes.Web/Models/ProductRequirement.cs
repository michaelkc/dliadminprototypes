using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class ProductRequirement
    {
        public System.Guid ID { get; set; }
        public System.Guid ProductID { get; set; }
        public System.Guid RequiredProductID { get; set; }
        public string RequiredADGroupname { get; set; }
        public virtual Product Product { get; set; }
        public virtual Product Product1 { get; set; }
    }
}
