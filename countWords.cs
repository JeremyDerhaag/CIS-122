// Written by Jeremy Derhaag
// 02/20/25


namespace Hw_4
{
    internal class countWords
    {
        static void Main(string[] args)
        {
            // input
            string words = ("This is a test");
            
            // sets initail value for length
            int length = 0;
            
            // checks to see if input is empty or not 
            if (words != null)
            {
                length = 1;
            }

            // checks to see if the previous character was a space
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i - 1] == ' ')
                {
                    length++;
                }






                
            }

            // output
            Console.WriteLine(length);
        }
    }
}
