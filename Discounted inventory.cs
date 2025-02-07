// Written by Jeremy Derhaag
// 02/06/2025


namespace Discounted_inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Prompts and retrieves name from user
            Console.WriteLine("Hello, what's your name?");
            string name = Console.ReadLine();
            
         
            
            // Builds the menu and intake user input
            Console.WriteLine("The following items are available:" + "\n" + "1 - Rope" + "\n" + "2 - Torches" + "\n" + "3 - Climbing Equipment" + "\n" + "4 - Clean Water" + "\n"
                + "5 - Machete" + "\n" + "6 - Canoe" + "\n" + "7 - Food Supplies" + "\n" + "What number do you want to see the price of?");
            int choice = Convert.ToInt32(Console.ReadLine());

           
            // sets default prices for items
            double ropePrice = 1;
            double tourchesPrice = 15;
            double climbingEquipment = 10;
            double cleanWaterPrice = 1;
            double machetePrice = 20;
            double canoePrice = 40;
            double foodSuppliesPrice = 2;


           // Adds half off discount for matching names
            if (name == "Jeremy")
            {
                ropePrice /= 2;
                tourchesPrice /= 2;
                climbingEquipment /= 2;
                machetePrice /= 2;
                canoePrice /= 2;
                foodSuppliesPrice /= 2;
                cleanWaterPrice /= 2;
                
            }

          
            
            
            // switch to decide output
            string response = choice switch
            {
                1 => "Rope Cost " + ropePrice + " gold.",
                2 => "2 Torches cost " + tourchesPrice + " gold.",
                3 => "Climbing equipment cost " + climbingEquipment + " gold.",
                4 => "Clean water cost " + cleanWaterPrice + " gold.",
                5 => "A Machete costs " + machetePrice +  " gold.",
                6 => "A canoe costs " + canoePrice + " gold.",
                7 => "Food supplies cost " + foodSuppliesPrice + " gold."
            };

            // output
            Console.WriteLine(response);


        }
    }
}