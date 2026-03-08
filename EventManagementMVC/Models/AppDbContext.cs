using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventManagementMVC.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext():base("name=EventManagementDbConnection")
        {
            
        }
        DbSet<Customer> customers {  get; set; }
        DbSet<Event> eventss {  get; set; }
        DbSet<Program> programs {  get; set; }
        DbSet<User> users {  get; set; }
    }
}