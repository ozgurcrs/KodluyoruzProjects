﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareLog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {

    [HttpGet]
        public int Get()
        {
            return 1;
        }
        
    }
}
