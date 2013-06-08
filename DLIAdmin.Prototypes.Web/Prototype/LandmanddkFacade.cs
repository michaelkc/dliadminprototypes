using System;
using System.Configuration;
using System.Net.Http;
using System.Web;
using System.Web.Caching;
using System.Xml.Serialization;
using StackExchange.Profiling;

namespace DLIAdmin.Prototypes.Web.Prototype
{
    public class LandmanddkFacade
    {
        private const string Key = "ldkportalservice";
        public PortalServices LoadPortalServices()
        {
            var profiler = MiniProfiler.Current;
            using (profiler.Step("LandmanddkFacade.LoadPortalServices"))
            {
                //Thread.Sleep(TimeSpan.FromSeconds(10));
                var portalservices = HttpRuntime.Cache[Key] as PortalServices;
                return portalservices;
            }
        }

        public static void InitializeCache()
        {
            using (var client = new HttpClient())
            {
                using (
                    var responseStream =
                        client.GetStreamAsync(ConfigurationManager.AppSettings["LDKPortalServiceInfoUrl"]).Result)
                {
                    var serializer = new XmlSerializer(typeof(PortalServices));
                    var portalServices = (PortalServices)serializer.Deserialize(responseStream);
                    HttpRuntime.Cache.Insert(Key, portalServices, null, DateTime.Now.AddHours(12), Cache.NoSlidingExpiration);
                }
            }
        }
    }
}