using System;
using System.Linq;

namespace Code_Challenge_2
{
    class Product
    {
        public int ProductId;
        public string ProductName;
        public double Price;
    }

    class Qn2
    {
        static void Main()
        {
            Product[] products = new Product[10];

            for (int i = 0; i < 10; i++)
            {
                products[i] = new Product();

                Console.Write("Product ID: ");
                products[i].ProductId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Product Name: ");
                products[i].ProductName = Console.ReadLine();

                Console.Write("Product Price: ");
                products[i].Price = Convert.ToDouble(Console.ReadLine());
            }

            var sortedProducts = products.OrderBy(p => p.Price);

            Console.WriteLine("Products Sorted By Price:");
            foreach (var product in sortedProducts)
            {
                Console.WriteLine(product.ProductId + " " + product.ProductName + " " + product.Price);
            }
            Console.Read();
        }
    }
}
