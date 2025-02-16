// Written by Jeremy Derhaag
// 02/15/25

namespace Hw3_Simula_s_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // inital status of the chest
            string status = "locked";

            // sets up infinite loop
            int x = 1;
            while (x > 0)
            {

                Console.WriteLine("The chest is " + status + ". What do you want to do?");
                string action = Console.ReadLine();
                
                // Method for changing the status based on current status and input
                if (status == "locked")
                {
                    if (action == "unlock")
                    {
                        status = "unlocked";
                    }
                }
                else if (status == "unlocked")
                {
                    if (action == "open")
                    {
                        status = "open";
                    }
                    else if (action == "lock")
                    {
                        status = "locked";
                    }
                }
                else if (status == "open")
                {
                    if (action == "close")
                    {
                        status = "unlocked";
                    }
                }
                x++;
            }
        }
    }
}
