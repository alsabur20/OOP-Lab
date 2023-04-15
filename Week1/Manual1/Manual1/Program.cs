using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manual1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();
            //Task10();
            ReadFromFile();
            WriteToFile();
        }

        static void Task1()
        {
            Console.Write("Hello World!");
            Console.Write("Hello World!");
            Console.ReadKey();
        }
        static void Task2()
        {
            Console.WriteLine("Hello World!");
            Console.Write("Hello World!");
            Console.ReadKey();
        }
        static void Task3()
        {
            int variable1 = 7;
            string variable2 = "I am a string";
            char variable3 = 'A';
            float variable4 = 2.2F;

            Console.WriteLine("Integer: {0} ",variable1);
            Console.WriteLine("String: {0} ", variable2);
            Console.WriteLine("Character: {0} ", variable3);
            Console.WriteLine("Float: {0} ", variable4);
            Console.ReadKey();
        }
        static void Task4()
        {
            int variable1;
            string variable2;
            float variable3;

            Console.Write("Integer: ");
            variable1 = int.Parse(Console.ReadLine());
            Console.Write("String: ");
            variable2 = Console.ReadLine();
            Console.Write("Float: ");
            variable3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Your inputted Integer: {0} ", variable1);
            Console.WriteLine("Your inputted String: {0} ", variable2);
            Console.WriteLine("Your inputted Float: {0} ", variable3);
            Console.ReadKey();
        }
        static void Task5()
        {
            float length, area;
            Console.Write("Enter Length: ");
            length=float.Parse(Console.ReadLine());
            area = length * length;
            Console.WriteLine("Area: {0}", area);
            Console.ReadKey();
        }
        static void Task6()
        {
            float marks;
            Console.Write("Enter Marks: ");
            marks = float.Parse(Console.ReadLine());

            if (marks > 50)
            {
                Console.WriteLine("You are Passed!");
            }
            else
            {
                Console.WriteLine("You are Failed!");
            }
            Console.ReadKey();
        }
        static void Task7()
        {
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Welcome Jack!!");
            }
            Console.ReadKey();
        }
        static void Task8()
        {
            int num, sum = 0;
            Console.Write("Enter Number: ");
            num = int.Parse(Console.ReadLine());
            while (num != -1)
            {
                sum += num;
                Console.Write("Enter Number: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum is: {0}", sum);
            Console.ReadKey();
        }
        static void Task9()
        {
            int num=0, sum = 0;
            do
            {
                sum += num;
                Console.Write("Enter Number: ");
                num = int.Parse(Console.ReadLine());
            }
            while (num != -1) ;
            sum++;
            Console.WriteLine("Sum is: {0}", sum);
            Console.ReadKey();
        }
        static void Task10()
        {
            //Taking Input
            int[] numbers = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter Number {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            //Finding The Largest
            int largest = -1;
            for (int i = 0; i < 3; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            Console.WriteLine("Largest Number: {0}", largest);
            Console.ReadKey();
        }
        static void ReadFromFile()
        {
            string path = "E:\\Week1\\Manual1\\text.txt";

            if(File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while((record = file.ReadLine())!=null)
                {
                    Console.WriteLine(record);
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("Not Exists!");
            }
            Console.ReadKey();
        }
        static void WriteToFile()
        {
            string path = "E:\\Week1\\Manual1\\text.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine("Hello!!");
            file.Flush();
            file.Close();
        }
    }
}
