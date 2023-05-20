using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P1.BL;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeShop c = new CoffeeShop("Tesha");
            int option;
            do
            {
                Console.Clear();
                option = UI.CoffeeShopMenu();
                if (option == 1)
                {
                    Console.Clear();
                    c.addItemToMenu(UI.addItem());

                }
                else if (option == 2)
                {
                    Console.Clear();
                    UI.PrintString(c.cheapestItem());
                }
                else if (option == 3)
                {
                    Console.Clear();
                    UI.PrintMenuitems(c.DrinksOnly());
                }
                else if (option == 4)
                {
                    Console.Clear();
                    UI.PrintMenuitems(c.FoodsOnly());
                }
                else if (option == 5)
                {
                    Console.Clear();
                    c.addOrder(UI.TakeOrder());
                }
                else if (option == 6)
                {
                    Console.Clear();
                    UI.PrintString(c.fulfillOrder());
                }
                else if (option == 7)
                {
                    Console.Clear();
                    UI.PrintOrders(c.orders);
                }
                else if (option == 8)
                {
                    Console.Clear();
                    UI.PrintString(c.returnDueAmount().ToString());
                }
                else if (option > 9)
                {
                    UI.wrongInput();
                }
                UI.Halt();
            }
            while (option!=9);
        }
    }
}
