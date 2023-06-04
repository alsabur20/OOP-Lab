using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge1
{
    public class Hose
    {
        private string shape;
        private string material;
        private int diameter;
        private int flowRate;

        public Hose(string shape, string material, int diameter, int flowRate)
        {
            this.diameter = diameter;
            this.shape = shape;
            this.material = material;
            this.flowRate = flowRate;
        }
        public void SetShape(string shape)
        {
            this.shape = shape;
        }
        public void SetMaterial(string material)
        {
            this.material = material;
        }
        public void SetDiameter(int diameter)
        {
            this.diameter = diameter;
        }
        public void SetFlowRate(int flowRate)
        {
            this.flowRate = flowRate;
        }
        public string GetShape()
        {
            return this.shape;
        }
        public string GetMaterial()
        {
            return this.material;
        }
        public int GetDiameter()
        {
            return this.diameter;
        }
        public int GetFlowRate()
        {
            return this.flowRate;
        }
    }
}