using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    class Subject
    {
        public string code;
        public string type;
        public int creditHours;
        public float fee;
        public Subject(string code, string type, int creditHours,float fee)
        {
            this.code = code;
            this.type = type;
            this.creditHours = creditHours;
            this.fee = fee;
        }
    }

}
