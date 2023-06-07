using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4.BL
{
    class Square : Shape
    {
        private double length;
        public Square(string type, double length) : base(type)
        {
            this.length = length;
        }
        public override double GetArea()
        {
            return Math.Pow(length, 2);
        }
        public override string toString()
        {
            return base.toString()+" and its area is "+GetArea();
        }
    }
}
