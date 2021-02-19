using LosPollos.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LosPollos.Context.Data
{
    public static class SampleData
    {

        public static async Task InitializeAsync(IServiceProvider service)
        {
            await AddSampleData(service.GetRequiredService<LosPollosDbContext>());
        }

        public static async Task AddSampleData(LosPollosDbContext dbContext)
        {
            if (dbContext.Products.Any())
                return;

            dbContext.Products.Add(new ProductEntity { 
                ID = Guid.NewGuid(),
                Name = "Double Hambuger",
                Price = 10,
                Stok = 100
            });

            dbContext.Products.Add(new ProductEntity
            {
                ID = Guid.NewGuid(),
                Name = "Ground Hambuger",
                Price = 18,
                Stok = 33
            });

            dbContext.Products.Add(new ProductEntity
            {
                ID = Guid.NewGuid(),
                Name = "Sirloin Hambuger",
                Price = 14,
                Stok = 45
            });

            await dbContext.SaveChangesAsync();


        }
    }
}
