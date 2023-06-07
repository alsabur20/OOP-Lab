using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem4.BL;

namespace Problem4.UI
{
    class SquareUI
    {
        public static Square SquareInput()
        {
            Console.Write("Enter length: ");
            double length = double.Parse(Console.ReadLine());
            return new Square("Square", length);
        }
    }
}
