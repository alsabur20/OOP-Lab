using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practise.BL;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1AandB();
            //Task2AandB();
            //Task3AandB();
            ForeachLoop();


            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
        static void Task1AandB()
        {
            Student s1 = new Student();
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.uMarks);
            Console.WriteLine(s1.eMarks);
            Console.WriteLine(s1.mMarks);

            Student s2 = new Student();
            Console.WriteLine(s2.name);
            Console.WriteLine(s2.uMarks);
            Console.WriteLine(s2.eMarks);
            Console.WriteLine(s2.mMarks);
        }
        static void Task2AandB()
        {
            Student s1 = new Student("Abdul");
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.uMarks);
            Console.WriteLine(s1.eMarks);
            Console.WriteLine(s1.mMarks);

            Student s2 = new Student("Sabur");
            Console.WriteLine(s2.name);
            Console.WriteLine(s2.uMarks);
            Console.WriteLine(s2.eMarks);
            Console.WriteLine(s2.mMarks);
        }
        static void Task3AandB()
        {
            Student s1 = new Student("Abdul");
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.uMarks);
            Console.WriteLine(s1.eMarks);
            Console.WriteLine(s1.mMarks);

            Student s2 = new Student(s1);
            Console.WriteLine(s2.name);
            Console.WriteLine(s2.uMarks);
            Console.WriteLine(s2.eMarks);
            Console.WriteLine(s2.mMarks);
        }
        static void ForeachLoop()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            foreach(var i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
