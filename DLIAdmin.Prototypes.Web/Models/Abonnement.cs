using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class Abonnement
    {
        public System.Guid ID { get; set; }
        public Nullable<System.DateTime> Startdato { get; set; }
        public Nullable<System.DateTime> Slutdato { get; set; }
        public System.DateTime OprettelsesDato { get; set; }
        public System.Guid VareID { get; set; }
        public System.Guid BrugerID { get; set; }
        public Nullable<System.Guid> DataejerID { get; set; }
        public Nullable<System.Guid> BestillerID { get; set; }
        public System.DateTime SidstFaktureretDato { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public string Ajourini { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public virtual Vare Vare { get; set; }
    }
}
