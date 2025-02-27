// Written by Jeremy Derhaag
// 02/27/2025



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5_Shapes_and_areas
{
    public class Rectangle : Shape
    {
        // private var
        private double width = 0;
        private double height = 0;


        // gets and sets
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }


        // Constructor
        public Rectangle(string aColor, double aWidth, double aHeight) : base(aColor)
        {
            this.Width = aWidth;
            this.Height = aHeight;
        }


        // methods
        public override double GetArea()
        {
            double area = Width * Height;
            return area;
        }

        public override string ToString()
        {
            string message = base.ToString() + ", Width: " + Width + ", Height: " + Height + ", Area: " + this.GetArea();
            return message;
        }



    }
}
