using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge2
{
    public class Bicycle
    {
        private int cadence;
        private int gear;
        private int speed;
        
        public Bicycle(int cadence,int gear,int speed)
        {
            this.cadence = cadence;
            this.gear = gear;
            this.speed = speed;
        }
        public void SetCadence(int cadence)
        {
            throw new System.NotImplementedException();
        }

        public void SetGear(int gear)
        {
            throw new System.NotImplementedException();
        }

        public void ApplyBrake(int decrement)
        {
            throw new System.NotImplementedException();
        }

        public void Speed(int increment)
        {
            throw new System.NotImplementedException();
        }
    }
}