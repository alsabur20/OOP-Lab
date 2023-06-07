using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem4.BL;

namespace Problem4.DL
{
    class ShapeDL
    {
        public static List<Shape> shapes = new List<Shape>();
        public static void AddShape(Shape s)
        {
            shapes.Add(s);
        }
    }
}
