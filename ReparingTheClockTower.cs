// Written by Jeremy Derhaag
//  02/02/2025





namespace ReparingTheClockTower
{
    public class ReparingTheClockTower
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            string numberText = Console.ReadLine();

            int number = Convert.ToInt32(numberText);

            int x = number % 2;

            if (x == 0)
            {
                Console.WriteLine("Tick");
            }
            else
            {
                Console.WriteLine("Tock");
            }





        }
    } 
}
