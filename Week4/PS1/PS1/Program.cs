using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS1.BL;

namespace PS1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Sabur", 98, 3.5F, 1053, 1027, 250, "Lahore", true, false);
            Console.WriteLine("Merit: {0}",s.meritCalculator());
            Console.WriteLine("Eligibility: {0}",s.isEligibleForSholarship(s.meritCalculator()));
            Console.ReadKey();
        }
        
    }
}
