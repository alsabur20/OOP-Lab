using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAWeek3.BL
{
    class Circle
    {
        public const double PI = 3.1415926535897931;
        public double radius;
        public string color;
        public Circle()
        {
            radius = 1.0;
            color = "red";
        }
        public Circle(double radius)
        {
            this.radius = radius;
            color = "";
        }
        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public Circle(Circle temp)
        {
            this.radius = temp.radius;
            this.color = temp.color;
        }
        public double getArea()
        {
            return PI * (this.radius * this.radius);
        }
        public double getDiameter()
        {
            return this.radius + this.radius;
        }
        public double getCircumference()
        {
            return 2 * PI * this.radius;
        }

    }
}
