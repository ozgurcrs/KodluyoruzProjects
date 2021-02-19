using ServicesProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesProject.ServicesManager
{
    public class ServicesManager : ISingletonService, IScopedService, ITransientService
    {
        int _number;
        Random rnd = new Random();
        public ServicesManager()
        {
            _number = rnd.Next();
        }

        public int getRandomNumber()
        {
            return _number;
        }
    }
}
