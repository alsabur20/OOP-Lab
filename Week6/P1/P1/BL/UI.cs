using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1.BL
{
    class UI
    { 
        public static void wrongInput()
        {
            Console.WriteLine("Wrong Input!!!");
            Console.WriteLine("Enter Correct Input!!!");
        }
        public static int CoffeeShopMenu()
        {
            int option;
            Console.WriteLine("Welcome to Tesha's Coffee Shop");
            Console.WriteLine("");
            Console.WriteLine("1.Add a Menu item");
            Console.WriteLine("2.View the Cheapest Item in the menu");
            Console.WriteLine("3.View the Drink’s Menu");
            Console.WriteLine("4.View the Food’s Menu");
            Console.WriteLine("5.Add Order");
            Console.WriteLine("6.Fulfill the Order");
            Console.WriteLine("7.View the Orders’s List");
            Console.WriteLine("8.Total Payable Amount");
            Console.WriteLine("9.Exit");
            Console.Write("Enter Choice: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        public static void Halt()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        public static MenuItem addItem()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Type: ");
            string type = Console.ReadLine();
            Console.Write("Enter Price: ");
            float price = float.Parse(Console.ReadLine());
            return new MenuItem(name, type, price);
        }
        public static void PrintString(string n)
        {
            Console.WriteLine(n) ;
        }
        public static void PrintMenuitems(List<MenuItem> m)
        {
            Console.WriteLine("Name\tPrice");
            foreach(MenuItem x in m)
            {
                Console.WriteLine(x.name+"\t"+x.price);
            }
        }
        public static void PrintOrders(List<string> s)
        {
            Console.WriteLine("Name");
            foreach(var x in s)
            {
                Console.WriteLine(x);
            }
        }
        public static string TakeOrder()
        {
            Console.Write("Enter Name: ");
            return Console.ReadLine();
        }
    }
}
