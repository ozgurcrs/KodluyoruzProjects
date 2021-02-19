using ApiVersionController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVersionController.Interfaces
{
    public interface IResponse<T>
    {
        List<T> getLists();
        T getList();
    }
}
