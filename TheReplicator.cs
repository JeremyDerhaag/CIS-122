// Written by Jeremy Derhaag
// 02/06/2025




namespace Hw2_The_replicater
{
    internal class TheReplicator
    {
        static void Main(string[] args)
        {
            // sets up needed arrays
            int[] array1 = new int[5];
            int[] array2 = new int[5];

           // inputs users numbers in array
            Console.WriteLine("Enter 5 numbers: ");
            array1[0] = Convert.ToInt32(Console.ReadLine());
            array1[1] = Convert.ToInt32(Console.ReadLine());
            array1[2] = Convert.ToInt32(Console.ReadLine());
            array1[3] = Convert.ToInt32(Console.ReadLine());
            array1[4] = Convert.ToInt32(Console.ReadLine());

           // copies and prints first array
            int x = 0;
            Console.WriteLine("Array 1:");
            foreach (int i in array1)
            {
                Console.WriteLine(i);
                array2[x] = i;
                x += 1;
            }

           
            // prints out 2nd array
            Console.WriteLine("Array 2:");
            foreach (int i in array2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
