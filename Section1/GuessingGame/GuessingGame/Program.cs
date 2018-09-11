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
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            if (name.ToUpper() == "Q")
            {
                Console.WriteLine("Thanks for playing!");
                Environment.Exit(0);
            }
            Random rng = new Random();
            Console.WriteLine("Select Mode - Enter E for Easy, N for Normal, or H for Hard");
            string mode = Console.ReadLine();
            int topLevel = 0;
            if (mode.ToUpper() == "E")
            {
                topLevel = 5;
            }
            if (mode.ToUpper() == "N")
            {
                topLevel = 20;
            }
            if (mode.ToUpper() == "H")
            {
                topLevel = 50;
            }
            int answer = rng.Next(1, topLevel);
            string input;
            int guessCount = 0;
            while (true)
            {
                Console.Write("Welcome, {0}, enter a guess from 1 to {1}: ", name, topLevel);
                input = Console.ReadLine();
                guessCount = guessCount + 1;
                if (input.ToUpper() == "Q")
                {
                    Console.WriteLine("{0}, thanks for playing!", name);
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (int.TryParse(input, out int guess))
                {
                    if (guess == answer)
                    {
                        break;
                    }
                    if (guess < 1 || guess > topLevel)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, {0}, enter a number between 1 and {1}!  Try again!", name, topLevel);
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                    if (guess > answer)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Too High, {0}!", name);
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                    if (guess < answer)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Too Low, {0}!", name);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not a parseable number!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}, you got it!  The answer was {1}.", name, answer);
            Console.ForegroundColor = ConsoleColor.White;
            if (guessCount == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU GOT IT ON THE FIRST GUESS!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The number of guesses is {0}", guessCount);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to exit, {0}...", name);
            Console.ReadKey();
        }
    }
}