using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge1
{
    public class Employee
    {
        protected string name;
        public Employee(string name)
        {
            this.name = name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
    }
}