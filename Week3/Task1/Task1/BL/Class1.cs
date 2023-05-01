using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    class ClockType
    {
        public int hours;
        public int minutes;
        public int seconds;

        public ClockType()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public ClockType(int hours)
        {
            this.hours = hours;
        }
        public ClockType(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }
        public ClockType(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public void incrementHours()
        {
            hours++;
        }
        public void incrementMinutes()
        {
            minutes++;
        }
        public void incrementSeconds()
        {
            seconds++;
        }
        public void printTime()
        {
            Console.WriteLine(hours + " " + minutes + " " + seconds);
        }
        public bool isEqual(int hours, int minutes, int seconds)
        {
            if (this.hours == hours && this.minutes == minutes && this.seconds == seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEqual(ClockType temp)
        {
            if (this.hours == temp.hours && this.minutes == temp.minutes && this.seconds == temp.seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
