using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAWeek3.BL;

namespace SAWeek3
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(1);
            Console.WriteLine(circle.getArea());
            Console.WriteLine(circle.getDiameter());
            Console.WriteLine(circle.getCircumference());

            Console.ReadKey();
        }
    }
}
