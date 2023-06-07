using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem4.BL;
using Problem4.DL;
using Problem4.UI;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeDL.AddShape(RectangleUI.RectangleInput());
            ShapeDL.AddShape(CircleUI.CircleInput());
            ShapeDL.AddShape(SquareUI.SquareInput());
            ShapeDL.AddShape(RectangleUI.RectangleInput());
            ShapeDL.AddShape(CircleUI.CircleInput());
            ShapeUI.WriteAreas();
            Console.ReadKey();

        }
    }
}
