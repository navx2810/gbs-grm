using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jose;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GRM.Controllers
{
    class Claim
    {
        public string id { get; set; }
        public long? exp { get; set; }
    }
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        public static byte[] Key = Encoding.ASCII.GetBytes("s3c3rtk3y");
        // GET api/values
        [HttpGet]
        public string Get()
        {

            var headers = new Dictionary<string, object>();
            var exp = DateTime.Now.AddHours(4).ToFileTime();
            var payload = new Claim { id = "209d9al", exp = exp };
            var str = Jose.JWT.Encode(payload, Key, JwsAlgorithm.HS256);
            HttpContext.Response.Cookies.Append("token", str, new CookieOptions { Expires = DateTime.Now.AddHours(4) });
            return str;
        }

        [HttpGet("test")]
        public string GetTest()
        {
            var token = JWT.Decode(Request.Cookies["token"], Key);
            var claim = Newtonsoft.Json.JsonConvert.DeserializeObject<Claim>(token);
            if(claim == null || claim.exp == null || DateTime.FromFileTime(claim.exp.Value) < DateTime.Now )
                return "nope";
            return token;
        }

    }
}
