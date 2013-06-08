using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class EmailSkabelon
    {
        public System.Guid ID { get; set; }
        public Nullable<int> Forsendelsestidspunkt { get; set; }
        public string From { get; set; }
        public int ToKode { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public System.Guid VareID { get; set; }
        public string Ajourini { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public virtual Vare Vare { get; set; }
    }
}
