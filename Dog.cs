// Written by Jeremy Derhaag
// 02/27/2025


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5_Animals_and_sounds
{
    public class Dog : Animal
    {

        // constructor
        public Dog(string aName) : base("Dog") { }


        // methods
        public override string Makesound()
        {
            return "Bark";
        }

        public override string ToString()
        {
            return "Animal: Dog, Sound: " + this.Makesound();
        }


    }
}
