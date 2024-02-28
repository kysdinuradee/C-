using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LAB_S2_Q4
{
    internal class Program
    {
        class Product
        {
            public string ProductName { get; set; }
            public double Price { get; set; }

            public Product(string productName, double price)
            {
                ProductName = productName;
                Price = price;
            }

            public void DisplayProductDetails()
            {
                Console.WriteLine($"Product Name: {ProductName}");
                Console.WriteLine($"Price: ${Price}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Create Product objects using constructor
                Product product1 = new Product("Laptop", 899.99);
                Product product2 = new Product("Headphones", 49.99);

                // Display product details
                Console.WriteLine("\nProduct 1 Details:");
                product1.DisplayProductDetails();

                Console.WriteLine("\nProduct 2 Details:");
                product2.DisplayProductDetails();
            }
        }
    }
}
