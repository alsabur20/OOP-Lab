using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge1
{
    public class FireTruck
    {
        private Employee Employee;
        private Ladder Ladder;
        private Hose Hose;
        public FireTruck(Employee Employee,Ladder Ladder,Hose Hose)
        {
            this.Employee = Employee;
            this.Ladder = Ladder;
            this.Hose = Hose;
        }
        public void SetEmployee(Employee Employee)
        {
            this.Employee = Employee;
        }
        public Employee ReturnEmployee()
        {
            return this.Employee;
        }
        public void SetLadder(Ladder Ladder)
        {
            this.Ladder = Ladder;
        }
        public Ladder GetLadder()
        {
            return this.Ladder;
        }
        public void SetHose(Hose Hose)
        {
            this.Hose = Hose;
        }
        public Hose GetHose()
        {
            return this.Hose;
        }
    }
}