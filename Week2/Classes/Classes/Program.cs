using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        class students
        {
            public string sName;
            public int roll_No;
            public float cgpa;
        }
        static void Main(string[] args)
        {
            //Introduction():
            InputInClassObject();
            Console.ReadKey();
        }
        static void Introduction()
        {
            students s1 = new students();
            s1.sName = "Sabur";
            s1.roll_No = 98;
            s1.cgpa = 3.55F;

            Console.WriteLine("Name: {0} Roll Number: {1} CGPA: {2}", s1.sName, s1.roll_No, s1.cgpa);
        }
        static void InputInClassObject()
        {
            students s1 = new students();
            Console.Write("Name: ");
            s1.sName = Console.ReadLine();
            Console.Write("Roll Number: ");
            s1.roll_No = int.Parse(Console.ReadLine());
            Console.Write("CGPA: ");
            s1.cgpa = float.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0} Roll Number: {1} CGPA: {2}", s1.sName, s1.roll_No, s1.cgpa);
        }
    }
}
