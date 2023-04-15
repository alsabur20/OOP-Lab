using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Management_System.BL;

namespace Student_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Students[] s = new Students[10];
            char option;
            int count=0;
            do
            {
                option = menu();
                if (option == '1')
                {
                    s[count] = AddStudent();
                    count++;
                }
                else if (option == '2')
                {
                    ViewStudents(s, count);
                }
                else if (option == '3')
                {
                    TopStudent(s, count);
                }
                else if (option == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice!!");
                }
            }
            while (option != '4');
            Console.Write("Press any key to exit...");
            Console.Read();
        }
        static char menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Student");
            Console.WriteLine("3. Top 3 Students");
            Console.WriteLine("4. Exit");
            choice = char.Parse(Console.ReadLine ());
            return choice;
        }
        static Students AddStudent()
        {
            Console.Clear();
            Students s1 = new Students();
            Console.Write("Enter Name: ");
            s1.name = Console.ReadLine();
            Console.Write("Enter Roll Number: ");
            s1.roll_no = int.Parse(Console.ReadLine());
            Console.Write("Enter CGPA: ");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.Write("Enter Department: ");
            s1.department = Console.ReadLine();
            Console.Write("Is he/she Hostelide (y || n): ");
            s1.isHostelite = char.Parse(Console.ReadLine());
            return s1;
        }
        static void ViewStudents(Students[] s,int count)
        {
            Console.Clear();
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Name: {0} Roll Number: {1} CGPA: {2} Department: {3} Is Hostelide: {4};",s[i].name,s[i].roll_no,s[i].cgpa,s[i].department,s[i].isHostelite);
            }
            Console.Write("Press anykey to continue...");
            Console.ReadKey();
        }
        static void TopStudent(Students[] s,int count)
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("No Record Present!!!");
            }
            else if (count == 1)
            {
                ViewStudents(s, 1);
            }
            else if (count == 2)
            {
                for(int i = 0; i < 2; i++)
                {
                    int index = Largest(s, count, i);
                    Students temp = s[index];
                    s[index] = s[i];
                    s[i] = temp;
                }
                ViewStudents(s, 2);
            }
            else
            {
                for(int i = 0; i < 3; i++)
                {
                    int index = Largest(s, count, i);
                    Students temp = s[index];
                    s[index] = s[i];
                    s[i] = temp;
                }
                ViewStudents(s, 3);
            }
        }
        static int Largest(Students[] s,int count,int start)
        {
            int index = start;
            float large = s[start].cgpa;
            for(int i = 0; i < count; i++)
            {
                if (s[i].cgpa > large)
                {
                    large = s[i].cgpa;
                    index = i;
                }
            }
            return index;
        }
    }
}
