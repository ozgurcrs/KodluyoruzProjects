using ApiVersionController.Interfaces;
using ApiVersionController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVersionController.Services
{
    public class ProductService : IResponse<ProductModel>
    {
        public List<ProductModel> _productData = new List<ProductModel>();

        public ProductService()
        {
            fillData();
        }
        public ProductModel getList()
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> getLists()
        {
            return _productData;
        }

        public void fillData()
        {
            for (int i = 0; i < 10; i++) {
                _productData.Add(new ProductModel
                {
                    ID = i,
                    Name = "Product-" + i,
                    Price = i * 200
                });
            }
        }
    }
}
