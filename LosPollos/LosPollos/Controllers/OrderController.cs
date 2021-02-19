using LosPollos.Context;
using LosPollos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LosPollos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        public readonly LosPollosDbContext _orderDbContext;


        public OrderController(LosPollosDbContext orderDbContext)
        {
            _orderDbContext = orderDbContext;
        }

        [HttpGet]
        public IActionResult getOrders()
        {
            var response = _orderDbContext.Orders.ToList();
            return Ok(response);
        }

     
    }
}
