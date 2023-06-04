using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge1
{
    public class Ladder
    {
        private string color;
        private int length;
        public Ladder(string color,int length)
        {
            this.color = color;
            this.length = length;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public void SetLength(int length)
        {
            this.length = length;
        }
        public string GetColor()
        {
            return this.color;
        }
        public int GetLength()
        {
            return this.length;
        }
    }
}