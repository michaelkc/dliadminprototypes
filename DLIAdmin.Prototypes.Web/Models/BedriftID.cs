using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class BedriftID
    {
        public BedriftID()
        {
            this.BedriftIDRettighedLokalcenters = new List<BedriftIDRettighedLokalcenter>();
            this.BedriftIDRettighedPersons = new List<BedriftIDRettighedPerson>();
        }

        public System.Guid ID { get; set; }
        public int BedriftID1 { get; set; }
        public string Navn { get; set; }
        public System.Guid TypeID { get; set; }
        public System.Guid EjerID { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public string Ajourini { get; set; }
        public string Ekstra1 { get; set; }
        public virtual Bedrifttype Bedrifttype { get; set; }
        public virtual Bruger Bruger { get; set; }
        public virtual ICollection<BedriftIDRettighedLokalcenter> BedriftIDRettighedLokalcenters { get; set; }
        public virtual ICollection<BedriftIDRettighedPerson> BedriftIDRettighedPersons { get; set; }
    }
}
