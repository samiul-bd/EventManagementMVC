using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventManagementMVC.Models
{
    public class Program
    {
        public int ProgramsId { get; set; }
        public string ProgramsName { get; set; }
        public int EventId { get; set; }
        public int Duration { get; set; }
        public virtual Event Event { get; set; }
    }
}
