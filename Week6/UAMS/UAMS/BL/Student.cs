using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class Student
    {
        public string Name;
        public int age;
        public double m_marks;
        public double f_marks;
        public double e_marks;
        public double merit;
        public List<DegreePrograms> preferences;
        public List<Subject> reg_subjects;
        public DegreePrograms reg_degree;
        public Student(string Name, int age, double m_marks, double f_marks, double e_marks)
        {
            this.Name = Name;
            this.age = age;
            this.m_marks = m_marks;
            this.f_marks = f_marks;
            this.e_marks = e_marks;
        }
        public Student(string Name, int age, double m_marks, double f_marks, double e_marks, List<DegreePrograms> preferences)
        {
            this.Name = Name;
            this.age = age;
            this.m_marks = m_marks;
            this.f_marks = f_marks;
            this.e_marks = e_marks;
            this.preferences = preferences;
        }
        public void AddPreferences(List<DegreePrograms> preferences)
        {
            this.preferences = preferences;
        }
        public void calculateMerit()
        {
            merit =((m_marks / 1100) * 0.3 + (f_marks / 1100) * 0.5 + (e_marks / 400) * 0.2);
        }
        public int getCreditHours()
        {
            int hours = 0;
            for(int i = 0;i < reg_subjects.Count;i++)
            {
                hours = hours + reg_subjects[i].creditHours;
            }
            return hours;
        }
        public bool regStudentSubject(Subject s)
        {
            int stCH = getCreditHours();
            if (reg_degree != null && reg_degree.isSubjectExists(s) && stCH + s.creditHours <= 9)
            {
                reg_subjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ViewSubjects()
        {
            for(int i = 0; i < reg_degree.sub_offered.Count; i++)
            {
                Console.WriteLine(reg_degree.sub_offered[i]);
            }
            Console.ReadKey();
        }
        public float CalculateFees()
        {
            float fee = 0;
            if(reg_degree != null)
            {
                foreach(Subject sub in reg_subjects)
                {
                    fee = fee + sub.subjectFees;
                }
            }
            return fee;
        }
        
    }
}
