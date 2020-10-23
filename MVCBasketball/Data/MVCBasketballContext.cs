using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCBasketball.Models;

namespace MVCBasketball.Data
{
    public class MVCBasketballContext : DbContext
    {
        public MVCBasketballContext (DbContextOptions<MVCBasketballContext> options)
            : base(options)
        {
        }

        public DbSet<MVCBasketball.Models.Raptors> Raptors { get; set; }
    }
}
