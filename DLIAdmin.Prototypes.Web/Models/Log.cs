using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class Log
    {
        public System.Guid ID { get; set; }
        public string UdfoertAfIni { get; set; }
        public string UdfoertPaaIni { get; set; }
        public string UdfoertPaaMaskine { get; set; }
        public string UdfoertPaaGruppe { get; set; }
        public Nullable<System.DateTime> UdfoertTid { get; set; }
        public string HandlingText { get; set; }
        public Nullable<int> UdfoertAfSystem { get; set; }
        public Nullable<System.Guid> LogGruppering { get; set; }
        public Nullable<int> LogGrupperingSekvens { get; set; }
        public Nullable<int> LogVigtighed { get; set; }
        public Nullable<int> Status { get; set; }
        public string Detalje { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> Ajourtid { get; set; }
        public string Ajourini { get; set; }
    }
}
