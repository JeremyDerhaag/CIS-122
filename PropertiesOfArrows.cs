// Written by Jeremy Derhaag
// 02/15/25

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_Fletcher_s_Arrows
{
    public class Arrow
    {
        // Private variables
        private string arrowhead = "n/a";
        private string fletching = "n/a";
        private float length = -10000;
        private double cost = 0;


        // gets and sets
        public string Arrowhead
        {
            get => arrowhead;
            set => arrowhead = value;
        }
        public string Fletching
        {
            get => fletching;
            set => fletching = value;
        }
        public float Length
        {
            get => length;
            set => length = value;
        }

        // Constructors
        public Arrow() : this("steel", "plastic", 100)
        {

        }


        public Arrow(string aArrowhead, string aFletching, float aLength)
        {
            this.Arrowhead = aArrowhead;
            this.Fletching = aFletching;
            this.Length = aLength;

        }












        //Methods
        public double GetCost
        {
            get
            {
                if (this.Arrowhead == "steel")
                {
                    this.cost += 10;
                }
                else if (this.Arrowhead == "wood")
                {
                    this.cost += 3;
                }
                else if (this.Arrowhead == "obsidian")
                {
                    this.cost += 5;
                }

                if (this.Fletching == "plastic")
                {
                    this.cost += 10;
                }
                else if (this.Fletching == "turkey feathers")
                {
                    this.cost += 5;
                }
                else if (this.Fletching == "goose feathers")
                {
                    this.cost += 3;
                }

                this.cost += (this.Length * 0.05);
                return cost;
            }

        }




    }




}


