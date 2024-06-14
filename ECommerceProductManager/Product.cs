using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProductManager
{
    public class Product
    {
        /* attributes of the the Product */
        //Product ID
        public int ProductID { get; set; }
        //Product Name
        public string ProductName { get; set; }
        //product price
        public decimal Price { get; set; }
        // stock count if product
        public int Stock { get; set; }

        /**
         * Constructor with all the parameters
         */
        public Product(int productId, string productName, decimal price, int stock)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        /**
         * method to increase stock of prodcut
         */
        public void IncreaseStock(int amount)
        {
            Stock += amount;
        }

        /**
         * method to decreae stock of product
         */
        public void DecreaseStock(int amount)
        {
            Stock -= amount;
        }
    }
}
