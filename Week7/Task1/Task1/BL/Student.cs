using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    class Student
    {
        protected string name;
        protected string isDayScholar;
        protected int ecatMarks;
        protected int fscMarks;

        public Student(string name, string isDayScholar, int ecatMarks, int fscMarks)
        {
            this.name = name;
            this.isDayScholar = isDayScholar;
            this.ecatMarks = ecatMarks;
            this.fscMarks = fscMarks;
        }
        public float CalculateMerit()
        {
            return 0.6F * this.fscMarks + 0.4F * this.ecatMarks;
        }
    }
}
