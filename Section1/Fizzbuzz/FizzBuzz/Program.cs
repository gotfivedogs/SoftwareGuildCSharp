using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute();
            Console.ReadLine();
        }
        static void Execute()
        {
            int num = 0;
            for (int i = 1; i <= 100; i++)
            {
                num = i;
                if (num % 15 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("The number {0} is FizzBuzz!", num);
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                if (num % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The number {0} is Buzz", num);
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                if (num % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The number {0} is Fizz", num);
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("The number {0} is BORING!", num);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}