using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    class Student
    {
        public string name;
        public int age;
        public int fscMarks;
        public int ecatMarks;
        public float merit;
        public List<DegreeProgram> preferences = new List<DegreeProgram>();
        public List<Subject> regSubjects = new List<Subject>();
        public DegreeProgram regDegree;

        public Student(string name, int age, int fscMarks, int ecatMarks)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
        }
        public void addPreference(DegreeProgram d)
        {
            preferences.Add(d);
        }
        public List<DegreeProgram> getAllPreferences()
        {
            return preferences;
        }
        public void calculateMerit()
        {
            this.merit = 0.6F * (this.fscMarks / 1100F * 100F) + 0.4F * (this.ecatMarks / 400F * 100F);
        }
        public int getCreditHours()
        {
            int ch = 0;
            foreach (Subject x in regSubjects)
            {
                ch += x.creditHours;
            }
            return ch;
        }
        public float returnFee()
        {
            float fee = 0.0F;
            foreach (Subject x in this.regSubjects)
            {
                fee += x.fee;
            }
            return fee;
        }
    }
}
