using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DLIAdmin.Prototypes.Web.Prototype;
using StackExchange.Profiling;
using StackExchange.Profiling.Storage;

namespace DLIAdmin.Prototypes.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Bootstrapper.Initialise();

            MiniProfiler.Settings.Storage = new SqlServerStorage(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\cloudtfs\dliadmin_project\Web_Prototype\trunk\Source\DLIAdmin.Prototypes.Web\App_Data\Profile.mdf;Integrated Security=True");
            MiniProfilerEF.Initialize() ;
                
            LandmanddkFacade.InitializeCache();
        }

        protected void Application_BeginRequest()
        {
            if (Request.IsLocal)
            {
                MiniProfiler.Start();
            }
        }

        protected void Application_EndRequest()
        {
            MiniProfiler.Stop();
        }
    }
}