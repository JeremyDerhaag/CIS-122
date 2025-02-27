// Written by Jeremy Derhaag
// 02/27/2025



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5_Employees_and_Specializations
{
    public class Manager : Employee
    {
        // private var
        private int numOfEm = -1;

        // gets and sets
        public int NumOfEm
        {
            get { return numOfEm; }
            set { numOfEm = value; }
        }


        // constructor
        public Manager(string aName, int aSalary, int aNumOfEm) : base(aName,aSalary)
        {
            this.NumOfEm = aNumOfEm;
        }

        // method
        public override string ToString()
        {
            string message = base.ToString() + ", Number of employees managed: " + NumOfEm;
            return message;
        }



    }
}
