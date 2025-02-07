namespace hw_2_the_prototype
{
    internal class Prototype
    {
        static void Main(string[] args)
        {
           
            // Sets up first person to set number
            Console.WriteLine("Pilot, enter a number between 0 and 100: ");
            double pilotNumber = Convert.ToDouble(Console.ReadLine());

           // Loops over until number is between 0 and 100
            while (true)
            {
                if (pilotNumber > 100 && pilotNumber < 0)
                {
                    Console.WriteLine("Pilot, enter a number between 0 and 100: ");
                    pilotNumber = Convert.ToDouble(Console.ReadLine());

                }
                else
                {
                    break;
                }

            }

            Console.Clear();

           // sets up guessing
            Console.WriteLine("Hunter, guess a number: ");

            int hunterNumber = Convert.ToInt32(Console.ReadLine());
          
            // Loops over guess until correct
            while (true)
            {
                if (hunterNumber < pilotNumber)
                {
                    Console.WriteLine(hunterNumber + " Is too low." + "\n" + "Whats your next guess?");
                    hunterNumber = Convert.ToInt32(Console.ReadLine());

                }
                else if (hunterNumber > pilotNumber)
                {
                    Console.WriteLine(hunterNumber + " Is too high" + "\n" + "Whats your next guess?");
                    hunterNumber = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine("You guessed the number!");







        }
    }
}
