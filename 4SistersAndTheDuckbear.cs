// Written by Jeremy Derhaag
//  02/02/2025





namespace Hw_1_4_Sisters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for inmput
            Console.WriteLine("How many chocolate eggs were gathered today?");
            // recieve data from console window
            string numberOfEggsText = Console.ReadLine();
            // data type conversion from string to int
            int numberOfEggs = Convert.ToInt32(numberOfEggsText);
            // calculating the remainder 
            int duckbearEggs = numberOfEggs % 4;
            // calculates how much each sister would recieve
            int sisterEggs = (numberOfEggs - duckbearEggs) / 4;
            // outputs the answer
            Console.WriteLine("Each sister gets " + sisterEggs + " chocolate eggs." + "\n" + "Duckbear gets " + duckbearEggs + " chocolate eggs.");

        }
    }
}
