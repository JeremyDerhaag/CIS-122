// Written by Jeremy Derhaag
// 02/27/2025



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5_Vehicles_and_cars
{
    public class Vehicle
    {
        // private var
        private string make = "n/a";
        private string model = "n/a";
        private int year = -1;

        // sets and gets 
        public string Make
        {
            get { return make; }
            set { this.make = value; }
        }

        public string Model
        { 
            get { return model; } 
            set { this.model = value; }
        }

        public int Year
        {
            get { return year; }
            set { this.year = value; }
        }

        // constructor
        public Vehicle(int aYear, string aMake, string aModel)
        {
            this.Make = aMake;
            this.Model = aModel;
            this.Year = aYear;
        }


        // Method

        public override string ToString()
        {
            string message = Year + " " + Make + " " + model;
            return message;
        }

            









    }
}
