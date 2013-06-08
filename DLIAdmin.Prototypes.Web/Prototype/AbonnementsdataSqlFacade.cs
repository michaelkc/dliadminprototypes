using System;
using System.Collections.Generic;
using System.Linq;
using DLIAdmin.Prototypes.Web.Models;
using StackExchange.Profiling;

namespace DLIAdmin.Prototypes.Web.Prototype
{
    public class AbonnementsdataSqlFacade
    {
        public List<Abonnement> LoadSubscriptions(Guid id)
        {
            var profiler = MiniProfiler.Current;
            using (profiler.Step("AbonnementsdataSqlFacade.LoadSubscriptions"))
            {
                //Thread.Sleep(TimeSpan.FromSeconds(10));
                using (var context = new BrugerDatabaseContext())
                {
                    var abonnementer = context.Abonnements.Where(abonnement => abonnement.BrugerID == id);
                    return abonnementer.ToList();
                }
            }
        }
    }
}