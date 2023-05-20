using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class DegreePrograms
    {
        public string Name;
        public float Duration;
        public List<Subject> sub_offered;
        public int seats;
        public DegreePrograms(string degreeName, float
                           degreeDuration, int seats)
        {
            this.Name = degreeName;
            this.Duration = degreeDuration;
            this.seats = seats;
            sub_offered = new List<Subject>();

        }
        public DegreePrograms()
        {

        }
        public int calculateCreditHours()
        {
            int hours = 0;
            for(int i = 0; i < sub_offered.Count; i++)
            {
                hours = sub_offered[i].creditHours + hours;
            }
            return hours;
        }
        public void AddSubject(Subject s)
        {
            int creditHours = calculateCreditHours();
            if (creditHours + s.creditHours <= 20)
            {
                sub_offered.Add(s);
            }
            else
            {
                Console.WriteLine("20 credit hour limit exceeded");
            }
        }
        public bool isSubjectExists(Subject s)
        {
            for (int i = 0; i < sub_offered.Count; i++)
            {
                if (s == sub_offered[i])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
       
    }
    }
