using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProperties
{
    class Product
    {
        private int productId;
        private string productName;
        private double price;
        private int stock;

        //constructor
        public Product(int productId, string productName, double price, int stock)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
            this.stock = stock;
        }
        //Read-Only Properties
        public int ProductId { get => productId; }
        public string ProductName { get => productName; }
        public double Price { get => price; }
        public int Stock { get => stock; }
    }
    class Test_Product
    {
        static void Main()
        {
            Product product = new Product(1,"Bulb",10,10);
            Console.WriteLine("Id: " + product.ProductId);
            Console.Write("Name: " + product.ProductName);
            Console.Write("Price: " + product.Price);
            Console.Write("Stock: " + product.Stock);
           

        }
    }
}
