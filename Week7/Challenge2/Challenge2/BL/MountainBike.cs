using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge2
{
    public class MountainBike : Bicycle
    {
        private int seatHeight;

        public MountainBike(int seatHeight, int cadence, int gear, int speed) : base(cadence, gear, speed)
        {
            this.seatHeight = seatHeight;
        }
        public void SetSeatHeight(int seatHeight)
        {
            throw new System.NotImplementedException();
        }
    }
}