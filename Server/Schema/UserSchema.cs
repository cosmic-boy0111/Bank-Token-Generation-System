using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Schema
{
    public class UserSchema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string Password { get; set; }

        public string Role { get; set; }
    }
}