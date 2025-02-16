// Written by Jeremy Derhaag
// 02/15/25

namespace Hw_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initail variables
            int damage = 1;
            int CityHealth = 15;
            int ManticoreHealth = 10;
            int RoundNum = 1;

            // Setting Ships location
            Console.WriteLine("PLayer 1: How far away due you want to station the Manticore?");
            int ManticoreRange = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            
            Console.WriteLine("Player 2: It is your turn:");

            // loops over the game play
            while (true) 
            {
                if (ManticoreHealth > 0 && CityHealth > 0)
                {





                    // shows current status
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Status:");
                    Console.WriteLine("Round: " + RoundNum);
                    Console.WriteLine("City: " + CityHealth + "/15");
                    Console.WriteLine("Manticore: " + ManticoreHealth + "/10");

                    // Determines cannon damage based on round number
                    if (RoundNum % 3 == 0 && RoundNum % 5 == 0)
                    {
                        damage = 10;
                    }
                    else if (RoundNum % 5 == 0 || RoundNum % 3 == 0)
                    {
                        damage = 3;
                    }
                    else
                    {
                        damage = 1;
                    }

                    Console.WriteLine("The cannon is expected to do " + damage + " damage this turn");

                    Console.WriteLine("Enter desired cannon range: ");
                    int CannonRange = Convert.ToInt32(Console.ReadLine());

                    // determines if the shot was a hit
                    if (CannonRange == ManticoreRange)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Direct hit!" + "\n");
                        ManticoreHealth -= damage;
                    }
                    else if (CannonRange > ManticoreRange)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("The round OVERSHOT the target!" + "\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("The round FELL SHORT of the target!" + "\n");
                    }

                    RoundNum++;
                    CityHealth -= 1;
                }

                // displays end result and breaks loop
                else if (ManticoreHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("THE MANTICORE WAS DESTROYED!");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("THE CITY WAS DESTROYED!");
                    break;
                }
                }
        }
    }
}
