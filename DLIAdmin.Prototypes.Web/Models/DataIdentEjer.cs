using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class DataIdentEjer
    {
        public DataIdentEjer()
        {
            this.BrugerIBrugers = new List<BrugerIBruger>();
            this.DataIdents = new List<DataIdent>();
        }

        public System.Guid ID { get; set; }
        public string Navn { get; set; }
        public string TekniskNavn { get; set; }
        public string KortNavn { get; set; }
        public string SystemId { get; set; }
        public bool BrugerIBruger { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public string Ajourini { get; set; }
        public virtual ICollection<BrugerIBruger> BrugerIBrugers { get; set; }
        public virtual ICollection<DataIdent> DataIdents { get; set; }
    }
}
