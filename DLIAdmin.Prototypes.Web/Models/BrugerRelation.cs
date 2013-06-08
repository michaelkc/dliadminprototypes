using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class BrugerRelation
    {
        public BrugerRelation()
        {
            this.BrugerTilBrugerRelations = new List<BrugerTilBrugerRelation>();
        }

        public System.Guid ID { get; set; }
        public System.Guid SystemRelationID { get; set; }
        public string LogonName { get; set; }
        public string Ajourini { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public int UserValidationLevel { get; set; }
        public virtual SystemRelation SystemRelation { get; set; }
        public virtual ICollection<BrugerTilBrugerRelation> BrugerTilBrugerRelations { get; set; }
    }
}
