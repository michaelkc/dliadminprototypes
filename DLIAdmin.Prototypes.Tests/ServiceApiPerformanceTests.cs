using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Security;
using DLIAdmin.Prototypes.Web.Models;
using NUnit.Framework;
using Newtonsoft.Json;

namespace DLIAdmin.Prototypes.Tests
{
    [TestFixture]
    public class ServiceApiPerformanceTests
    {
        private const string HostUrl = "http://localhost:1913/api/";
        private readonly Encoding _encoding = Encoding.UTF8;

        [Test]
        public void TestListPerformanceHttpClient()
        {
            var timer = new Stopwatch();

            var c = new HttpClient
                {
                    BaseAddress = new Uri(HostUrl)
                };
            timer.Start();
            var resultMessage = c.GetAsync("brugere?$top=1&$filter=substringof('mactest001',ADLogonname)%20eq%20true").Result;
            var result = resultMessage.Content.ReadAsStringAsync().Result;
            var timing = timer.ElapsedMilliseconds;

            Assert.IsNotNull(result);
            Console.WriteLine("{0}ms", timing);
            Console.WriteLine(result);
        }

        [Test]
        public void TestListPerformanceWebClient()
        {
            var timer = new Stopwatch();

            using (var client = new WebClient())
            {
                timer.Start();
                var resultBytes = client.DownloadData(string.Format("{0}brugere?$top=1&$filter=substringof('mactest001',ADLogonname)%20eq%20true", HostUrl));
                var result = _encoding.GetString(resultBytes);
                var timing = timer.ElapsedMilliseconds;
                Assert.IsNotNull(result);
                Console.WriteLine("{0}ms", timing);
                Console.WriteLine(result);
            }
        }

        [Test]
        public void TestUpdatePerformance()
        {
            var timer = new Stopwatch();
            using (var client = new WebClient())
            {
                var data = client.DownloadData(string.Format("{0}brugere?$top=1&$filter=substringof('mactest001',ADLogonname)%20eq%20true", HostUrl));
                var str = _encoding.GetString(data);
                var brugere = JsonConvert.DeserializeObject<Bruger[]>(str);
                var brugerToUpdate = brugere.Single();
                brugerToUpdate.Note = string.Format("Opdateret af prototype {0}", DateTime.Now.ToLongTimeString());
                var jsonBruger = JsonConvert.SerializeObject(brugerToUpdate);
                var jsonBrugerBytes = _encoding.GetBytes(jsonBruger);
                client.Headers.Add(HttpRequestHeader.ContentType, "application/json; charset=utf-8");
                timer.Start();

                var resultBytes = client.UploadData(string.Format("{1}brugere/{0}", brugerToUpdate.ID, HostUrl), "PUT",
                        jsonBrugerBytes);
                var result = _encoding.GetString(resultBytes);
                var timing = timer.ElapsedMilliseconds;
                Assert.IsNotNull(result);
                Console.WriteLine("{0}ms", timing);
                Console.WriteLine(result);
            }
        }

        [Test]
        public void TestBulkQueryPerformanceWithinQASLimit()
        {
            const int iterations = 100;
            TimeSpan maxTimeAllowed = TimeSpan.FromMilliseconds(500);
            var timer = new Stopwatch();
            using (var client = new WebClient())
            {
                var data = client.DownloadData(string.Format("{1}brugere?$top={0}&$orderby=ADLogonname%20desc", iterations, HostUrl));
                var str = _encoding.GetString(data);
                var brugere = JsonConvert.DeserializeObject<Bruger[]>(str);

                var timings = new Dictionary<string, TimeSpan>();
                foreach (var brugerToQuery in brugere)
                {
                    client.Headers.Add(HttpRequestHeader.ContentType, "application/json; charset=utf-8");
                    timer.Restart();

                    var uri = string.Format("{1}brugere?$filter=indexof(ADLogonname,'{0}')%20ge%200", brugerToQuery.ADLogonname, HostUrl);
                    var resultBytes = client.DownloadData(uri);

                    var result = _encoding.GetString(resultBytes);
                    var timing = timer.Elapsed;
                    timings.Add(brugerToQuery.ADLogonname, timing);
                    Assert.IsNotNull(result);
                }
                var msTimings = timings.Select(t => t.Value.TotalMilliseconds).ToArray();
                Console.WriteLine("Min: {0}, Max: {1}, Avg: {2}", msTimings.Min(), msTimings.Max(), msTimings.Average());
                Console.WriteLine();
                foreach (var userTiming in timings.OrderBy(t => t.Key))
                {
                    var hashedUsername = FormsAuthentication.HashPasswordForStoringInConfigFile(userTiming.Key, "sha1");
                    Console.WriteLine("{0};{1}", hashedUsername, Math.Ceiling(userTiming.Value.TotalMilliseconds));
                }
                Assert.Less(msTimings.Max(), maxTimeAllowed.TotalMilliseconds);
            }
        }

        [Test]
        public void TestBulkUpdatePerformanceWithinQASLimit()
        {
            const int iterations = 100;
            TimeSpan maxTimeAllowed = TimeSpan.FromMilliseconds(500);
            var timer = new Stopwatch();
            using (var client = new WebClient())
            {
                var data = client.DownloadData(string.Format("{1}brugere?$top={0}&$orderby=ADLogonname%20desc", iterations, HostUrl));
                var str = _encoding.GetString(data);
                var brugere = JsonConvert.DeserializeObject<Bruger[]>(str);
                var timings = new Dictionary<string, TimeSpan>();
                foreach (var brugerToUpdate in brugere)
                {
                    brugerToUpdate.Note = string.Format("Opdateret af prototype {0}", DateTime.Now.ToLongTimeString());
                    var jsonBruger = JsonConvert.SerializeObject(brugerToUpdate);
                    var jsonBrugerBytes = _encoding.GetBytes(jsonBruger);
                    client.Headers.Add(HttpRequestHeader.ContentType, "application/json; charset=utf-8");
                    timer.Restart();

                    var resultBytes = client.UploadData(string.Format("{1}brugere/{0}", brugerToUpdate.ID, HostUrl), "PUT", jsonBrugerBytes);
                    var result = _encoding.GetString(resultBytes);
                    var timing = timer.Elapsed;
                    timings.Add(brugerToUpdate.ADLogonname, timing);
                    Assert.IsNotNull(result);
                }
                var msTimings = timings.Select(t => t.Value.TotalMilliseconds).ToArray();
                Console.WriteLine("Min: {0}, Max: {1}, Avg: {2}", msTimings.Min(), msTimings.Max(), msTimings.Average());
                Console.WriteLine();
                foreach (var userTiming in timings.OrderBy(t => t.Key))
                {
                    var hashedUsername = FormsAuthentication.HashPasswordForStoringInConfigFile(userTiming.Key, "sha1");
                    Console.WriteLine("{0};{1}", hashedUsername, Math.Ceiling(userTiming.Value.TotalMilliseconds));
                }
                Assert.Less(msTimings.Max(), maxTimeAllowed.TotalMilliseconds);
            }
        }
    }
}
