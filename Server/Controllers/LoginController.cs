using Server.Models;
using Server.Schema;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;
using RoutePrefixAttribute = System.Web.Http.RoutePrefixAttribute;

namespace Server.Controllers
{
    [RoutePrefix("api/login")]
    public class LoginController : ApiController
    {
        // GET: Login
        BankModelsContainer db = new BankModelsContainer();

        [HttpPost]
        [Route("Login")]
        public IHttpActionResult Login([FromBody] UserSchema user)
          {
            foreach (var item in db.Users)
            {
                if (item.Name == user.Name && item.Password == user.Password)
                {
                    return Ok(user);     
                }

            }


            return Ok("User Not Found");
           
        }
    }
}