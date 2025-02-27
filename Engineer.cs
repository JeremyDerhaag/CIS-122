// Written by Jeremy Derhaag
// 02/27/2025



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5_Employees_and_Specializations
{
    public class Engineer : Employee
    {
        // private var
        private string spec = "n/a";

        // gets and sets
        public string Spec
        {
            get { return spec; }
            set { spec = value; }
        }


        // Constructor
        public Engineer(string aName,int aSalary, string aSpec) : base(aName,aSalary)
        {
            this.Spec = aSpec;
        }


        // method
        public override string ToString()
        {
            string message = base.ToString() + ", Specialization: " + Spec;
            return message;
        }


    }
}
