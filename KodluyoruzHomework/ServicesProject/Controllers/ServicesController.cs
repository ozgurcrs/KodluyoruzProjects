
using Microsoft.AspNetCore.Mvc;
using ServicesProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesProject.Controllers
{
       [ApiController]
       [Route("[controller]")]
    public class ServicesController
    {

        private readonly ITransientService _transientService1;
        private readonly ITransientService _transientService2;
        private readonly ISingletonService _singletonService1;
        private readonly ISingletonService _singletonService2;
        private readonly IScopedService _scopedService1;
        private readonly IScopedService _scopedService2;
        public ServicesController(ITransientService transientService1,ITransientService transientService2,
                                  ISingletonService singletonService1,ISingletonService singletonService2,
                                  IScopedService scopedService1,IScopedService scopedService2)
        {
            _transientService1 = transientService1;
            _transientService2 = transientService2;
            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;
        }

        [HttpGet]
        public string Get()
        {
            string result = $"Trasient-1 {_transientService1.getRandomNumber()} {Environment.NewLine}" +
                $"Trasient-2 {_transientService2.getRandomNumber()} {Environment.NewLine}" +
                $"Singleton-1 {_singletonService1.getRandomNumber()} {Environment.NewLine}" +
                $"Singleton-2 {_singletonService2.getRandomNumber()} {Environment.NewLine}"+
                $"Scoped-1 {_scopedService1.getRandomNumber()} {Environment.NewLine}" +
                $"Scoped-2 {_scopedService2.getRandomNumber()} {Environment.NewLine}";

            return result;
        }


    }
}
