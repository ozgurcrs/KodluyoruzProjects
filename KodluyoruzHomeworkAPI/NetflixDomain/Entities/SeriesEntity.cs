using NetflixDomain.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetflixWebApi.Entities
{
    public class SeriesEntity : IEntity
    {
        public int ID { get; set; }
        public string SeriesName { get; set; }

        public int Season { get; set; }

        public bool isFinished { get; set; }
        
    }
}
