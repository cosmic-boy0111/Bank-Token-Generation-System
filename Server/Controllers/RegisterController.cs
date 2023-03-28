﻿using Server.Models;
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
    public class RegisterController : ApiController
    {
        BankModelsContainer db = new BankModelsContainer();

        [HttpGet]
        public IHttpActionResult Message()
        {
            return Ok("Hello world");
        }

        [HttpPost]
        public IHttpActionResult Register([FromBody] UserSchema user)
        {
            User u = new User() { 
                Name = user.Name,
                AccountNumber= user.AccountNumber,
                Password= user.Password,
            };
            
            db.Users.Add(u);
            db.SaveChanges();

            return Ok(user);
        }


    }
}