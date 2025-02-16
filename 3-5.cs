// Written by Jeremy Derhaag
// 02/15/25


namespace HW3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = ("My friend Dylan got distracted in school.");
           
            // converts the string to individual letters
            List<char> Ds = new List<char>();
            char[] letters = input.ToCharArray();

            // checks to see if character is a d and adds to a list
            foreach (char c in letters)
            {
                if (c == 'd' || c == 'D')
                {
                    Ds.Add(c);

                 
                }
            }

            // finds length of list of Ds
            int NumD = Ds.Count;
            Console.WriteLine(NumD);
        }
    }
}
