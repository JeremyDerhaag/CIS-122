// Written by Jeremy Derhaag
// 02/06/2025


using System.Data.Common;

namespace Hw_2
{
    internal class WatchTower
    {
        static void Main(string[] args)
        {
           // Prompting and reading input
            Console.WriteLine("X Value: ");
            string xText = Console.ReadLine();

            Console.WriteLine("Y Value: ");
            string yText = Console.ReadLine();

            // Converting data types
            int x = Convert.ToInt32(xText);
            int y = Convert.ToInt32(yText);

            // creating strings to assign values to
            string row = "";
            string col = "";
            
            // Assigning values to the strings
            if (x > 0)
            {
                col = "East";
            }
            else if (x < 0)
            {
                col = "West";
            }
            else
            {
                col = "";
            }

            if (y > 0)
            {
                row = "North";
            }
            else if (y < 0)
            {
                row = "South";
            }
            else
            {
                if (x == 0)
                {
                    row = "Here";
                }
                else
                {
                    row = "";
                }
                
            }


            // combining the strings
            string location = row + col;
            // output
            Console.WriteLine("The Enemy is " + location + "!");

        }
    }
}
