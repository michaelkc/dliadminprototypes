using System;
using System.Collections.Generic;
using DLIAdmin.Prototypes.Web.Prototype;

namespace DLIAdmin.Prototypes.Web.Models.ViewModels
{
    public class BrugerDetailViewModel
    {
        public BrugerDetailViewModel()
        {
            AdUser = null;
            User = new Bruger();
            PortalServices = new PortalServices {PortalService = new PortalServicesPortalService[0]};
            Subscriptions = new List<Abonnement>();
            Relations = new List<BrugerTilBrugerRelation>();
            DegradedMode = false;
        }

        public AdUser AdUser { get; set; }
        
        public Bruger User { get; set; }

        public PortalServices PortalServices { get; set; }

        public List<Abonnement> Subscriptions { get; set; }

        public List<BrugerTilBrugerRelation> Relations { get; set; }

        public bool DegradedMode { get; set; }

        public List<Tuple<long, int, string>> Timings { get; set; }
    }
}