using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventManagementMVC.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public decimal Budget { get; set; }
        public string ImageUrl { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public bool IsMultipleProgramEvent { get; set; }
        public Nullable<int> CustomerId { get; set; }

        public virtual Customer Customer { get; set; }       
        public virtual ICollection<Program> Programs { get; set; }
    }
}