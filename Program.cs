using System;
using System.Collections.Generic;
using Tags.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tags
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> tags = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product #{0} data: ", i);
                Console.Write("Common, used or imported (c/u/i)? ");
                char answer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (answer == 'c')
                {
                    tags.Add(new Product(name, price));
                }
                else if(answer == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    tags.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double tax = double.Parse(Console.ReadLine());
                    tags.Add(new ImportedProduct(name, price, tax));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");

            foreach(Product prod in tags)
            {
                Console.WriteLine(prod.priceTag());
            }
        }
    }
}
