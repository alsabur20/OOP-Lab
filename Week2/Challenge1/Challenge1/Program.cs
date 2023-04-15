using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1.BL;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            product[] p = new product[5];
            int count = 0;
            char option;
            Console.Clear();
            do
            {
                option = Menu();
                if (option == '1')
                {
                    p[count] = AddProduct();
                    count++;
                }
                else if (option == '2')
                {
                    ShowProducts(p, count);
                }
                else if (option == '3')
                {
                    float total = TotalWorth(p, count);
                    Console.Clear();
                    Console.WriteLine("Total Worth: {0}", total);
                    Console.Write("Press any key to exit..");
                    Console.ReadKey();
                }
                else if (option == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Choice!!");
                }
            }
            while (option != '4');
            Console.Write("Press any key to exit..");
            Console.ReadKey();
        }
        static char Menu()
        {
            Console.Clear();
            char option;
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Show Products");
            Console.WriteLine("3. Total Score Worth");
            Console.WriteLine("4. Exit");
            option = char.Parse(Console.ReadLine());
            return option;
        }
        static product AddProduct()
        {
            Console.Clear();
            product p1 = new product();
            Console.Write("Enter Product Id: ");
            p1.ID = int.Parse(Console.ReadLine());
            Console.Write("Enter Product Name: ");
            p1.name = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            p1.price = float.Parse(Console.ReadLine());
            Console.Write("Enter Product Category: ");
            p1.category = Console.ReadLine();
            Console.Write("Enter Brand Name: ");
            p1.brandName = Console.ReadLine();
            Console.Write("Enter Country: ");
            p1.country = Console.ReadLine();
            return p1;
        }
        static void ShowProducts(product[] p, int count)
        {
            Console.Clear();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Product ID: {0} Product Name: {1} Price: {2} Category: {3} Brand Name: {4} Country: {5}", p[i].ID, p[i].name, p[i].price, p[i].category, p[i].brandName, p[i].country);
            }
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
        static float TotalWorth(product[] p, int count)
        {
            float total = 0.0F;
            for (int i = 0; i < count; i++)
            {
                total += p[i].price;
            }
            return total;
        }
    }
}
