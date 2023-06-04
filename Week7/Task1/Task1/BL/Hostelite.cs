using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    class Hostelite : Student
    {
        private int roomNumber;
        private bool isFridgeAvailable;
        private bool isInternetAvailable;

        public Hostelite(string name, string isDayScholar, int ecatMarks, int fscMarks, int roomNumber, bool isFridgeAvailable, bool isInternetAvailable) : base(name, isDayScholar, ecatMarks, fscMarks)
        {
            this.roomNumber = roomNumber;
            this.isFridgeAvailable = isFridgeAvailable;
            this.isInternetAvailable = isInternetAvailable;
        }
        public float GetHostelFee()
        {
            float fee = 0.0F;
            return fee;
        }
    }
}
