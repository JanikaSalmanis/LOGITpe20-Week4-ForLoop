﻿using System;

namespace ForLoopString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*the program asks the user´ s name, the program displays the name vertically*/

            string name = "Harry";
            for(int i = 0; i < name.Length; i++ )
            {
                Console.WriteLine($"{i}. {name[i]}");
            }
        }
    }
}
