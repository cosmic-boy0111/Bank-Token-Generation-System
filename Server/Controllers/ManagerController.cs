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

namespace Server.Controllers
{
    public class ManagerController : ApiController
    {
        BankModelsContainer db = new BankModelsContainer();
        // GET: Manager


        [HttpGet]
        public IHttpActionResult AllServices()
        {
            var Records = from records in db.services select records;
            return Ok(Records.ToList());
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

        [HttpDelete]
        public void DeleteService([FromBody] ServiceSchema sId)
        {
            var records = from record in db.services select record;

            foreach(var item in records)
            {
                if(item.Id == sId.Id)
                {
                    db.services.Remove(item);
                    db.SaveChanges();
                }
            }
        }

        [HttpPut]
        public IHttpActionResult UpdateService([FromBody] ServiceSchema ser)
        {
            var records = from record in db.services select record;

            foreach (var item in records)
            {
                if (item.Id == ser.Id)
                {
                    item.Name = ser.Name;
                    item.Time = ser.Time;
                    db.SaveChanges();
                }
            }
            return Ok(records.ToList());
        }

    }
}