// Written by Jeremy Derhaag
// 02/20/25


namespace HW4_move
{
    internal class move
    {
        static void Main(string[] args)
        {

            // Output through main
            Console.WriteLine(Move("HELLO"));
        }

        static string Move(string raw)
        {
            // forces input to lower case
            string input = raw.ToLower();
            
            // sets up aray to refrence the index of
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            
            // sets up lists
            List<char> output = new List<char>();
            List<string> OutPut = new List<string>();
            
            // finds index, shifts by 1, then returns new character
            foreach (var item in input)
            {
                int index = Array.IndexOf(alphabet, item);
                output.Add(alphabet[index + 1]);
            }

            // converts for output
            foreach (var item in output)
            {
                OutPut.Add(Convert.ToString(item));
            }
            return string.Join("",OutPut.ToArray());

        }
    }
}