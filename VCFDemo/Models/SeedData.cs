using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VCFDemo.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)

        {

            using (var context = new VCFDemoContext(
                serviceProvider.GetRequiredService<DbContextOptions<VCFDemoContext>>()))
        {
            // Look for any movies.
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }

            context.Product.AddRange(
                 new Product
                 {
                     Name = "When Harry Met Sally",
                     Info = "Romantic Comedy",
                     Price = 7.99M
                 },

                 new Product
                 {
                     Name = "Ghostbusters ",
                     Info = "Comedy",
                     Price = 8.99M
                 },

                 new Product
                 {
                     Name = "Ghostbusters 2",
                     Info = "Comedy",
                     Price = 9.99M
                 },

               new Product
               {
                   Name = "Rio Bravo",
                   Info = "Western",
                   Price = 3.99M
               }
            );
            context.SaveChanges();
        }
    }
}
}