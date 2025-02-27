// Written by Jeremy Derhaag
// 02/27/2025


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5_Animals_and_sounds
{
    public class Cat : Animal
    {
        // constructor 
        public Cat(string aName) : base("Cat") { }

        // methods

        public override string Makesound()
        {
            return "Meow";
        }

        public override string ToString()
        {
            return base.ToString();
        }



    }
}
