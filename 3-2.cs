// Written by Jeremy Derhaag
// 02/15/25


namespace HW3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int[] Num = { 2, -1, 4, 8, 10 };

            // initial sum value
            int Sum = 0;

            // loop to make positive and add to sum
            foreach (int i in Num)
            {
                // checks and corrects values to positive
                if (i < 0)
                {
                    int x = i * -1;
                    Sum += x;
                }
                else
                {
                    Sum += i;
                }

            }
            // output 
            Console.WriteLine(Sum);
        }
    }
}
