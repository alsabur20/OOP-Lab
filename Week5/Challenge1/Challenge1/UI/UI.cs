using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1.BL;

namespace Challenge1.UI
{
    class UI
    { 
        public static int Menu()
        {
            Console.WriteLine("1.Make a Line");
            Console.WriteLine("2.Update the begin point");
            Console.WriteLine("3.Update the end point");
            Console.WriteLine("4.Show the begin Point");
            Console.WriteLine("5.Show the end point");
            Console.WriteLine("6.Get the Length of the line");
            Console.WriteLine("7.Get the Gradient of the Line");
            Console.WriteLine("8.Find the distance of begin point from zero coordinates");
            Console.WriteLine("9.Find the distance of end point from zero coordinates");
            Console.WriteLine("10.Exit");
            Console.WriteLine();
            Console.Write("Enter Your Option: ");
            int opt = int.Parse(Console.ReadLine());
            return opt;
        }
        public static void WrongIuput()
        {
            Console.WriteLine("Wrong Input Try Again");
        }
        public static void Clear()
        {
            Console.Clear();
        }
        public static void AnyKey()
        {
            Console.WriteLine();
            Console.Write("Press Any Key for Back");
            Console.ReadKey();
        }
        public static MyLine MakeLine()
        {
            Console.Write("Enter Begin X: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Begin Y: ");
            int y1 = int.Parse(Console.ReadLine());
            MyPoint begin = new MyPoint(x1, y1);

            Console.WriteLine();

            Console.Write("Enter End X: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Enter End Y: ");
            int y2 = int.Parse(Console.ReadLine());
            MyPoint end = new MyPoint(x2, y2);

            MyLine line = new MyLine(begin, end);
            return line;
        }
        public static MyPoint UpdatePoint(string location)
        {
            Console.Write("Enter {0} X: ", location);
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter {0} Y: ", location);
            int y = int.Parse(Console.ReadLine());
            MyPoint point = new MyPoint(x, y);
            return point;
        }
        public static void ShowPoint(MyPoint point, string location)
        {
            Console.WriteLine("{0} Point is ({1},{2})", location, point.X, point.Y);
        }
        public static void ShowLength(MyLine line)
        {
            double length = line.Begin.DistanceWithObject(line.End);
            Console.WriteLine("The Length of the Line is {0}", length);
        }
        public static void ShowSlope(MyLine line)
        {
            double slope = line.GetSlope();
            Console.WriteLine("The Slope of the Line is {0}", slope);
        }
        public static void ShowDistanceFromOrigin(MyPoint point)
        {
            double distance = point.DistanceWithOrigin();
            Console.WriteLine("The Distance from Origin is {0}", distance);
        }
    }
}
