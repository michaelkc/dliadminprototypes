using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class RegnskabsnrMedLokalcenter
    {
        public string Navn { get; set; }
        public string Regnskabsident { get; set; }
        public int NavisionImportSekvensnr { get; set; }
        public int NavisionEksportSekvensnr { get; set; }
        public Nullable<System.DateTime> NavisionUdtraekstidspunkt { get; set; }
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> LokalcenterID { get; set; }
    }
}
