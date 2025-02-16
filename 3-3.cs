// Written by Jeremy Derhaag
// 02/15/25


namespace HW3__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int[] Num = {3,2,1,0 };
            List<int> List = new List<int>();

            // multiplys by length and adds them to a list
            foreach (int i in Num)
            {
                int x = i * Num.Length;
                List.Add(x);
                
            }

            // converts list back to an array
            int[] Output = List.ToArray();

            // output
            foreach (int i in Output)
            {
                Console.WriteLine(i);
            }
            
            
            
            
        }
    }
}
