using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class Culture
    {
        public Culture()
        {
            this.Brugers = new List<Bruger>();
        }

        public System.Guid ID { get; set; }
        public string Land { get; set; }
        public string CultureKey { get; set; }
        public string Ajourini { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public virtual ICollection<Bruger> Brugers { get; set; }
    }
}
