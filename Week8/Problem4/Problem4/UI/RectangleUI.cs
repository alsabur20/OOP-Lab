using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Problem4.BL;
using System.Threading.Tasks;

namespace Problem4.UI
{
    class RectangleUI
    {
        public static Rectangle RectangleInput()
        {
            Console.Write("Enter length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());
            return new Rectangle("Rectangle", length, width);
        }
    }
}
