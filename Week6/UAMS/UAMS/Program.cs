using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using UAMS.DL;
using UAMS.UI;

namespace UAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            string StudentPath = "D:\\OOPLab\\Week6\\UAMS\\Student.txt";
            string DegreePath = "D:\\OOPLab\\Week6\\UAMS\\Degree.txt";
            string SubjectPath = "D:\\OOPLab\\Week6\\UAMS\\Subject.txt";
            if (SubjectDL.readFromFile(SubjectPath))
            {
                Console.WriteLine("Subject Data loaded sucessfully!");
            }
            if (DegreeProgramsDL.readfromfile(DegreePath))
            {
                Console.WriteLine("Degree Data loaded sucessfully!");
            }
            if (StudentDL.ReadStudentsFromFile(StudentPath))
            {
                Console.WriteLine("Student Data loaded sucessfully!");
            }
            int option;
            do
            {
                option = menu();
                if (option == 1)
                {
                    Student s = StudentUI.addStudent();
                    StudentDL.AddStudent(s);
                    StudentDL.StoreStudentsToFile(StudentPath, s);
                }
                else if (option == 2)
                {
                    DegreePrograms d = DegreeProgramsUI.AddDegree();
                    DegreeProgramsDL.AddDegree(d);
                    DegreeProgramsDL.storeintofile(DegreePath, d);
                }
                else if (option == 3)
                {
                    Console.WriteLine("Enter the name of degree to add Subjects");
                    string name = Console.ReadLine();
                    for (int i = 0; i < DegreeProgramsDL.Program_list.Count; i++)
                    {
                        if (name == DegreeProgramsDL.Program_list[i].Name)
                        {
                            Subject s = SubjectUI.AddSubject();
                            DegreeProgramsDL.Program_list[i].AddSubject(s);
                        }
                    }
                }
                else if (option == 4)
                {
                    StudentDL.MeritList();
                    StudentDL.GiveAdmission();
                    StudentUI.PrintStudents();
                }
                else if (option == 5)
                {
                    StudentUI.PrintRegisteredStudents();
                }
                else if (option == 6)
                {
                    Console.WriteLine("Enter the name of degree:");
                    string degree = Console.ReadLine();
                    StudentUI.viewStudentsinDegree(degree);
                }
                else if (option == 7)
                {
                    Console.WriteLine("Enter the name of student:");
                    string name = Console.ReadLine();
                    Student su = StudentDL.Exist(name);
                    if (su != null)
                    {
                        SubjectUI.ViewSubjects(su);
                        SubjectUI.registersubjects(su);
                    }

                }
                else if (option == 8)
                {
                    StudentUI.CalculateFee();
                }
                
               
            }
            while (option != 9);
        }
    
                static int menu()
        {
            int option;
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Add subjects to a specific degree");
            Console.WriteLine("4. Generate Merit list");
            Console.WriteLine("5. View Registered Students");
            Console.WriteLine("6. View Students for a specific Program");
            Console.WriteLine("7. Register Subjects Students");
            Console.WriteLine("8. Calculate Feees for all students ");
            return option = int.Parse(Console.ReadLine());
        }
    }
}
