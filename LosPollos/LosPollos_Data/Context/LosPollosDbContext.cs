
using LosPollos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LosPollos.Context
{
    public class LosPollosDbContext : DbContext
    {
        public LosPollosDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }

    }
}
