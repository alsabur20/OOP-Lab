using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem4.BL;
using Problem4.DL;


namespace Problem4.UI
{
    class ShapeUI
    {
        public static void WriteAreas()
        {
            foreach(Shape s in ShapeDL.shapes)
            {
                Console.WriteLine(s.toString());
            }
        }
    }
}
