using NetflixDomain.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetflixWebApi.Entities
{
    public class MovieEntity : IEntity
    {
        public int ID { get; set; }
        public string MovieTitle { get; set; }
        public string Description { get; set; }
        public string Year { get; set; }


    }
}
