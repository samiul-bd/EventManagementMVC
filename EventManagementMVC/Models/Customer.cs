using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventManagementMVC.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string MobileNo { get; set; }       
        public virtual ICollection<Event> Events { get; set; }
    }
}