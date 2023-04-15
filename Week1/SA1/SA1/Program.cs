using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age,toyPrice;
            float priceOfMachine, remainder,price;

            Console.Write("Enter Age: ");
            age=int.Parse(Console.ReadLine());
            Console.Write("Enter Price of Washing Machine: ");
            priceOfMachine = float.Parse(Console.ReadLine());
            Console.Write("Enter unit price of toy: ");
            toyPrice = int.Parse(Console.ReadLine());

            price = CalculateMoney(age, toyPrice);
            if (price >= priceOfMachine)
            {
                remainder = price - priceOfMachine;
                Console.WriteLine("Yes! {0}", remainder);
            }
            else
            {
                remainder = priceOfMachine - price;
                Console.WriteLine("No! {0}", remainder);
            }
            Console.Read();
        }

        static float CalculateMoney(int age, float toyPrice)
        {
            int noOfToys = 0;
            float moneySaved = 0;
            float moneyForBirthday = 10;

            for (int currentYear = 1; currentYear <= age; currentYear++)
            {
                if ((currentYear % 2) == 0)
                {
                    moneySaved += (moneyForBirthday - 1);
                    moneyForBirthday += 10;
                }
                else
                {
                    noOfToys++;
                }
            }
            moneySaved += (noOfToys * toyPrice);
            return moneySaved;
        }
    }
}
