using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EstheticWeb.Models
{
    public class DentalContext: DbContext
    { // We will create a Constructor to connect to Database
        public DentalContext()
            : base("DefaultConnection")
        {
        }

        // For everytable that we create in the model, we should agregate more Dbset 
        public DbSet<State> States { get; set; }
        
    }
}