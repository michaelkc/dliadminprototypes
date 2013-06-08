using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData.Query;
using DLIAdmin.Prototypes.Web.Models;
using StackExchange.Profiling;

namespace DLIAdmin.Prototypes.ServiceApi.Controllers
{
    public class BrugereController : ApiController
    {
        private readonly BrugerDatabaseContext _db;

        public BrugereController()
        {
            _db = new BrugerDatabaseContext();
            _db.Configuration.LazyLoadingEnabled = false;
        }

        // GET api/Brugerapi
        public IQueryable<Bruger> GetBrugere(ODataQueryOptions options)
        {
            var profiler = MiniProfiler.Current;
            using (profiler.Step("GetBrugere"))
            {
                var settings = new ODataValidationSettings()
                    {
                        MaxTop = 1000
                    };

                options.Validate(settings);

                IQueryable results = options.ApplyTo(_db.Brugers.AsQueryable());
                return results as IQueryable<Bruger>;
            }
        }

        // GET api/Brugerapi/5
        public Bruger GetBruger(Guid id)
        {
            Bruger bruger = _db.Brugers.Find(id);
            if (bruger == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return bruger;
        }

        // PUT api/Brugerapi/5
        public HttpResponseMessage PutBruger(Guid id, Bruger bruger)
        {
            if (!ModelState.IsValid)
            {   
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != bruger.ID)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            _db.Entry(bruger).State = EntityState.Modified;

            try
            {
                _db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // POST api/Brugerapi
        public HttpResponseMessage PostBruger(Bruger bruger)
        {
            if (ModelState.IsValid)
            {
                _db.Brugers.Add(bruger);
                _db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, bruger);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = bruger.ID }));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // DELETE api/Brugerapi/5
        public HttpResponseMessage DeleteBruger(Guid id)
        {
            Bruger bruger = _db.Brugers.Find(id);
            if (bruger == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            _db.Brugers.Remove(bruger);

            try
            {
                _db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, bruger);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}