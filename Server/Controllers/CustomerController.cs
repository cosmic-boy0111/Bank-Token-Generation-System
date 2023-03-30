using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services.Description;

namespace Server.Controllers
{
    public class CustomerController : ApiController
    {
        BankModelsContainer db = new BankModelsContainer();
        public List<Service> GetServicesList()
        {
            var Records = from records in db.services select records;
            return (List<Service>)Records;
        }
    }
}
