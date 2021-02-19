using LosPollos.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LosPollos.Context.Data
{
    public static class SampleOrderData
    {
        public static async Task InitializeAsyncOrderData(IServiceProvider service)
        {
            await AddOrderData(service.GetRequiredService<LosPollosDbContext>());
        }
        public static async Task AddOrderData(LosPollosDbContext orderDbContext)
        {
            if (orderDbContext.Orders.Any())
                return;

            orderDbContext.Orders.Add(new OrderEntity
            {
                ID = Guid.NewGuid(),
                Date = DateTime.Now,
                FoodName = "Double Hambuger",
                DeliveryAddress = "İstanbul",
                Quantity = 1,
                Price = 10
            });


            orderDbContext.Orders.Add(new OrderEntity
            {
                ID = Guid.NewGuid(),
                Date = DateTime.Now,
                FoodName = "Double Hambuger",
                DeliveryAddress = "İstanbul",
                Quantity = 2,
                Price = 20
            });


            await orderDbContext.SaveChangesAsync();




        }
    }
}
