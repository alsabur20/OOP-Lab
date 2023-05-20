using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using P2.BL;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] triangle = new char[5, 3] { { '@', ' ', ' ' }, {'@','@',' ' }, {'@','@','@' } ,{'@','@',' ' },{'@',' ',' ' } };
            char[,] optriangle = new char[5, 3] { { ' ', ' ', '@' }, {' ','@','@' }, {'@','@','@' } ,{' ','@','@' },{' ',' ', '@' } };
            Boundary b = new Boundary(new Point(0, 0), new Point(20, 0), new Point(0, 20), new Point(20, 20));
            GameObject g1 = new GameObject(triangle, new Point(15, 5), b, "Projectile");
            //GameObject g2 = new GameObject(optriangle, new Point(30, 60), b, "RightToLeft");
            List<GameObject> lst = new List<GameObject>();
            lst.Add(g1);
           // lst.Add(g2);
            //g1.Draw();
            //g2.Draw();
            while (true)
            {
                Thread.Sleep(200);
                foreach (GameObject x in lst)
                {
                    x.Erase();
                    x.Move();
                    x.Draw();
                    Console.SetCursorPosition(40, 20);
                    Console.WriteLine(x.StartingPoint.x+"\t"+ x.StartingPoint.x);
                }
            }
        }
    }
}
