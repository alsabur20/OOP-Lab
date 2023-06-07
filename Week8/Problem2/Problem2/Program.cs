using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem2.BL;
using Problem2.DL;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Sabur", "Lahore", "CS", 1, 20000.0F);
            Student s2 = new Student("Wali", "Lahore", "CS", 1, 10000.0F);
            Staff st1 = new Staff("ABC", "Lahore", "DPS", 50000.0F);
            Staff st2 = new Staff("DEF", "Lahore", "Beaconhouse", 100000.0F);

            PersonDL.AddPerson(s1);
            PersonDL.AddPerson(s2);
            PersonDL.AddPerson(st1);
            PersonDL.AddPerson(st2);

            foreach (Person x in PersonDL.p)
            {
                Console.WriteLine(x.toString());
            }
            Console.ReadKey();
        }
    }
}
