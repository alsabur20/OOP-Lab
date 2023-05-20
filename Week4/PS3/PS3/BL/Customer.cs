using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS3.BL
{
    class Customer
    {
        public string CustomerName;
        public string CustomerAddress;
        public string CustomerContact;
        public List<Product> products=new List<Product>();

        public List<Product> getAllProducts()
        {
            return products;
        }

        public void addProduct(Product p)
        {
            products.Add(p);
        }
        public float totalTax()
        {
            float tax = 0.0F;
            foreach(Product x in this.products)
            {
                tax += x.calculateTax();
            }
            return tax;
        }
    }
}
