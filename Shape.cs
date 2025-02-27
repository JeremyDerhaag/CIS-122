// Written by Jeremy Derhaag
// 02/27/2025



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5_Shapes_and_areas
{
    public abstract class Shape
    {
        // private var
        private string color = "n/a";


        // gets and sets
        public string Color 
        { 
            get { return color; } 
            set { color = value; }
        }

        // constructor
        public Shape(string aColor)
        {
            this.Color = aColor;
        }


        // methods
        public abstract double GetArea();

        public override string ToString()
        {
            string message = Color + " Shape";
            return message;
        }


    }
}
