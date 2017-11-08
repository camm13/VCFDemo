using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VCF.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}