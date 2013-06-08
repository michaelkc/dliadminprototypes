using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class ConstantHist
    {
        public string KeyName { get; set; }
        public string KeyValue { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public string Ajourini { get; set; }
        public System.Guid ID { get; set; }
    }
}
