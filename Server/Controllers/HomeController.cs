using Server.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;
using RoutePrefixAttribute = System.Web.Http.RoutePrefixAttribute;

namespace Server.Controllers
{
    [RoutePrefix("api/home")]
    public class HomeController : ApiController
    {

        //[HttpGet]
        //[Route("get")]
        //public IHttpActionResult GetService()
        //{
        //    // Get service logic here using the id parameter
        //    return Ok("hello world");
        //}

        //[HttpGet]
        //[Route("get2")]
        //public IHttpActionResult GetService2()
        //{
        //    // Get service logic here using the id parameter
        //    return Ok("hello world2");
        //}


        // GET: Home
        [HttpPost]
        [Route("msg1")]
        public IHttpActionResult getMessage1([FromBody] ServiceSchema sr) 
        {
            return Ok(sr);
        }

        [HttpPost]
        [Route("msg2")]
        public IHttpActionResult getMessage2([FromBody] ServiceSchema sr2)
        {
            return Ok(sr2);
        }

    }
}