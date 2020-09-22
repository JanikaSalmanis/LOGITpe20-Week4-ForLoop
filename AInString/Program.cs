using System;

namespace AInString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*the program uses for-loop to count letter A/a in a given string*/
            Console.WriteLine("enter some text: ");
            string UserInput = Console.ReadLine();
            char searchCriteria = 'a';
            int counter = 0;

            for(int i = 0; i <UserInput.Length; i++)
            {
                if(UserInput[i] == searchCriteria)
                {
                    counter = counter + 1;  
                }
            }

            if(counter > 0)
            {
                Console.WriteLine($"There are {counter} a's in your text");
            }else 
            {
                Console.WriteLine($"There are no a's in your text");
            }
            
        }
    }
}
