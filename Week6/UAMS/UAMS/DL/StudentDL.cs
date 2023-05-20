using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using System.IO;

namespace UAMS.DL
{
    class StudentDL
    {
        public static List<Student> Student_List = new List<Student>();
        public static List<Student> Sorted_Student = new List<Student>();
        public static void AddStudent(Student s)
        {
            Student_List.Add(s);
        }
        public static Student isStudentPresent(string name)
        {
            foreach (Student s in Student_List)
            {
                if (name == s.Name && s.reg_degree != null)
                {
                    return s;
                }
            }
            return null;
        }
       public static void MeritList()
        {
            for (int i = 0; i < Student_List.Count; i++)
            {
                Student_List[i].calculateMerit();
            }
            Sorted_Student = Student_List.OrderByDescending(o => o.merit).ToList();
        }
       public static void GiveAdmission()
        {
            for (int i = 0; i < Sorted_Student.Count; i++)
            {
                if (Sorted_Student[i].merit > 80)
                {
                    for (int j = 0; j < Sorted_Student[i].preferences.Count; j++)
                    {
                        if (Sorted_Student[i].preferences[j].seats != 0)
                        {
                            Sorted_Student[i].reg_degree = Sorted_Student[i].preferences[j];
                            Sorted_Student[i].preferences[j].seats--;
                            break;
                        }

                    }
                }
            }
        }
        public static void StoreStudentsToFile(string path, Student s)
        {
            StreamWriter f = new StreamWriter(path, true);
            string degreeNames = "";
            for(int i = 0; i < s.preferences.Count;i ++)
            {
                degreeNames = degreeNames + s.preferences[i].Name + ";";
            }
            degreeNames = degreeNames + s.preferences[s.preferences.Count - 1].Name;
            f.WriteLine(s.Name + "," + s.age + "," + s.m_marks + ",", s.f_marks + "," + s.e_marks + "," + degreeNames);
            f.Close();
        }
        public static bool ReadStudentsFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    int age = int.Parse(splittedRecord[1]);
                    double m_marks = double.Parse(splittedRecord[2]);
                    double f_marks = double.Parse(splittedRecord[3]);
                    double e_marks = double.Parse(splittedRecord[4]);
                    string[] preferenceRecord = splittedRecord[5].Split(';');
                    List<DegreePrograms> preferences = new List<DegreePrograms>();
                    for (int i = 0; i < preferenceRecord.Length; i++)
                    {
                        DegreePrograms d = DegreeProgramsDL.isDegreeExists(preferenceRecord[i]);
                        if (d != null)
                        {
                            preferences.Add(d);
                        }
                        Student s = new Student(name, age, m_marks, f_marks, e_marks, preferences);
                        Student_List.Add(s);
                    }

                }
                f.Close();
                return true;
             }
            else
            {
                return false;
            }

        }
       public static Student Exist(string name)
        {
            for (int i = 0; i < StudentDL.Sorted_Student.Count; i++)
            {
                if (name == StudentDL.Sorted_Student[i].Name)
                {
                    return StudentDL.Sorted_Student[i];
                }
            }
            return null;
        }
        

    }

}
