using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Components.data
{
    public class Product
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Photo { get; set; }
    }
}