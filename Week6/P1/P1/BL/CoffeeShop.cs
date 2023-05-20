using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1.BL
{
    class CoffeeShop
    {
        public string name;
        public List<MenuItem> menu;
        public List<string> orders;
        public CoffeeShop(string name)
        {
            this.name = name;
            this.menu = new List<MenuItem>();
            this.orders = new List<string>();

        }
        public void addItemToMenu(MenuItem m)
        {
            menu.Add(m);
        }
        public bool doesMenuItemExist(string order)
        {
            foreach (MenuItem x in menu)
            {
                if (x.name == order)
                {
                    return true;
                }
            }
            return false;
        }
        public string addOrder(string name)
        {
            if (doesMenuItemExist(name))
            {
                orders.Add(name);
                return "Order Added!";
            }
            else
            {
                return "This item is currently unavailable!";
            }
        }
        public string fulfillOrder()
        {
            if (orders.Count != 0)
            {
                string order = orders[0];
                orders.RemoveAt(0);
                return "This "+order+" has been fulfilled.";
            }
            else
            {
                return "All orders have been fulfilled!";
            }
        }
        public List<string> returnOrders()
        {
            if (orders.Count == 0)
            {
                return null;
            }
            else
            {
                return orders;
            }
        }
        public float returnDueAmount()
        {
            float p = 0;
            for (int x = 0; x < orders.Count; x++)
            {
                foreach (MenuItem m in menu)
                {
                    if (m.name == orders[x])
                    {
                        p += m.price;
                    }
                }
            }
            return p;
        }
        public string cheapestItem()
        {
            List<MenuItem> sorted = menu.OrderBy(o => o.price).ToList();
            return sorted[0].name;
        }
        public List<MenuItem> DrinksOnly()
        {
            List<MenuItem> temp = new List<MenuItem>();
            foreach (MenuItem m in menu)
            {
                if (m.type == "drink")
                {
                    temp.Add(m);
                }
            }
            return temp;
        }
        public List<MenuItem> FoodsOnly()
        {
            List<MenuItem> temp = new List<MenuItem>();
            foreach (MenuItem m in menu)
            {
                if (m.type == "food")
                {
                    temp.Add(m);
                }
            }
            return temp;
        }
    }
}
