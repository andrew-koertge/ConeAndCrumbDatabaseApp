using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConeAndCrumbDatabaseApp.Models
{
    public class IceCream
    {
        public int IceCreamID { get; set; }
        public string IceCreamName { get; set; }
        public int IceCreamInventoryCount { get; set; }
        public double IceCreamSales { get; set; }
    }
}