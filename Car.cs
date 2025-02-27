// Written by Jeremy Derhaag
// 02/27/2025



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5_Vehicles_and_cars
{
    public class Car : Vehicle
    {
        // private
        int numOfDoors = 0;


        // gets and sets
        public int NumOfDoors
        {
            get { return numOfDoors; }
            set { numOfDoors = value; }
        }

        
        // constructor
        public Car(int aYear, string aMake, string aModel, int aNumDoor) : base(aYear, aMake, aModel)
        {
            this.numOfDoors = aNumDoor;
        }

       
        // method
        public override string ToString()
        {
            string message = base.ToString() + "With " + this.NumOfDoors + "doors.";
            return message;


        }

    }
}
