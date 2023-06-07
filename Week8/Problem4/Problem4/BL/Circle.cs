using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4.BL
{
    class Circle : Shape
    {
        private double radius;
        public Circle(string type, double radius) : base(type)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }
        public override string toString()
        {
            return base.toString() + " and its area is " + GetArea();
        }
    }
}