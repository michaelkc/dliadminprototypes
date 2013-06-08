using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class Vare
    {
        public Vare()
        {
            this.Abonnements = new List<Abonnement>();
            this.EmailSkabelons = new List<EmailSkabelon>();
            this.Butiks = new List<Butik>();
        }

        public System.Guid ID { get; set; }
        public string Navn { get; set; }
        public string Beskrivelse { get; set; }
        public string ADGruppe { get; set; }
        public string Varenummer { get; set; }
        public string RegnskabsIdent { get; set; }
        public int Betaler { get; set; }
        public int AntalDagesAdgang { get; set; }
        public int MaaIkkeGentegneIndenForDage { get; set; }
        public int GenbrugAbonnementIndenForDage { get; set; }
        public int StartPris { get; set; }
        public int AbonnementPris { get; set; }
        public int AbonnementPeriode { get; set; }
        public string Ajourini { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public byte KraeverEmail { get; set; }
        public byte KraeverMobil { get; set; }
        public Nullable<System.Guid> BrugerSkalHaveSystemRelationID { get; set; }
        public Nullable<System.Guid> DataejerSkalHaveSystemRelationID { get; set; }
        public virtual ICollection<Abonnement> Abonnements { get; set; }
        public virtual ICollection<EmailSkabelon> EmailSkabelons { get; set; }
        public virtual SystemRelation SystemRelation { get; set; }
        public virtual SystemRelation SystemRelation1 { get; set; }
        public virtual ICollection<Butik> Butiks { get; set; }
    }
}
