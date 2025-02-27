// Written by Jeremy Derhaag
// 02/27/2025



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5_Shapes_and_areas
{
    public class Circle : Shape
    {
        // private var
        private double radius = 0;


        // gets and sets
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }


        // constructor
        public Circle(string aColor, double aRadius) : base(aColor)
        {
            Radius = aRadius;
        }

        // methods
        public override double GetArea()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }

        public override string ToString()
        {
            string message = base.ToString() + ", Radius: " + Radius + ", Area: " + this.GetArea();
            return message;
        }


    }
}
