using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.BL
{
    class Cylinder:Circle
    {
        private double height;
        public Cylinder()
        {
            this.height = 1.0F;
        }
        public Cylinder(double radius) : base(radius)
        {
            this.height = 1.0F;
        }
        public Cylinder(double radius, double height):base(radius)
        {
            this.height = height;
        }
        public Cylinder(double radius, double height,string color) : base(radius,color)
        {
            this.height = height;
        }
        public double GetHeight()
        {
            return this.height;
        }
        public void SetHeight(double height)
        {
            this.height = height;
        }
        public double GetVolume()
        {
            double volume = 0.0F;
            volume = GetArea() * this.height;
            return volume;
        }
    }
}
