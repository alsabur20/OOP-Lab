using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using System.IO;

namespace UAMS.DL
{
    class DegreeProgramsDL
    {
        public static List<DegreePrograms> Program_list = new List<DegreePrograms>();
        public static void AddDegree(DegreePrograms d)
        {
            Program_list.Add(d);
        }
        public static DegreePrograms isDegreeExists(string name)
        {
            foreach (DegreePrograms d in Program_list)
            {
                if (name == d.Name)
                {
                    return d;
                }
            }
            return null;
        }
        public static void storeintofile(string path, DegreePrograms d)
        {

            StreamWriter f = new StreamWriter(path, true);
            string subjectname = "";
            for (int i = 0; i < d.sub_offered.Count - 1; i++)
            {
                subjectname = subjectname + d.sub_offered[i].type + ";";
            }
            subjectname = subjectname + d.sub_offered[d.sub_offered.Count - 1].type;
            f.WriteLine(d.Name + "," + d.Duration + "," + d.seats + "," + subjectname);
            f.Flush();
            f.Close();
        }
        public static bool readfromfile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedreocrd = record.Split(',');
                    string degreeName = splittedreocrd[0];
                    float degreeDuration = float.Parse(splittedreocrd[1]);
                    int seats = int.Parse(splittedreocrd[2]);
                    string[] splittedrecordforsubject = splittedreocrd[3].Split(';');
                    DegreePrograms d = new DegreePrograms(degreeName, degreeDuration, seats);
                    for (int i = 0; i < splittedrecordforsubject.Length; i++)
                    {
                        Subject s = SubjectDL.isSubjectExists(splittedrecordforsubject[i]);
                        if (s != null)
                        {
                            d.AddSubject(s);

                        }

                    }
                    AddDegree(d);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}
