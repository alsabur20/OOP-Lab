using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3.BL
{
    class Order
    {
        public int ID;
        public string customerName;
        public float amount;
        public float[] arr = new float[5];
        public int count;
    }
    class Product
    {
        public int ID;
        public string name;
        public float price;
    }
}
