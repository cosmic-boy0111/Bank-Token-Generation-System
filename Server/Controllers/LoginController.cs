using Server.Models;
using Server.Schema;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.Services.Description;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
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
        public IHttpActionResult Login([FromBody] UserSchema user){

            foreach (var item in db.Users)
            {
                if (item.Name == user.Name && item.Password == user.Password)
                {

                    return Ok(item);     

                }

            }
            return Ok( new MessageSchema() { Message = "User not found",  status = 400} );
           
        }

        [HttpPost]
        [Route("getUser")]

        public IHttpActionResult GetUser([FromBody] UserSchema user_id)
        {
            var user = db.Users.SingleOrDefault(u => u.Id == user_id.Id);
            if(user == null)
            {
                return Ok(new MessageSchema()
                {
                    Message = "User not found",
                    status = 400
                });
            }
            return Ok(user);
        }



    }
}