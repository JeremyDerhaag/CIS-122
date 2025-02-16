// Written by Jeremy Derhaag
// 02/15/25



namespace HW_3__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] Nums = {1,2,3,4,5 };

            // intitial values to check against
            int x = int.MaxValue;
            int y = int.MinValue;

            // loops to find min and max values
            foreach (int i in Nums)
            {
                if (i < x)
                {
                    x = i;
                }
                else if (i > y)
                {
                    y = i;
                }
            }

            //output
            (int,int) MinMax = (x,y);
            Console.WriteLine(MinMax);
            

        }
    }
}
