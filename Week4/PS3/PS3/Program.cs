using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS3.BL;

namespace PS3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer
            {
                CustomerName = "Sabur",
                CustomerContact = "03060020007",
                CustomerAddress = "Lahore"
            };
            Console.WriteLine(c.CustomerName + "  " + c.CustomerAddress);
            Console.WriteLine("");
            Product p1 = new Product
            {
                name = "ABC",
                category = "XYZ",
                price = 500
            };
            Product p2 = new Product
            {
                name = "XYZ",
                category = "ABC",
                price = 1000
            };
            c.addProduct(p1);
            c.addProduct(p2);
            foreach (Product x in c.getAllProducts())
            {
                Console.WriteLine(x.name + "  " + x.price + "   " + x.calculateTax());
            }

            Console.ReadKey();
        }
    }
}
