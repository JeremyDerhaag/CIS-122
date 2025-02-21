// Written by Jeremy Derhaag
// 02/20/25


namespace firstNvowels
{
    internal class FirstNVowels
    {
        static void Main(string[] args)
        {
            




            // output through main
            Console.WriteLine(FirstNvowels("sharpening skills", 3));
        }

        static string FirstNvowels(string input, int count)
        {
            // sets up lists
            List<char> list = new List<char>();
            List<char> numOfVow = new List<char>();
            
            // checks for vowels and adds them
            foreach (char i in input)
            {
                if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
                {
                    list.Add(i);
                }
            }
            
            // makes sure to only have the nth vowels
            foreach (char i in list)
            {
                if (numOfVow.Count <  count)
                {
                    numOfVow.Add(i);

                }
            }
            
            // converts back to a string
            string output = string.Join(",", numOfVow.ToArray());
            return output;

            








        }
    }
}