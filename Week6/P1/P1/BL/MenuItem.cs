using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1.BL
{
    class MenuItem
    {
        public string name;
        public string type;
        public float price;
        public MenuItem(string name,string type,float price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }
    }
}
