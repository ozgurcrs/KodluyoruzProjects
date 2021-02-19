using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Netflix_Service.Repository.Core;
using NetflixWebApi.Context;
using NetflixWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NetflixWebApi.Services
{
    public class SeriesResponse : IReadRepository<SeriesEntity>, IWriteRepository<SeriesEntity>
    {
        private NetflixDB _netflixDB;
        public SeriesResponse(NetflixDB netflixDB)
        {
            _netflixDB = netflixDB;
        }

        public SeriesEntity Add(SeriesEntity entity)
        {
            _netflixDB.Series.Add(entity);
            _netflixDB.SaveChanges();
            return entity;
        }

        public bool Delete(int id)
        {
            var findSeries = _netflixDB.Series.FirstOrDefault(movies => movies.ID == id);
            bool isFinded = findSeries != null ? true : false;
            if (isFinded)
            {
                _netflixDB.Series.Remove(findSeries);
                _netflixDB.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool Delete(SeriesEntity entity)
        {
            _netflixDB.Series.Remove(entity);
            _netflixDB.SaveChanges();
            return true;
        }

        public  List<SeriesEntity> GetAll()
        {
            var response = _netflixDB.Series.ToList();
            return response;
        }

        public SeriesEntity GetById(int id)
        {
            var findSeries = _netflixDB.Series.FirstOrDefault(series => series.ID == id);
            return findSeries != null ? findSeries : null;
        }

        public SeriesEntity Update(SeriesEntity entity)
        {
            _netflixDB.Series.Update(entity);
            _netflixDB.SaveChanges();
            return entity;
        }
    }

  
}
