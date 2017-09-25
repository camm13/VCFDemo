using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VCFDemo.Models
{
    public class VCFDemoContext : DbContext
    {
        public VCFDemoContext (DbContextOptions<VCFDemoContext> options)
            : base(options)
        {
        }

        public DbSet<VCFDemo.Models.Product> Product { get; set; }
    }
}
