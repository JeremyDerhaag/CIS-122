// Written by Jeremy Derhaag
//  02/02/2025



namespace Hw_1
{
    public class TriangleArea
    {
        static void Main(string[] args)
        {
           
            // Prompting and reading inputs from the user
            Console.Write("What is the Base length?");
            string TbaseText = Console.ReadLine();
            Console.WriteLine("What is the Height?");
            string TheightText = Console.ReadLine();
            
           
            // calculating the area
            double tBase = Convert.ToDouble(TbaseText) ;
            double tHeight = Convert.ToDouble(TheightText) ;
            double areaOfTriangle = (tBase * tHeight)/2 ;
            
            
            
            Console.WriteLine("The Area is: " + areaOfTriangle);
        }
    }
}
