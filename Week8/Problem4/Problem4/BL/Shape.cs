using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4.BL
{
    public class Shape
    {
        private string type;
        public Shape(string type)
        {
            this.type = type;
        }
        public string getType()
        {
            return this.type;
        }
        public virtual double GetArea()
        {
            return 0.0F;
        }
        public virtual string toString()
        {
            return "The shape is "+this.type;
        }
    }
}
