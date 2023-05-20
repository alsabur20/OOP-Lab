using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1.BL;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();
            List<DegreeProgram> degreePrograms = new List<DegreeProgram>();

            int option;
            do
            {
                option = Menu();
                if (option == 1)
                {
                    Student temp = AddStudent();
                    PrintDegreePrograms(degreePrograms);
                    Console.Write("Enter number of preferences: ");
                    int pref = int.Parse(Console.ReadLine());
                    for (int i = 0; i < pref; i++)
                    {
                        Console.Write("Enter Preference: ");
                        string name = Console.ReadLine();
                        DegreeProgram temp1 = ReturnDegreeFromName(degreePrograms, name);
                        if (temp1 != null)
                        {
                            temp.addPreference(temp1);
                        }
                    }
                    students.Add(temp);
                    Console.WriteLine("Student Added Successfully!!");
                    Console.ReadKey();
                }
                else if (option == 2)
                {
                    DegreeProgram temp = AddDegreeProgram();
                    Console.Write("Enter number of sunjects you want to add: ");
                    int subjects = int.Parse(Console.ReadLine());
                    for (int i = 0; i < subjects; i++)
                    {
                        temp.addSubject(AddSubject());
                    }
                    Console.ReadKey();
                    degreePrograms.Add(temp);
                }
                else if (option == 3)
                {
                    foreach (Student x in students)
                    {
                        x.calculateMerit();
                    }
                    ProcessAdmittedDegree(students);
                    PrintRegisteredDegrees(students);
                    Console.ReadKey();
                }
                else if (option == 4)
                {
                    ViewRegisteredStudents(students);
                    Console.ReadKey();
                }
                else if (option == 5)
                {
                    Console.Clear();
                    Console.Write("Enter Degree Name: ");
                    string name = Console.ReadLine();
                    DegreeProgram x = ReturnDegreeFromName(degreePrograms, name);
                    PrintStudentsOfSpecificDegree(students, x);
                    Console.ReadKey();
                }
                else if (option == 6)
                {
                    Console.Clear();
                    Console.Write("Enter Student Name: ");
                    string name = Console.ReadLine();
                    Student temp = LookStudent(students, name);
                    if (temp != null)
                    {
                        if (temp.regDegree != null)
                        {
                            Console.Write("Enter Subject Code: ");
                            string code = Console.ReadLine();
                            bool x = IsSubjectAvailableForADegree(temp.regDegree, code);
                            if (x)
                            {
                                temp.regSubjects.Add(ReturnSubjectFromCode(temp.regDegree.subjects, code));
                            }
                            else
                            {
                                Console.WriteLine("Subject Not Found!!!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Student is not registered in any program!!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Student Not Found!!");
                    }
                    Console.ReadKey();
                }
                else if (option == 7)
                {
                    Console.Clear();
                    Console.WriteLine("Name         Fee");
                    foreach (Student x in students)
                    {
                        Console.WriteLine(x.name + "         " + x.returnFee());
                    }
                    Console.ReadKey();
                }
                else if (option > 8)
                {
                    Console.WriteLine("Incorrect Choice!!!");
                    Console.WriteLine("Enter Valid Choice!!");
                }
            }
            while (option != 8);
        }
        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. View Registered Students");
            Console.WriteLine("5. View Students of a Specific Program");
            Console.WriteLine("6. Registered Subject for a Specific Student");
            Console.WriteLine("7. Calculate Fee for all Registered Students");
            Console.WriteLine("8. Exit");
            Console.Write("Enter Choice: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        static Student AddStudent()
        {
            Console.Clear();
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter FSC Marks: ");
            int fsc = int.Parse(Console.ReadLine());
            Console.Write("Enter ECAT Marks: ");
            int ecat = int.Parse(Console.ReadLine());

            Student temp = new Student(name, age, fsc, ecat);
            return temp;
        }
        static DegreeProgram AddDegreeProgram()
        {
            Console.Clear();
            Console.Write("Enter Program Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Duration: ");
            int duration = int.Parse(Console.ReadLine());
            Console.Write("Enter Available Seats: ");
            int seats = int.Parse(Console.ReadLine());
            Console.Write("Enter Minimum Aggregate: ");
            float agg = float.Parse(Console.ReadLine());

            DegreeProgram temp = new DegreeProgram(name, duration, seats, agg);
            return temp;
        }
        static Subject AddSubject()
        {
            Console.Write("Enter Subject Code: ");
            string code = Console.ReadLine();
            Console.Write("Enter Subject Type: ");
            string type = Console.ReadLine();
            Console.Write("Enter Credit Hours: ");
            int credit = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject Fees: ");
            float fee = float.Parse(Console.ReadLine());

            Subject temp = new Subject(code, type, credit, fee);
            return temp;
        }
        static DegreeProgram ReturnDegreeFromName(List<DegreeProgram> degreePrograms, string name)
        {
            foreach (DegreeProgram x in degreePrograms)
            {
                if (name == x.name)
                {
                    return x;
                }
            }
            return null;
        }
        static void PrintStudentsOfSpecificDegree(List<Student> students, DegreeProgram x)
        {
            Console.Clear();
            Console.WriteLine("Name     FSC     ECAT    Age");
            foreach (Student c in students)
            {
                if (c.regDegree == x)
                {
                    Console.WriteLine(c.name + "    " + c.fscMarks + "      " + c.ecatMarks + "     " + c.age);
                }
            }
        }
        static void PrintDegreePrograms(List<DegreeProgram> degreePrograms)
        {
            Console.WriteLine("Available Degree Programs");
            foreach (DegreeProgram x in degreePrograms)
            {
                Console.WriteLine(x.name);
            }
        }
        static void ViewRegisteredStudents(List<Student> students)
        {
            Console.Clear();
            Console.WriteLine("Name     FSC     ECAT    Age");
            foreach (Student x in students)
            {
                if (x.regDegree != null)
                {
                    Console.WriteLine(x.name + "    " + x.fscMarks + "      " + x.ecatMarks + "     " + x.age);
                }
            }
        }
        static Student LookStudent(List<Student> students, string name)
        {
            foreach (Student x in students)
            {
                if (x.name == name)
                {
                    return x;
                }
            }
            return null;
        }
        static bool IsSubjectAvailableForADegree(DegreeProgram degree, string code)
        {
            foreach (Subject x in degree.subjects)
            {
                if (code == x.code)
                {
                    return true;
                }
            }
            return false;
        }
        static Subject ReturnSubjectFromCode(List<Subject> subjects, string code)
        {
            foreach (Subject x in subjects)
            {
                if (x.code == code)
                {
                    return x;
                }
            }
            return null;
        }
        static void ProcessAdmittedDegree(List<Student> students)
        {
            foreach (Student x in students)
            {
                for (int i = 0; i < x.preferences.Count; i++)
                {
                    if (x.merit >= x.preferences[i].minAggregate)
                    {
                        x.regDegree = x.preferences[i];
                    }
                }
            }
        }
        static void PrintRegisteredDegrees(List<Student> students)
        {
            foreach (Student x in students)
            {
                if (x.regDegree != null)
                {
                    Console.WriteLine(x.name + " got admission in " + x.regDegree.name);
                }
                else
                {
                    Console.WriteLine(x.name + " did not get admission.");
                }
            }
        }
    }
}
