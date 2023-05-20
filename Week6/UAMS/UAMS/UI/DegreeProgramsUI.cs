using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.DL;
using UAMS.BL;

namespace UAMS.UI
{
    class DegreeProgramsUI
    {
       public  static DegreePrograms AddDegree()
        {
            Console.WriteLine("Enter title of degree Program:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter durattion of degree Program:");
            float duration = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of seats for the degree:");
            int seats = int.Parse(Console.ReadLine());
            Console.WriteLine("Subjects Adding:");
            Console.WriteLine("Enter number of subjects u want to add:");
            int number = int.Parse(Console.ReadLine());
            DegreePrograms d = new DegreePrograms(Name, duration, seats);
            for (int i = 0; i < number; i++)
            {
                Subject s = SubjectUI.AddSubject();
                d.AddSubject(s);
            }
            return d;

        }
    }
}
