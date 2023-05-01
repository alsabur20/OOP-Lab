using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise.BL
{
    class Student
    {
        public Student()
        {
            Console.WriteLine("Default Constructor Called");
            name = "Sabur";
            uMarks = 100F;
        }
        public Student(string name)
        {
            Console.WriteLine("Parameterised Constructor Called");
            this.name = name;
        } public Student(Student s)
        {
            Console.WriteLine("Copy Constructor Called");
            this.name = s.name;
            this.uMarks = s.uMarks;
            this.eMarks = s.eMarks;
            this.mMarks = s.mMarks;
            this.total = s.total;
        }
        public string name;
        public float uMarks;
        public float eMarks;
        public float mMarks;
        public float total;
    }
}
