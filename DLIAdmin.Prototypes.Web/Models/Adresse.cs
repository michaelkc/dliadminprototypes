using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class Adresse
    {
        public Adresse()
        {
            this.Navisionprofils = new List<Navisionprofil>();
            this.Navisionprofils1 = new List<Navisionprofil>();
            this.VareKoebs = new List<VareKoeb>();
            this.VareKoebs1 = new List<VareKoeb>();
        }

        public System.Guid ID { get; set; }
        public string Navn { get; set; }
        public string Titel { get; set; }
        public string Vejnavn { get; set; }
        public Nullable<int> Vejloebenummer { get; set; }
        public Nullable<int> Husnummer { get; set; }
        public string Opgang { get; set; }
        public string Etage { get; set; }
        public string SideLejlighed { get; set; }
        public string Gaardnavn { get; set; }
        public string Stednavn { get; set; }
        public string Postnummer { get; set; }
        public string Bynavn { get; set; }
        public string Landekode { get; set; }
        public string Ajourini { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public System.DateTime Navisiontid { get; set; }
        public virtual ICollection<Navisionprofil> Navisionprofils { get; set; }
        public virtual ICollection<Navisionprofil> Navisionprofils1 { get; set; }
        public virtual ICollection<VareKoeb> VareKoebs { get; set; }
        public virtual ICollection<VareKoeb> VareKoebs1 { get; set; }
    }
}
