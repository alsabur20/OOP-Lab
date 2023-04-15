using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge3.BL;

namespace Challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] p = new Product[10];
            int productCount = 0;
            Order[] o = new Order[5];
            int orderCount = 0;
            char option;
            do
            {
                Console.Clear();
                option = Menu();
                if (option == '1')
                {
                    Console.Write("Enter Product ID: ");
                    int ID = int.Parse(Console.ReadLine());
                    Console.Write("Enter Product Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Product Amount: ");
                    float price = float.Parse(Console.ReadLine());
                    p[productCount] = AddProduct(ID, name, price);
                    productCount++;
                    Console.WriteLine("Product Added!!!");
                    Console.Write("Press any key to comtinue...");
                    Console.ReadKey();

                }
                else if (option == '2')
                {
                    Console.Write("Enter Product Id: ");
                    int ID = int.Parse(Console.ReadLine());
                    int index = ReturnIndex(p, productCount, ID);
                    if (index != -1)
                    {
                        DeleteProduct(p, ref productCount, index);
                        Console.WriteLine("Product Deleted Successfully!!!");
                        Console.Write("Press any key to comtinue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect ID");
                        Console.Write("Press any key to comtinue...");
                        Console.ReadKey();
                    }
                }
                else if (option == '3')
                {
                    Console.Clear();
                    ViewProducts(p, productCount);
                }
                else if (option == '4')
                {
                    Console.Clear();
                    o[orderCount] = CreateOrder(p,productCount);
                    orderCount++;
                    Console.Write("Order Created Successfully!!!");
                    Console.Write("Press any key to comtinue...");
                    Console.ReadKey();
                }
                else if (option == '5')
                {
                    for (int i = 0; i < orderCount; i++)
                    {
                        Console.WriteLine(o[i].ID.ToString().PadRight(10)+ o[i].customerName.PadRight(20)+ o[i].count.ToString().PadRight(15)+ o[i].amount.ToString());
                    }
                    Console.Write("Press any key to comtinue...");
                    Console.ReadKey();
                }
                else if (option == '6')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice!!!");
                    Console.Write("Press any key to comtinue...");
                    Console.ReadKey();
                }
            }
            while (option != '6');

        }
        static char Menu()
        {
            char option;
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Delete Product");
            Console.WriteLine("3. View Products");
            Console.WriteLine("4. Place Order");
            Console.WriteLine("5. View Orders");
            Console.WriteLine("6. Exit");
            option = char.Parse(Console.ReadLine());
            return option;
        }
        static Product AddProduct(int ID, string name, float price)
        {
            Product p1 = new Product();
            p1.ID = ID;
            p1.name = name;
            p1.price = price;
            return p1;
        }
        static int ReturnIndex(Product[] p, int count, int ID)
        {
            int index = -1;
            for (int i = 0; i < count; i++)
            {
                if (p[i].ID == ID)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        static void DeleteProduct(Product[] p, ref int count, int index)
        {
            for (int i = index; i < count - 1; i++)
            {
                p[i] = p[i + 1];
            }
        }
        static void ViewProducts(Product[] p, int count)
        {
            Console.Clear();
            Console.WriteLine("Product ID".PadRight(20) + "Product Name".PadRight(20) + "Product Price".PadRight(15));
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(p[i].ID.ToString().PadRight(20)+ p[i].name.PadRight(20)+ p[i].price.ToString().PadRight(15));
            }
            Console.Write("Press any key to comtinue...");
            Console.ReadKey();
        }
        static Order CreateOrder(Product[] p,int productCount)
        {
            Order o1 = new Order();
            Console.Write("Enter ID: ");
            o1.ID = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            o1.customerName = Console.ReadLine();
            char option;
            o1.count = 0;
            do
            {
                Console.WriteLine("Do you want to add product? (y||n)");
                option = char.Parse(Console.ReadLine());
                if (option == 'y')
                {
                    Console.Write("Enter Product ID: ");
                    int ID = int.Parse(Console.ReadLine());
                    int index = ReturnIndex(p, productCount, ID);
                    if (index != -1)
                    {
                        o1.arr[o1.count] = p[index].ID;
                        o1.count++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid ID!!");
                        Console.Write("Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                
                else if (option == 'n')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Option");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                }
            }
            while (option == 'n');
            o1.amount = CalculateBill(o1.arr, o1.count);
            return o1;
        }
        static float CalculateBill(float[] arr, int count)
        {
            float bill = 0.0F;
            for (int i = 0; i < count; i++)
            {
                bill += arr[i];
            }
            return bill;
        }
    }
}
