using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace run_job.Controllers
{
    [Route("api/[controller]")]
    public class Run : Controller
    {
        // GET api/Run
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Run/5
        [HttpGet("{token}/{jobid}"), HttpPost("{token}/{jobid}")]
        public string Get(string token, string jobid)
        {
            string host = $"http://localhost:4440/api/26/job/{jobid}/run";

            var client = new RestClient(host);
            var req = new RestRequest(Method.POST);
            req.AddHeader("accept", "application/json");
            req.AddHeader("x-rundeck-auth-token", token);

            var resp = client.Execute(req);
            return resp.Content;;
        }

    }
}
