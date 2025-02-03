// Written by Jeremy Derhaag
//  02/02/2025




using System.Globalization;

namespace HW_1_Dominion_of_Kings
{
    public class DominionOfKings
    {
        static void Main(string[] args)
        {
            // Prompting user for inputs and reading them
            Console.WriteLine("How many estates do you have?");
            string numberOfEstatestext = Console.ReadLine();

            Console.WriteLine("How many duchys do you have?");
            string numberOfDuchy = Console.ReadLine();

            Console.WriteLine("How many provinces do you have?");
            string numberOfProvincesText = Console.ReadLine();

            // converting string to ints
            int NumberOfEstates = Convert.ToInt32(numberOfEstatestext);
            int NumberOfDuchy = Convert.ToInt32(numberOfDuchy);
            int NumberOfProvinces = Convert.ToInt32(numberOfProvincesText);

            // calculating total points
            int Total = 0;
            Total += NumberOfEstates;
            Total += (NumberOfDuchy * 3);
            Total += (NumberOfProvinces * 6);

            Console.WriteLine("Your point total is: " + Total);




        }
    }
}
