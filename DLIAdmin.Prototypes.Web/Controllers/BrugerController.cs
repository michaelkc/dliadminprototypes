using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using DLIAdmin.Prototypes.Web.Models.ViewModels;
using DLIAdmin.Prototypes.Web.Prototype;
using StackExchange.Profiling;

namespace DLIAdmin.Prototypes.Web.Controllers
{
    public class BrugerController : Controller
    {
        private readonly BrugerdataSqlFacade _brugerdataSqlFacade;
        private readonly LandmanddkFacade _landmanddkFacade;
        private readonly BrugerdataAdFacade _brugerdataAdFacade;
        private readonly AbonnementsdataSqlFacade _abonnementsdataSqlFacade;
        private readonly RelationSqlFacade _relationSqlFacade;
        private const int MaxProcessingTime = 2000;

        public BrugerController(BrugerdataSqlFacade brugerdataSqlFacade, LandmanddkFacade landmanddkFacade, BrugerdataAdFacade brugerdataAdFacade, AbonnementsdataSqlFacade abonnementsdataSqlFacade, RelationSqlFacade relationSqlFacade)
        {
            _brugerdataSqlFacade = brugerdataSqlFacade;
            _landmanddkFacade = landmanddkFacade;
            _brugerdataAdFacade = brugerdataAdFacade;
            _abonnementsdataSqlFacade = abonnementsdataSqlFacade;
            _relationSqlFacade = relationSqlFacade;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string query)
        {
            var users = _brugerdataSqlFacade.Find(query);
            return View(users);
        }

        public ActionResult Details(Guid id)
        {
            var profiler = MiniProfiler.Current;
            using (profiler.Step("BrugerController Details"))
            {
                var viewModel = new BrugerDetailViewModel();
                var log = new TimingLog();
                log.Stamp("Start");
                var userTask = new Task(() =>
                    {                   
                        log.Stamp("Load user start");
                        var user = _brugerdataSqlFacade.LoadUser(id);
                        viewModel.User = user;
                        log.Stamp("Load user end");
                    }
                    );
                var brugerdataAdFacadeTask = new Task(() =>
                    {
                        log.Stamp("Load user SQL start");
                        viewModel.AdUser = _brugerdataAdFacade.LoadUser(viewModel.User.ADLogonname);
                        log.Stamp("Load user SQL end");
                    });

                var portalServiceTask = new Task(() =>
                {
                    log.Stamp("Load portalservices start");
                    viewModel.PortalServices = _landmanddkFacade.LoadPortalServices();
                    log.Stamp("Load portalservices end");
                });

                var relationsTask = new Task(() =>
                {
                    log.Stamp("Load relations start");
                    viewModel.Relations = _relationSqlFacade.LoadRelations(id);
                    log.Stamp("Load relations end");
                });
                var subscriptionsTask = new Task(() =>
                {
                    log.Stamp("Load subscriptions start");
                    viewModel.Subscriptions = _abonnementsdataSqlFacade.LoadSubscriptions(id);
                    log.Stamp("Load subscriptions end");
                });
                userTask.Start();
                userTask.Wait();
                brugerdataAdFacadeTask.Start();
                brugerdataAdFacadeTask.Wait();      
                var tasks = new[] { portalServiceTask, relationsTask, subscriptionsTask };
                foreach (var task in tasks)
                {
                    task.Start();
                }
                
                var allCompleted = Task.WaitAll(tasks,MaxProcessingTime);

                viewModel.DegradedMode = !allCompleted;
                log.Stamp("End");
                viewModel.Timings = log.Dump();
                if (viewModel.User == null)
                {
                    return HttpNotFound();
                }
                return View(viewModel);
            }
        }
    }
}