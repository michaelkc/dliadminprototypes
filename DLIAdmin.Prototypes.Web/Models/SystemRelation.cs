using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class SystemRelation
    {
        public SystemRelation()
        {
            this.BrugerRelations = new List<BrugerRelation>();
            this.Vares = new List<Vare>();
            this.Vares1 = new List<Vare>();
        }

        public System.Guid ID { get; set; }
        public string TekniskNavn { get; set; }
        public string Navn { get; set; }
        public string Ajourini { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public virtual ICollection<BrugerRelation> BrugerRelations { get; set; }
        public virtual ICollection<Vare> Vares { get; set; }
        public virtual ICollection<Vare> Vares1 { get; set; }
    }
}
