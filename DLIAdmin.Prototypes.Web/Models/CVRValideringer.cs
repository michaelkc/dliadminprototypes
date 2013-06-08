using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class CVRValideringer
    {
        public int ID { get; set; }
        public string ADLogonName { get; set; }
        public System.Guid BrugerID { get; set; }
        public string Type { get; set; }
        public string Modtager { get; set; }
        public string Forsendelse { get; set; }
        public int Antal { get; set; }
        public System.DateTime Forespoergselsdato { get; set; }
        public string Autoritet { get; set; }
        public Nullable<System.DateTime> Udsendelsesdato { get; set; }
        public virtual Bruger Bruger { get; set; }
    }
}
