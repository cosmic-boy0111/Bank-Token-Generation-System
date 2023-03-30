using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace Server.Controllers
{
    public enum Status
    {
        Pending,
        NoShow,
        BeingServiced,
        Serviced,
        Abandoned
    }

    public class Token
    {
        public int TokenNumber { get; set; }
        public string Service { get; set; }
        public Status status { get; set; }
        public int WaitingTime { get; set; }
        public int NoShowCount { get; set; }
    }

}