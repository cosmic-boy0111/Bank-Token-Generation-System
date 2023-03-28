using Server.Models;
using Server.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpDeleteAttribute = System.Web.Http.HttpDeleteAttribute;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using HttpPutAttribute = System.Web.Http.HttpPutAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;
using RoutePrefixAttribute = System.Web.Http.RoutePrefixAttribute;

namespace Server.Controllers
{
    [RoutePrefix("api/manager")]
    public class ManagerController : ApiController
    {
        BankModelsContainer db = new BankModelsContainer();
        // GET: Manager


        [HttpGet]
        [Route("allServices")]
        public IHttpActionResult AllServices()
        {
            var Records = from records in db.services select records;
            return Ok(Records.ToList());
        }


        [HttpPost]
        [Route("addService")]
        public IHttpActionResult AddService([FromBody] ServiceSchema ser)
        {
            service data = new service()
            {
                Name = ser.Name,
                Time = ser.Time,
            };

            db.services.Add(data);
            db.SaveChanges();

            return Ok(data);

        }

        [HttpPost]
        [Route("deleteService")]
        public IHttpActionResult DeleteService([FromBody] ServiceSchema sId)
        {
            var service =  db.services.SingleOrDefault(s => s.Id == sId.Id);
            db.services.Remove(service);
            db.SaveChanges();

            return Ok(db.services.ToArray());

        }

        [HttpPost]
        [Route("updateService")]
        public IHttpActionResult UpdateService([FromBody] ServiceSchema ser)
        {

            var service = db.services.SingleOrDefault(s => s.Id == ser.Id);
            service.Name = ser.Name;
            service.Time = ser.Time;

            db.SaveChanges();

            return Ok(service);
        }

    }
}