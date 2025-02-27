// Written by Jeremy Derhaag
// 02/27/2025


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5_Employees_and_Specializations
{
    public class Employee
    {
        // private var
        private string name = "n/a";
        private int salary = 0;

        // gets and sets
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        // constructor
        public Employee(string aName, int aSalary)
        {
            Name = aName;
            Salary = aSalary;
        }

        // method
        public override string ToString()
        {
            string message = "Name: " + Name + ", Salary: $" + Salary;
            return message;

        }
    }
}