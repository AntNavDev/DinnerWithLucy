using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DinnerWithLucy.Models
{
    public class DinnerWithLucyContext : DbContext
    {
        public DinnerWithLucyContext (DbContextOptions<DinnerWithLucyContext> options)
            : base(options)
        {
        }

        public DbSet<DinnerWithLucy.Models.Recipe> Recipe { get; set; }
    }
}
