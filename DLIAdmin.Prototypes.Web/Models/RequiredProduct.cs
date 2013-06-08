using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class RequiredProduct
    {
        public System.Guid roductID { get; set; }
        public System.Guid RequireProductID { get; set; }
        public string RequireADGroup { get; set; }
    }
}
