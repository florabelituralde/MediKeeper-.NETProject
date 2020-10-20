using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medikeeper_Project.Models;

namespace Medikeeper_Project.Data
{
    public class WellnessShopContext : DbContext
    {
        public WellnessShopContext(DbContextOptions<WellnessShopContext> options)
            : base(options)
        {
        }

        public DbSet<Store> Store { get; set; }
    }
}
