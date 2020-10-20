using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Medikeeper_Project.Models;

namespace Medikeeper_Project.Data
{
    public class Medikeeper_ProjectContext : DbContext
    {
        public Medikeeper_ProjectContext (DbContextOptions<Medikeeper_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Medikeeper_Project.Models.Store> Store { get; set; }
    }
}
