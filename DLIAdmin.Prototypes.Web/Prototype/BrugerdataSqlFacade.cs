using System;
using System.Collections.Generic;
using System.Linq;
using DLIAdmin.Prototypes.Web.Models;
using StackExchange.Profiling;

namespace DLIAdmin.Prototypes.Web.Prototype
{
    public class BrugerdataSqlFacade
    {
        private const int PageSize = 50;

        public Bruger LoadUser(Guid id)
        {
            var profiler = MiniProfiler.Current; 
            using (profiler.Step("BrugerdataSqlFacade.LoadUser"))
            {
                using (var context = new BrugerDatabaseContext())
                {
                    var user = context.Brugers.Find(id);
                    return user;
                }
            }
        }

        public List<Bruger> Find(string query)
        {
            var profiler = MiniProfiler.Current;
            using (profiler.Step("BrugerdataSqlFacade.Find  "))
            {
                using (var context = new BrugerDatabaseContext())
                {
                    var users = context.Brugers.Where(user => user.ADLogonname.Contains(query)).Take(PageSize);
                    return users.ToList();
                }
            }
        }
    }
}