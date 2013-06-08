using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class GruppeudmeldingHist
    {
        public System.Guid ID { get; set; }
        public string FjernFraGruppe { get; set; }
        public System.DateTime UdlobsDato { get; set; }
        public string EmailTo { get; set; }
        public string EmailCC { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public string EmailFrom { get; set; }
        public string Status { get; set; }
        public System.Guid BrugerID { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public string Ajourini { get; set; }
        public int ActionKode { get; set; }
    }
}
