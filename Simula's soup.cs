// Written by Jeremy Derhaag
// 02/15/25

using System.Xml.Serialization;

namespace HW3_Simula_s_Soup
{
    public class HW3_Simula_s_Soup_
    {
        static void Main(string[] args)
        {
            int choice;


            // using switchs to get user input for enum choice
            Console.WriteLine("Select a food type: " + "\n" + "1: " + FoodType.Soup + "\n"+"2: " + FoodType.Stew + "\n" + "3: " + FoodType.Gumbo);
            
            choice = Convert.ToInt32(Console.ReadLine());
            FoodType a = choice switch
            {
                1 => FoodType.Soup,
                2 => FoodType.Stew,
                3 => FoodType.Gumbo,
            };

           Console.WriteLine();
            Console.WriteLine("Select Main Ingrediant: " + "\n" + "1: " + MainIng.Carrots + "\n" + "2: " + MainIng.Mushrooms + "\n" + "3: " + MainIng.Chicken + "\n" + "4: " + MainIng.Potatoes);
            choice = Convert.ToInt32(Console.ReadLine());
            MainIng b = choice switch
            {
                1 => MainIng.Carrots,
                2 => MainIng.Mushrooms,
                3 => MainIng.Chicken,
                4 => MainIng.Potatoes
            };


            Console.WriteLine();
            Console.WriteLine("Select Seasonings: " + "\n" + "1: " + Seasoning.Spicy + "\n" + "2: " + Seasoning.Salty + "\n" + "3: " + Seasoning.Sweet);
            choice = Convert.ToInt32(Console.ReadLine());
            Seasoning c = choice switch
            {
                1 => Seasoning.Spicy,
                2 => Seasoning.Salty,
                3 => Seasoning.Sweet,
            };



            // puts output into a Tuple
            (Seasoning, MainIng, FoodType) order = (c,b,a);
            Console.WriteLine(order);


            
        }
       
    }
    enum FoodType { Stew, Soup, Gumbo }
    enum MainIng { Mushrooms, Chicken, Carrots, Potatoes }
    enum Seasoning { Sweet, Spicy, Salty }
     
    }
