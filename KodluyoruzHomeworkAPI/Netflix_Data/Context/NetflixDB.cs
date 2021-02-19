using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NetflixWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetflixWebApi.Context
{
    public class NetflixDB : DbContext
    {
        public NetflixDB(DbContextOptions options) : base(options)
        {
                
        }

        

        public DbSet<MovieEntity> Movies { get; set; }
        public DbSet<SeriesEntity> Series { get; set; }

    }
}
