using Microsoft.Extensions.DependencyInjection;
using NetflixWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetflixWebApi.Context.SampleData
{
    public static class SeriesSampleData
    {

        public static async Task InitializeAsyncSeriesData(IServiceProvider service)
        {
            await addSeries(service.GetRequiredService<NetflixDB>());
        }

        public static async Task addSeries(NetflixDB dbContext)
        {
            if (dbContext.Series.Any())
                return;


            dbContext.Series.Add(new SeriesEntity
            {
                ID=1,
                SeriesName="Breaking Bad",
                isFinished=true,
                Season = 5
                
            });
            dbContext.Series.Add(new SeriesEntity
            {
                ID = 2,
                SeriesName = "Supernatural",
                isFinished = true,
                Season = 10

            });
            dbContext.Series.Add(new SeriesEntity
            {
                ID = 3,
                SeriesName = "Game of thrones",
                isFinished = true,
                Season = 8

            });
         

            await dbContext.SaveChangesAsync();

        }
    }
}
