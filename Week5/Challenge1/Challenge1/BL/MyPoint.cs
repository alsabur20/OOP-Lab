using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    class MyPoint
    {
        public MyPoint()
        {
            X = 0;
            Y = 0;
        }
        public MyPoint(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public int X;
        public int Y;
        public int GetX()
        {
            return X;
        }
        public int GetY()
        {
            return Y;
        }
        public void SetX(int X)
        {
            this.X = X;
        }
        public void SetY(int Y)
        {
            this.Y = Y;
        }
        public void SetXY(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public double DistanceWithCord(int X, int Y)
        {
            double distance = Math.Sqrt(Math.Pow(this.X - X, 2) + Math.Pow(this.Y - Y, 2));
            return distance;
        }
        public double DistanceWithObject(MyPoint another)
        {
            double distance = Math.Sqrt(Math.Pow(X - another.X, 2) + Math.Pow(Y - another.Y, 2));
            return distance;
        }
        public double DistanceWithOrigin()
        {
            double distance = Math.Sqrt(Math.Pow(X - 0, 2) + Math.Pow(Y - 0, 2));
            return distance;
        }
    }
}
