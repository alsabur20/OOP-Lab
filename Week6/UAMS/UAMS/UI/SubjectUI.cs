using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.DL;
using UAMS.BL;

namespace UAMS.UI
{
    class SubjectUI
    {
        public static Subject AddSubject()
        {
            Console.WriteLine("Enter the code of subject:");
            string code = Console.ReadLine();
            Console.WriteLine("Enter the type of subject:");
            string type = Console.ReadLine();
            Console.WriteLine("Enter the credit hours of subject:");
            int creditHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fees of subject:");
            int subjectFees = int.Parse(Console.ReadLine());
            Subject s = new Subject(code, type, creditHours, subjectFees);
            return s;
        }
        public static void ViewSubjects(Student s)
        {
            if(s.reg_degree != null)
            {
                Console.WriteLine("Subject Code".PadRight(20) + "Subject Type".PadRight(20));
                foreach(Subject su in s.reg_degree.sub_offered)
                {
                    Console.WriteLine(su.code.PadRight(20) + su.type.PadRight(20));
                }
            }
            Console.ReadKey();
        }
        public static void registersubjects(Student s)
        {
            Console.WriteLine("how many subjects you want to enter : ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("enter the code of subject : ");
                string code = Console.ReadLine();
                bool flag = false;
                foreach (Subject sub in s.reg_degree.sub_offered)
                {
                    if (code == sub.code && !(s.reg_subjects.Contains(sub)))
                    {
                        if (s.regStudentSubject(sub))
                        {
                            flag = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("A student cannot have more than 9 CH ");
                            flag = true;
                        }
                    }

                }
                if (flag == false)
                {
                    Console.WriteLine("enter valid course ");
                    i--;
                }
            }
        }
        

     
    }
}
