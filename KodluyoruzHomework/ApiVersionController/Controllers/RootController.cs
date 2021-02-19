using ApiVersionController.Interfaces;
using ApiVersionController.Models;
using ApiVersionController.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVersionController.Controllers
{
    [ApiController]
    [Route("/")]
    public class RootController : ControllerBase
    {
        public IResponse<ProductModel> _productService = new ProductService();

        [HttpGet]
        public IActionResult getProducts()
        {
            var response = _productService.getLists();
            return Ok(response);
        }
    }
}
