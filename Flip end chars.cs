// Written by Jeremy Derhaag
// 02/20/25


namespace HW4_Flip_end_chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // input and sets up output
            string input = ("ada");
            string output = (null);

            // checks length and for doubles
            if (input.Length < 2)
            {
                output = "Incompatible";
            }
            else if (input[0] == input[input.Length-1])
            {
                output = "Two's a pair.";
            }
            else
            {
                // moves and adds characters
                output += input[input.Length - 1];
                for (int i = 1; i < (input.Length - 1); i++)
                {
                    output += input[i];
                }
                output += input[0];



            }
            Console.WriteLine(output);
        }
    }
}
