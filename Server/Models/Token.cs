//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Server.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Token
    {
        public int Id { get; set; }
        public int TokenNo { get; set; }
        public string ServiceName { get; set; }
        public int Status { get; set; }
        public int WaitingTime { get; set; }
        public int NoShowCount { get; set; }
    }
}
