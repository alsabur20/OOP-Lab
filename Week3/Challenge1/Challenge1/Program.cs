using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1.BL;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockType temp = new ClockType(3, 30, 0);
            Console.Write("Time 1: ");
            temp.printTime();//First Time

            Console.WriteLine("");
            Console.Write("Elapsed Time(in seconds): ");
            temp.printTime(temp.elapsedTime());//Part A Elapsed Time

            Console.Write("Elapsed Time in hh mm ss: ");
            temp.ChangeTime(temp.elapsedTime());//Part D Output in hh:mm:ss

            Console.Write("Remaining Time(in seconds): ");
            temp.printTime((temp.remainingTime()));//Part B Remaining Time

            Console.WriteLine("");
            ClockType temp1 = new ClockType(1, 30, 0);
            Console.Write("Time 2: ");
            temp1.printTime();

            Console.Write("Difference Between Time 1 and Time 2:");
            temp.difference(temp1);//Part C Difference between two times


            Console.ReadKey();
        }
    }
}