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
    public class MovieResponse : IReadRepository<MovieEntity>, IWriteRepository<MovieEntity>
    {
        private NetflixDB _netflixDB;
        public MovieResponse(NetflixDB netflixDB)
        {
            _netflixDB = netflixDB;
        }

        public MovieEntity Add(MovieEntity entity)
        {
            _netflixDB.Movies.Add(entity);
            _netflixDB.SaveChanges();
            return entity;
        }

        public bool Delete(int id)
        {
            var findMovie = _netflixDB.Movies.FirstOrDefault(movies => movies.ID == id);
            bool isFinded = findMovie != null ? true : false;
            if (isFinded)
            {
                _netflixDB.Movies.Remove(findMovie);
                _netflixDB.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool Delete(MovieEntity entity)
        {
            _netflixDB.Movies.Remove(entity);
            _netflixDB.SaveChanges();
            return true;
        }

        public  List<MovieEntity> GetAll()
        {
            var response = _netflixDB.Movies.ToList();
            return response;
        }

        public MovieEntity GetById(int id)
        {
            var findMovie = _netflixDB.Movies.FirstOrDefault(movies => movies.ID == id);
            return findMovie != null ? findMovie : null;
        }

        public MovieEntity Update(MovieEntity entity)
        {
            _netflixDB.Movies.Update(entity);
            _netflixDB.SaveChanges();
            return entity;
        }
    }

  
}
