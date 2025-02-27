// Written by Jeremy Derhaag
// 02/27/2025



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5_Animals_and_sounds
{
    public  class Animal
    {
        // privat var
        private string name = "n/a";

        // gets and sets
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // constructor 
        public Animal(string aName)
        {
            this.Name = aName;
        }


        // methods
        public virtual string Makesound()
        {
            return "Some generic animal sound";
        }

        public override string ToString()
        {
            string message = "Animal: " + this.Name + ", Sound: " + this.Makesound();
            return message;
        }


    }
}
