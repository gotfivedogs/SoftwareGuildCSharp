using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int answer = rng.Next(1, 21);
            string input;
            int guess;
            while (true)
            {
                Console.Write("Enter a guess from 1 to 20: ");
                input = Console.ReadLine();
                if(int.TryParse(input, out guess))
                {
                    if (guess == answer)
                    {
                        break;
                    }
                    if (guess < 1 || guess > 20)
                    {
                        Console.WriteLine("Sorry, enter a number between 1 and 20!");
                        continue;
                    }
                    if (guess > answer)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Too High");
                        Console.BackgroundColor = ConsoleColor.Black;
                        continue;
                    }
                  
                    
                        Console.WriteLine("Too Low!");
                  
                    
                }
            }
            Console.WriteLine("You got it!  The answer was {0}.", answer);
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();

            
        }
    }
}
