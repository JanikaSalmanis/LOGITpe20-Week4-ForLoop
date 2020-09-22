using System;

namespace BackwardsString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*the program asks users name and displays it vertically in reversed order - bacwards*/
            string name = "Harry";
           // Console.WriteLine(name[4]);
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(name[i]);
            }
            
        }
    }
}
