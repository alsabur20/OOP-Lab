using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4.BL
{
    class Rectangle : Shape
    {
        private double length;
        private double width;
        public Rectangle(string type, double length, double width) : base(type)
        {
            this.length = length;
            this.width = width;
        }
        public override double GetArea()
        {
            return this.length * this.width;
        }
        public override string toString()
        {
            return base.toString() + " and its area is " + GetArea();
        }
    }
}
