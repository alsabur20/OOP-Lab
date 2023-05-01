using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge2.BL;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            char option;
            do
            {
                Console.Clear();
                option = Menu();
                if (option == '1')
                {
                    Console.Clear();
                    Console.Write("Enter Product Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Product Category(g=grocery || f=fruit): ");
                    char cat = char.Parse(Console.ReadLine());
                    string category;
                    if (cat == 'g')
                    {
                        category = "Grocery";
                        Console.Write("Enter Unit Price: ");
                        float price = float.Parse(Console.ReadLine());
                        Console.Write("Enter Stock Quantuity: ");
                        int stock = int.Parse(Console.ReadLine());
                        Console.Write("Enter Minimum Stock Quantuity: ");
                        int minStock = int.Parse(Console.ReadLine());
                        AddProduct(products, name, category, price, stock, minStock);
                    }
                    else if (cat == 'f')
                    {
                        category = "Fruit";
                        Console.Write("Enter Unit Price: ");
                        float price = float.Parse(Console.ReadLine());
                        Console.Write("Enter Stock Quantuity: ");
                        int stock = int.Parse(Console.ReadLine());
                        Console.Write("Enter Minimum Stock Quantuity: ");
                        int minStock = int.Parse(Console.ReadLine());
                        AddProduct(products, name, category, price, stock, minStock);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Category!!");
                        Console.WriteLine("Please Try Again!!!!");
                    }
                }
                else if (option == '2')
                {
                    Console.Clear();
                    ViewAllProducts(products);
                }
                else if (option == '3')
                {
                    Console.Clear();
                    HighestUnitPrice(products).PrintProduct();
                }
                else if (option == '4')
                {
                    Console.Clear();
                    ViewSalesTax(products);
                }
                else if (option == '5')
                {
                    Console.Clear();
                    ProductsToOrder(products);
                }
                else if (option == '6')
                {
                    break;
                }
                else if (option != 6)
                {
                    Console.WriteLine("Invalid Choice");
                }
                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }
            while (option != '6');
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
        static char Menu()
        {
            char option;
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Find Most Expensive Item");
            Console.WriteLine("4. View Sales Tax of All Products");
            Console.WriteLine("5. Products to be Ordered");
            Console.WriteLine("6. Exit");
            option = char.Parse(Console.ReadLine());
            return option;
        }
        static void AddProduct(List<Product> products, string name, string category, float price, int stockQuantity, int minStock)
        {
            Product p = new Product(name, category, price, stockQuantity, minStock);
            products.Add(p);
        }
        static void ViewAllProducts(List<Product> products)
        {
            if (products.Count > 0)
            {
                Console.WriteLine("Name".PadRight(20) + "Category".PadRight(20) + "Price".PadRight(15) + "Quantity".PadRight(15) + "Minimum Stock".PadRight(15));
                foreach (Product i in products)
                {
                    i.PrintProduct();
                }
            }
            else
            {
                Console.WriteLine("No Products Available!!");
                Console.WriteLine("Please Add Products");
            }
        }
        static Product HighestUnitPrice(List<Product> products)
        {
            Product p = products[0];
            float price = products[0].price;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].price > price)
                {
                    price = products[i].price;
                    p = products[i];
                }
            }
            return p;
        }
        static void ViewSalesTax(List<Product> products)
        {

            if (products.Count > 0)
            {
                Console.WriteLine("Name".PadRight(20) + "Tax".PadRight(15));
                foreach (Product i in products)
                {
                    Console.WriteLine(i.name.PadRight(20) + i.ReturnTax().ToString().PadRight(15));
                }
            }
            else
            {
                Console.WriteLine("No Products Available!!");
                Console.WriteLine("Please Add Products");
            }
        }
        static void ProductsToOrder(List<Product> products)
        {
            Console.WriteLine("Name");
            foreach (Product i in products)
            {
                Console.WriteLine(i.stockQuantity < i.minStock ? i.name : "");
            }
        }
    }
}
