using CodeConventionsSample.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CodeConventionsSample.WebApi.Controllers
{
    [RoutePrefix("api/Sample")]
    public class SampleController : ApiController
    {
        private const string LocalLoginProvider = "Local";
        private ISampleManager _Manager;

        public SampleController(ISampleManager SampleManager)
        {
            _Manager = SampleManager;
        }

        [Route("Test")]
        public int Calculate()
        {
            var param = new List<string>() { "val1", "va2", "batata", "cacau", "cenas_malucas" };

            return _Manager.DoSomeCalculations(param);
        }

        [Route("Magic")]
        public string Validate(string HTMLTag)
        {
            if(string.IsNullOrEmpty(HTMLTag)) { return "invalid"; }

            return null;
        }
    }
}
