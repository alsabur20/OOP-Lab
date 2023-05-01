using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2.BL
{
    class Product
    {
        public string name;
        public string category;
        public float price;
        public int stockQuantity;
        public int minStock;

        public Product()
        {
            name = "";
            category = "";
            price = 0.0F;
            stockQuantity = 0;
            minStock = 0;
        }
        public Product(string name, string category, float price, int stockQuantity, int minStock)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.stockQuantity = stockQuantity;
            this.minStock = minStock;
        }
        public float ReturnTax()
        {
            float tax = 0.0F;
            if (category == "grocery")
            {
                tax = (this.price * 10) / 100;
            }
            else if (category == "fruit")
            {
                tax = (this.price * 5) / 100;
            }
            else
            {
                tax = (this.price * 15) / 100;
            }
            return tax;
        }
        /*public void ToBeOrdered()
        {
            if (stockQuantity < minStock)
            {
                Console.WriteLine(this.name);
            }
        }*/
        public void PrintProduct()
        {
            Console.WriteLine(this.name.PadRight(20) + this.category.PadRight(20) + this.price.ToString().PadRight(15) + this.stockQuantity.ToString().PadRight(15) + this.minStock.ToString().PadRight(15));
        }
    }
}
