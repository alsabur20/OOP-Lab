using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Challenge1.BL;
using Challenge1.UI;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint point = new MyPoint(0, 0);
            MyLine line = new MyLine(point, point);
            int opt;
            do
            {
                UI.UI.Clear();
                opt = UI.UI.Menu();
                if (opt == 1)
                {
                    UI.UI.Clear();
                    line = UI.UI.MakeLine();
                    UI.UI.AnyKey();
                }
                else if (opt == 2)
                {
                    UI.UI.Clear();
                    line.Begin = UI.UI.UpdatePoint("Begin");
                    UI.UI.AnyKey();
                }
                else if (opt == 3)
                {
                    UI.UI.Clear();
                    line.End = UI.UI.UpdatePoint("End");
                    UI.UI.AnyKey();
                }
                else if (opt == 4)
                {
                    UI.UI.Clear();
                    UI.UI.ShowPoint(line.Begin, "Begin");
                    UI.UI.AnyKey();
                }
                else if (opt == 5)
                {
                    UI.UI.Clear();
                    UI.UI.ShowPoint(line.End, "End");
                    UI.UI.AnyKey();
                }
                else if (opt == 6)
                {
                    UI.UI.Clear();
                    UI.UI.ShowLength(line);
                    UI.UI.AnyKey();
                }
                else if (opt == 7)
                {
                    UI.UI.Clear();
                    UI.UI.ShowSlope(line);
                    UI.UI.AnyKey();
                }
                else if (opt == 8)
                {
                    UI.UI.Clear();
                    UI.UI.ShowDistanceFromOrigin(line.Begin);
                    UI.UI.AnyKey();
                }
                else if (opt == 9)
                {
                    UI.UI.Clear();
                    UI.UI.ShowDistanceFromOrigin(line.End);
                    UI.UI.AnyKey();
                }
                else if (opt > 10)
                {
                    UI.UI.WrongIuput();
                    Thread.Sleep(300);
                }
            }
            while (opt != 10);
            UI.UI.AnyKey();
        }
    }
}
