using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2.BL
{
    class Point
    {
        public int x;
        public int y;
        public Point()
        {
            this.x = 0;
            this.y = 0;
        }
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public void SetX(int X)
        {
            this.x = X;
        }
        public void SetY(int Y)
        {
            this.y = Y;
        }

    }
}
