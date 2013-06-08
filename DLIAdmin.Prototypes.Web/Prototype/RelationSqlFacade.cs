using System;
using System.Collections.Generic;
using System.Linq;
using DLIAdmin.Prototypes.Web.Models;
using StackExchange.Profiling;

namespace DLIAdmin.Prototypes.Web.Prototype
{
    public class RelationSqlFacade
    {
        public List<BrugerTilBrugerRelation> LoadRelations(Guid id)
        {
            var profiler = MiniProfiler.Current; 
            using (profiler.Step("RelationSqlFacade.LoadRelations"))
            {
                //Thread.Sleep(TimeSpan.FromSeconds(10));
                using (var context = new BrugerDatabaseContext())
                {
                    var relations = context.BrugerTilBrugerRelations.Where(b => b.BrugerID == id);
                    return relations.ToList();
                }
            }

        }
    }
}