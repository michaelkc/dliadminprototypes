using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class SSOBrugerCvrValidatedApplicationKey
    {
        public string ADLogonname { get; set; }
        public string TekniskNavn { get; set; }
        public string Value { get; set; }
        public int SenesteDataLeverandoer { get; set; }
        public int Mastervedligehold { get; set; }
    }
}
