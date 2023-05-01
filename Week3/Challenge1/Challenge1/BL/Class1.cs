using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
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
        public void printTime(int seconds)
        {
            Console.WriteLine(seconds);
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
        public int elapsedTime()
        {
            return (this.hours - 0) * 3600 + (this.minutes - 0) * 60 + (this.seconds);
        }
        public int remainingTime()
        {
            return (23 - this.hours) * 3600 + (59 - this.minutes) * 60 + (60 - this.seconds);
        }
        public void ChangeTime(int seconds)
        {
            int h, m, s;
            h = seconds / 3600;
            m = (seconds - (h * 3600)) / 60;
            s = seconds - (h * 3600 + m * 60);
            Console.WriteLine(h + " " + m + " " + s);
        }
        public void difference(ClockType t)
        {
            if (this.hours > t.hours)
            {
                if (this.minutes >= t.minutes)
                {
                    if (!(this.seconds >= t.seconds))
                    {
                        this.minutes--;
                        this.seconds += 60;
                    }
                }
                else
                {
                    this.hours--;
                    this.minutes += 60;
                    if (!(this.seconds >= t.seconds))
                    {
                        this.minutes--;
                        this.seconds += 60;
                    }
                }
            }
            else
            {
                if (t.minutes >= this.minutes)
                {
                    if (!(t.seconds >= this.seconds))
                    {
                        t.minutes--;
                        t.seconds += 60;
                    }
                }
                else
                {
                    t.hours--;
                    t.minutes += 60;
                    if (!(t.seconds >= this.seconds))
                    {
                        t.minutes--;
                        t.seconds += 60;
                    }
                }
            }
            Console.Write("Time: ");
            Console.WriteLine((this.hours - t.hours) + " " + (this.minutes - t.minutes) + " " + (this.seconds - t.seconds));
        }
    }
}
