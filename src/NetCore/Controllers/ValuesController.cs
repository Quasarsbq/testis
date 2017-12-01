using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace NetCore.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            while (true)
            {
                System.Net.WebRequest request = WebRequest.Create("http://mohemnis.somee.com/");
                System.Net.WebRequest request1 = WebRequest.Create("http://canada-d12.193b.starter-ca-central-1.openshiftapps.com/api/values");
                request.GetResponseAsync();
                request1.GetResponseAsync();
                new System.Threading.ManualResetEvent(false).WaitOne(180000);
                return new string[] { "done", "ma noxodino" };
            }
        }
       

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
