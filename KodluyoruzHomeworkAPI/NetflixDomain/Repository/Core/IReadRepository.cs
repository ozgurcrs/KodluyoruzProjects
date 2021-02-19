using NetflixDomain.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix_Service.Repository.Core
{
    public interface IReadRepository <T> where T : IEntity
    {
        T GetById(int id);
        List<T> GetAll();

    }
}
