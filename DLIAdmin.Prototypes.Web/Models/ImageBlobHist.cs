using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class ImageBlobHist
    {
        public System.Guid ID { get; set; }
        public string Filename { get; set; }
        public byte[] BLOBData { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public string Ajourini { get; set; }
    }
}
