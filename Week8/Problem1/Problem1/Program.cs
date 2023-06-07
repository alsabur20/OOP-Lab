using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.BL;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder c1 = new Cylinder();
            Cylinder c2 = new Cylinder(10.0F);
            Cylinder c3 = new Cylinder(2.0F,10.0F);

            List<Cylinder> c = new List<Cylinder>();
            c.Add(c1);
            c.Add(c2);
            c.Add(c3);

            foreach(Cylinder x in c)
            {
                Console.WriteLine(x.GetVolume());
            }
            Console.ReadKey();
        }
    }
}
