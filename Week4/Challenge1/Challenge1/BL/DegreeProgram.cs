using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    class DegreeProgram
    {
        public string name;
        public int duration;
        public int seats;
        public float minAggregate;
        public List<Subject> subjects = new List<Subject>();

        public DegreeProgram(string name, int duration,int seats,float minAggregate)
        {
            this.name = name;
            this.duration = duration;
            this.seats = seats;
            this.minAggregate = minAggregate;
        }
        public void addSubject(Subject s)
        {
            subjects.Add(s);
        }
        
    }
}
