using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1.BL
{
    class Student
    {
        public string name;
        public int rollNumber;
        public float cGPA;
        public int matricMarks;
        public int fscMarks;
        public int ecatMarks;
        public string homeTown;
        public bool isHostelite;
        public bool isTakingScholarship;

        public Student(string name,int rollNumber,float cGPA,int matricMarks,int fscMarks,int ecatMarks,string homeTown,bool isHostelite,bool isTakingScholarship)
        {
            this.name = name;
            this.rollNumber = rollNumber;
            this.cGPA = cGPA;
            this.matricMarks = matricMarks;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.homeTown = homeTown;
            this.isHostelite = isHostelite;
            this.isTakingScholarship = isTakingScholarship;
        }
        public float meritCalculator()
        {
            return 0.6F * (fscMarks*100F/1100) + 0.4F * (ecatMarks*100F/400F);
        }
        public bool isEligibleForSholarship(float meritPercentage)
        {
            bool x = false;
            if (meritPercentage > 80.0 && this.isHostelite == true)
            {
                x = true;
            }
            return x;
        }
    }
}
