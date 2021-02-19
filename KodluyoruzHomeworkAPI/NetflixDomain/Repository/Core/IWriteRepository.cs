using NetflixDomain.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Netflix_Service.Repository.Core
{
    public interface IWriteRepository<T> where T : IEntity
    {
        T Add(T entity);
        T Update(T entity);
        bool Delete(int id);
        bool Delete(T entity);
    }
}
