using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class RegnskabsidentHist
    {
        public System.Guid ID { get; set; }
        public string Regnskabsident { get; set; }
        public Nullable<System.Guid> LokalcenterID { get; set; }
        public int NavisionImportSekvensnr { get; set; }
        public int NavisionEksportSekvensnr { get; set; }
        public Nullable<System.DateTime> NavisionUdtraekstidspunkt { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public string Ajourini { get; set; }
    }
}
