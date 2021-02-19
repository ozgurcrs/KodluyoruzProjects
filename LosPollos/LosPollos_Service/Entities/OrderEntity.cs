using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LosPollos.Models
{
    public class OrderEntity
    {
        public Guid ID { get; set; }
        public string FoodName { get; set; }
        public decimal Price { get; set; }
        public string DeliveryAddress { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}
