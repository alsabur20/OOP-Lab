using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockType empty_time = new ClockType();
            Console.Write("Empty Time: ");
            empty_time.printTime();

            ClockType hour_time = new ClockType(8);
            Console.Write("Hour Time: ");
            hour_time.printTime();

            ClockType minute_time = new ClockType(8, 10);
            Console.Write("Minute Time: ");
            minute_time.printTime();

            ClockType full_time = new ClockType(0, 0, 0);
            Console.Write("Full Time: ");
            full_time.printTime();

            full_time.incrementSeconds();
            Console.Write("Full Time(Increment Second): ");
            full_time.printTime();

            full_time.incrementMinutes();
            Console.Write("Full Time(Increment Minutes): ");
            full_time.printTime();

            full_time.incrementHours();
            Console.Write("Full Time(Increment Hours): ");
            full_time.printTime();


            
            bool flag = full_time.isEqual(1, 1, 1);
            Console.WriteLine("Flag: " + flag);

            ClockType cmp = new ClockType(0, 0, 0);
            flag = full_time.isEqual(cmp);
            Console.WriteLine("Object Flag: " + flag);

            Console.ReadKey();
        }
    }
}
