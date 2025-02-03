// Written by Jeremy Derhaag
//  02/02/2025




using System.ComponentModel.Design;

namespace TheDefenseOfConsolas
{
    public class TheDefenseOfConsolas
    {
        static void Main(string[] args)
        {
            // Re-names the console window
            Console.Title = "Defense of Consolas";
            
            // Prompts and reads user imput
            Console.WriteLine("Target Row?");
            string rowText = Console.ReadLine();

            Console.WriteLine("Target Column?");
            string columnText = Console.ReadLine();

            // data type conversion fromstring to int
            int row = Convert.ToInt32(rowText);
            int column = Convert.ToInt32(columnText);

            // Assigning values to the four points around the target
            int person1Row = row + 1;
            int person1Column = column;

            int person2Row = row;
            int person2Column = column + 1;

            int person3Row = row - 1;
            int person3Column = column;

            int person4Row = row;
            int person4Column = column - 1;

           
            // Changing appearence of out put and playing beep
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Beep();
            
            // output
            Console.WriteLine("Deploy To: " + "\n" + "("+person1Row+","+person1Column+")" + "\n" + "("+person2Row+","+person2Column+")" + "\n"
                + "("+person3Row+","+person3Column+")" + "\n" + "(" + person4Row + "," + person4Column + ")");

            
        }
    }
}
