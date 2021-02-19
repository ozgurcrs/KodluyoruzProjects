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
    public class ProductController : ControllerBase
    {
        private readonly LosPollosDbContext _productDbContext;
        public ProductController(LosPollosDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }

        [HttpGet( Name = nameof(getProduct))]
        public IActionResult getProducts()
        {
            var products = _productDbContext.Products.ToList();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public IActionResult getProduct(Guid id)
        {
            var products = _productDbContext.Products.ToList();
            var result = products.FirstOrDefault(product => product.ID == id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult  Post([FromBody] ProductEntity product)
        {
            _productDbContext.Products.Add(product);
            _productDbContext.SaveChanges();
            return Ok(getProducts());
        }

        [HttpDelete("{id}")]
        public IActionResult productRemove(Guid id)
        {
            var findProduct = _productDbContext.Products.FirstOrDefault(product => product.ID == id);
            _productDbContext.Products.Remove(findProduct);
            _productDbContext.SaveChanges();
            return Ok(getProducts());
        }

    }
}
