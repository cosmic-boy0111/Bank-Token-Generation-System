using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Server.Controllers
{
    [Route("api/WaitingRoom/")]
    public class WaitingRoomController : ApiController
    {

        BankModelsContainer db = new BankModelsContainer();

        [HttpGet]
        [Route("WaitingRoom")]


        public IHttpActionResult GetAllToken()
        {
            var TokenRecords = from Record in db.Tokens select Record;
            return Ok(TokenRecords.ToList());
        }


    }
}
