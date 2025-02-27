// Written by Jeremy Derhaag
// 02/27/2025



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5_Vehicles_and_cars
{
    public class Motorcycle : Vehicle
    {
        // private var
        private bool hasSideCar = false;

        // gets and sets
        public bool HasSideCar
        {
            get { return hasSideCar; }
            set { this.hasSideCar = value; }
        }


        // constructor
        public Motorcycle(int aYear, string aMake, string aModel, bool Sidecar) : base(aYear, aMake, aModel)
        {
            this.HasSideCar = Sidecar;
        }


        // method
        public override string ToString()
        {
            string message = base.ToString() + "(Has side car: )" + this.HasSideCar;
            return message;
        }





    }
}
