using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    class MyLine
    {
        public MyLine(MyPoint Begin, MyPoint End)
        {
            this.Begin = Begin;
            this.End = End;
        }
        public MyPoint Begin;
        public MyPoint End;
        public MyPoint GetBegin()
        {
            return Begin;
        }
        public MyPoint GetEnd()
        {
            return End;
        }
        public void SetBegin(MyPoint Begin)
        {
            this.Begin = Begin;
        }
        public void SetEnd(MyPoint End)
        {
            this.End = End;
        }
        public double GetLength()
        {
            double length = this.Begin.DistanceWithObject(End);
            return length;
        }
        public double GetSlope()
        {
            double slope = (Begin.GetY() - End.GetY()) / (Begin.GetX() - End.GetX());
            return slope;
        }
    }
}
