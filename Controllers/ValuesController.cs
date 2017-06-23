using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jose;
using Microsoft.AspNetCore.Mvc;

namespace GRM.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            var headers = new Dictionary<string, object>();
            headers["exp"] = DateTime.Now.AddHours(4).ToFileTime();
            var payload = new { Id = "209d9al" };
            var str = Jose.JWT.Encode(payload, "s3c3rtk3y", JwsAlgorithm.none, headers);
            HttpContext.Request.Headers.Add("Authorization", "Bearer " + str);
            return str;
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
