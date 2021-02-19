using Microsoft.Extensions.DependencyInjection;
using NetflixWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetflixWebApi.Context.SampleData
{
    public static class MovieSampleData
    {

        public static async Task InitializeAsyncData(IServiceProvider service)
        {
            await addMovie(service.GetRequiredService<NetflixDB>());
        }

        public static async Task addMovie(NetflixDB dbContext)
        {
            if (dbContext.Movies.Any())
                return;


            dbContext.Movies.Add(new MovieEntity
            {
                ID=1,
                MovieTitle="Spiderman",
                Description="Lorem ipsum very nice movie",
                Year="2004"
            });
            dbContext.Movies.Add(new MovieEntity
            {
                ID = 2,
                MovieTitle = "Hulk",
                Description = "Information is power",
                Year = "2012"
            });
            dbContext.Movies.Add(new MovieEntity
            {
                ID = 3,
                MovieTitle = "Iron Man",
                Description = "One kilos iron is weight than One kilo cotton :(",
                Year = "2018"
            });
            dbContext.Movies.Add(new MovieEntity
            {
                ID = 4,
                MovieTitle = "Batman And Joker",
                Description = "Money is money",
                Year = "2024"
            });
            dbContext.Movies.Add(new MovieEntity
            {
                ID = 5,
                MovieTitle = "Esra Erol Tüm Kesitler",
                Description = "12 Yıl Arşivi",
                Year = "2019"
            });

            await dbContext.SaveChangesAsync();

        }
    }
}
