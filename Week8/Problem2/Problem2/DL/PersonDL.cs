using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem2.BL;

namespace Problem2.DL
{
    class PersonDL
    {
        public static List<Person> p = new List<Person>();

        public static void AddPerson(Person c)
        {
            p.Add(c);
        }
    }
}
