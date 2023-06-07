using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.BL
{
    class Person
    {
        protected string name;
        protected string address;
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetAddress()
        {
            return this.address;
        }
        public void SetAddress(string address)
        {
            this.address = address;
        }
        public virtual string toString()
        {
            return "Person[name = " + this.name + ", address = " + this.address+"]";
        }
    }
}
