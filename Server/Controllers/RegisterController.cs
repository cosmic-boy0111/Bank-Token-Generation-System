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
using RouteAttribute = System.Web.Http.RouteAttribute;
using RoutePrefixAttribute = System.Web.Http.RoutePrefixAttribute;


namespace Server.Controllers
{
    [RoutePrefix("api/register")]
    public class RegisterController : ApiController
    {
        BankModelsContainer db = new BankModelsContainer();

        [HttpPost]
        [Route("Register")]
        public IHttpActionResult Register([FromBody] UserSchema user)
        {
            User u = new User() { 
                Name = user.Name,
                AccountNumber= user.AccountNumber,
                Password= user.Password,
            };
            
            db.Users.Add(u);
            db.SaveChanges();

            string userData = "Gauarv:12345"; 

            HttpCookie authCookie = new HttpCookie("myAuthCookie", userData);
            authCookie.Expires = DateTime.Now.AddDays(30);
            HttpContext.Current.Response.Cookies.Add(authCookie);

            return Ok(user);
        }


    }
}