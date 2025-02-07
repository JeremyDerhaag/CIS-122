// Written by Jeremy Derhaag
// 02/06/2025

namespace HW2_Buying_inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Builds the menu and intake user input
            Console.WriteLine("The following items are available:"  + "\n" + "1 - Rope" + "\n" + "2 - Torches" + "\n" + "3 - Climbing Equipment" + "\n" + "4 + Clean Water" + "\n" 
                + "5 - Machete" + "\n" + "6 - Canoe" + "\n" + "7 - Food Supplies" + "\n" + "What number do you want to see the price of?");
            int choice = Convert.ToInt32(Console.ReadLine());

           // switch to decide output
            string response = choice switch
            {
                1 => "Rope Cost 1 gold.",
                2 => "2 Torches cost 15 gold.",
                3 => "Climbing equipment costs 10 gold.",
                4 => "Clean water costs 1 gold.",
                5 => "A Machete costs 20 gold.",
                6 => "A canoe costs 40 gold.",
                7 => "Food supplies cost 2 gold."
            };

           // output
            Console.WriteLine(response);


        }
    }
}
