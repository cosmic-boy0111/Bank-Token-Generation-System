using Server.Models;
using Server.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services.Description;

namespace Server.Controllers
{
    [RoutePrefix("api/customer")]
    public class CustomerController : ApiController
    {
        BankModelsContainer db = new BankModelsContainer();

        public int GenerateRandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 99999);
        }

        [HttpPost]
        [Route("generateToken")]
        public IHttpActionResult generateToken([FromBody] TokenSchema ts)
        {
            //Token t = new Token()
            //{

            //};

            return Ok();
        }

    }
}
