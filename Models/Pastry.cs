using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ConeAndCrumbDatabaseApp.Models
{
    public class Pastry
    {
        public int PastryID { get; set; }
        public string PastryName { get; set; }
        public string PastryType { get; set; }
        public int PastryInventoryCount { get; set; }
        public double PastrySales { get; set; }
    }

    public class PastriesDbContext : ApplicationDbContext
    {
        public DbSet<Pastry> Pastries { get; set; }
    }
}