using System.Web.Mvc;
using DLIAdmin.Prototypes.Web.Prototype;
using Microsoft.Practices.Unity;
using Unity.Mvc3;

namespace DLIAdmin.Prototypes.Web
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();            
            container.RegisterType<AbonnementsdataSqlFacade>();
            container.RegisterType<BrugerdataAdFacade>();
            container.RegisterType<BrugerdataSqlFacade>();
            container.RegisterType<LandmanddkFacade>();
            container.RegisterType<RelationSqlFacade>();
            return container;
        }
    }
}