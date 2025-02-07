namespace Hw2_Magick_cannon
{
    internal class MagickCannon
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x <= 100)
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                   Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(x + ": Combined");
                    x += 1;
                }
                else if (x % 3 == 0)
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine(x + ": Fire");
                    x += 1;
                }
                else if(x % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(x + ": Electric");
                    x += 1;
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.White;
                    Console.WriteLine(x + ": Normal");
                    x += 1;
                }



            }
        }
    }
}
