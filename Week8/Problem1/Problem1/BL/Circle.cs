using System;

namespace Problem1.BL
{
    class Circle
    {
        protected double radius;
        protected string color;
        public Circle()
        {
            this.radius = 1.0F;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double GetRadius()
        {
            return this.radius;
        }
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public string GetColor()
        {
            return this.color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public double GetArea()
        {
            double area = 0.0F;
            area = Math.PI * (this.radius * this.radius);
            return area;
        }
        public string toString()
        {
            return "Circle[radius= " + this.radius.ToString() + ", color= " + this.color;
        }
    }
}
