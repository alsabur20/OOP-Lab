using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem4.BL;

namespace Problem4.UI
{
    class CircleUI
    {
        public static Circle CircleInput()
        {
            Console.Write("Enter Radius: ");
            double radius = double.Parse(Console.ReadLine());
            return new Circle("Circle", radius);
        }
    }
}
