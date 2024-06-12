using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProductManager
{
    public class Product
    {
        /* attributes of the Product */
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        /**
         * Constructor
         */
        public Product(int productId, string productName, decimal price, int stock) 
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        /**
         * increase stock of prodcut
         */
        public void IncreaseStock(int amount)
        {
            Stock += amount;
        }

        /**
         * decreae stock of product
         */
        public void DecreaseStock(int amount)
        {
            Stock -= amount;
        }
    }
}
