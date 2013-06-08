using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class AdBruger_LiBruger_Relation
    {
        public System.Guid Bruger_ID { get; set; }
        public string ADLogonname { get; set; }
        public Nullable<System.Guid> ADGuid { get; set; }
        public int ADIdent { get; set; }
        public System.Guid PrimaeradresseID { get; set; }
        public Nullable<int> PrimaertForeningsnr { get; set; }
        public System.Guid BrugerTilBrugerRelation_ID { get; set; }
        public System.Guid BrugerID { get; set; }
        public System.Guid BrugerRelationID { get; set; }
        public System.Guid BrugerRelation_ID { get; set; }
        public System.Guid SystemRelationID { get; set; }
        public string LogonName { get; set; }
        public System.Guid SystemRelation_ID { get; set; }
        public string TekniskNavn { get; set; }
        public string Navn { get; set; }
    }
}
