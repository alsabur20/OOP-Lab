using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    class DayScholar : Student
    {
        public string pickUpPoint;
        public int busNo;
        public int pickUpDistance;

        public DayScholar(string name, string isDayScholar, int ecatMarks, int fscMarks, string pickUpPoint, int busNo, int pickUpDistance) : base(name, isDayScholar, ecatMarks, fscMarks)
        {
            this.pickUpDistance = pickUpDistance;
            this.busNo = busNo;
            this.pickUpPoint = pickUpPoint;
        }
        public float GetHostelFee()
        {
            float fee = 0;
            return fee;
        }
    }
}
