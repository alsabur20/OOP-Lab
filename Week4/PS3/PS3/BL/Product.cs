using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS3.BL
{
    class Product
    {
        public string name;
        public string category;
        public int price;
        public float calculateTax()
        {
            //Formula For Tax Calculation
            return price * 0.2F;
        }
    }
}
