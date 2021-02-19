using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhiteList.Models;


namespace WhiteList.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        public IpList _ipList = null;
       
        public HomeController(IOptions<IpList> ipListOption)
        {
            _ipList = ipListOption.Value;

        }

        [HttpGet(Name = nameof(getProduct))]
        public IActionResult getProduct()
        {
            var response = new
            {
                href = Url.Link(nameof(getProduct), null)
            };

            return Ok(response);
        }
    }
}
