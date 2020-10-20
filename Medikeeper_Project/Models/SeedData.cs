using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Medikeeper_Project.Data;
using System;
using System.Linq;
using Medikeeper_Project.Models;

namespace Medikeeper_Project.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WellnessShopContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WellnessShopContext>>()))
            {
                // Look for any movies.
                if (context.Store.Any())
                {
                    return;   // DB has been seeded
                }

                context.Store.AddRange(
                    new Store
                    {
                        Name = "Vitamin",
                        Cost = 14.99M
                    },

                    new Store
                    {
                        Name = "Supplement",
                        Cost = 23.99M
                    },

                    new Store
                    {
                        Name = "Supplement",
                        Cost = 14.99M
                    },

                    new Store
                    {
                        Name = "Vitamin",
                        Cost = 7.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}