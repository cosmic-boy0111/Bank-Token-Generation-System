using Server.Models;
using Server.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace Server.Controllers
{
    public class ManagerController : ApiController
    {
        BankModelsContainer db = new BankModelsContainer();
        // GET: Manager

        [HttpGet]
        public IHttpActionResult Message()
        {
            return Ok("Hello world");
        }

        [HttpPost]
        public IHttpActionResult AddService([FromBody] ServiceSchema ser)
        {
            service data = new service()
            {
                Name = ser.Name,
                Time = ser.Time,
            };

            db.services.Add(data);
            db.SaveChanges();

            return Ok(ser);

        }
    }
}