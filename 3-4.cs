// Written by Jeremy Derhaag
// 02/15/25



namespace HW3__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input
            string[] input = {"21","44"};
            List<int> nums = new List<int>();

            // inital value to check against
            int smallernum = int.MaxValue;

            // converts strings to ints
            foreach (string i in input)
            {
                nums.Add(Convert.ToInt32(i));
            }

            // finds smallest value
            foreach (int i in nums)
            {
                if (i > smallernum)
                {
                    smallernum = i;
                }
                 
            }

            // converts the smallest value back to a string
            string output = Convert.ToString(smallernum);
            
            
            
            
            // output
            Console.WriteLine(output);
        }
    }
}
