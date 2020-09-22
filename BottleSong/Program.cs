using System;

namespace BottleSong
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 10; i > 0; i--)
            {
                Console.WriteLine($"{i} bottels of beer on the wall, \n {i} bottels of beer, \n take one down, \n pass it around, \n  {i - 1} bottels of beer!");
     
            }
           
           
        }
    }
}
