using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechList.Entities.Concrete;

namespace TechList.DataAccess.Context
{
    public class TechListContext : DbContext
    {
        // DI için constructor
        public TechListContext(DbContextOptions<TechListContext> options) : base(options)
        {
        }

        // Migration veya diğer durumlarda kullanım için
        public TechListContext()
        {
        }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Notebook> Notebooks { get; set; }
    }
}
