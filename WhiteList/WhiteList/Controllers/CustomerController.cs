using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhiteList.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpGet(Name = nameof(getCustomer))]
        public IActionResult getCustomer()
        {
            var response = new
            {
                href = Url.Link(nameof(getCustomer), null)
            };

            return Ok(response);
        }
    }
}
