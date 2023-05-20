using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using System.IO;

namespace UAMS.DL
{
    class SubjectDL
    {
        public static List<Subject> Subjects_List = new List<Subject>();
        public static Subject isSubjectExists(string name)
        {
            foreach(Subject s in Subjects_List)
            {
                if(name == s.type)
                {
                    return s;
                }
            }
            return null;
        }
        public static void AddStudent(Subject s)
        {
            Subjects_List.Add(s);
        }
        public static bool readFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splitrecord = record.Split(',');
                    string code = splitrecord[0];
                    string type = splitrecord[1];
                    int credithours = int.Parse(splitrecord[2]);
                    int subjectfee = int.Parse(splitrecord[3]);
                    Subject s = new Subject(code, type, credithours, subjectfee);
                    AddStudent(s);

                }
                f.Close();
                return true;
            }
            return false;
        }
        public static void storeintofile(string path, Subject s)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(s.code + "," + s.type + "," + s.creditHours + "," + s.subjectFees);
            f.Flush();
            f.Close();
        }
    }
}
