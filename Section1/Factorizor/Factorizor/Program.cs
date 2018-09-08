using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = GetNumberFromUser();

            Calculator.PrintFactors(number);
            Calculator.IsPerfectNumber(number);
            Calculator.IsPrimeNumber(number);

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }
        static int GetNumberFromUser()
        {
            string input;
            while (true)
            {
                Console.WriteLine("Enter a number");
                input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Try Again - must be numeric");
                    continue;
                }
            }
        }
        class Calculator
        {
            /// Given a number, print the factors per the specification
            public static void PrintFactors(int number)
            {
                int[] FactorArray = GetFactors(number);
                Console.WriteLine(string.Join(",", FactorArray));
            }

            /// Given a number, print if it is perfect or not - sum of factors equals the number (without the number)
            public static void IsPerfectNumber(int number)
            {
                int[] FactorArray = GetFactors(number);
                int sum = 0;
                for (int i = 0; i < FactorArray.Length - 1; i++)
                {
                    sum += FactorArray[i];
                }
                if (sum == number)
                {
                    Console.WriteLine("{0} is a perfect number", number);

                }
                else
                {
                    Console.WriteLine("{0} is NOT a perfect number", number);

                }
            }

            /// Given a number, print if it is prime or not - array length 2 equals prime
            public static void IsPrimeNumber(int number)
            {
                int[] FactorArray = GetFactors(number);
                if (FactorArray.Length == 2)
                {
                    Console.WriteLine("{0} is a prime number", number);
                }
                else
                {
                    Console.WriteLine("{0} is NOT a prime number", number);
                }
            }

            //convert factor string to string array, convert string array to integer array, return integer array
            public static int[] GetFactors(int number)
            {
                string FactorString = "";
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        FactorString += i + " ";
                    }
                }
                FactorString = FactorString.Trim();
                string[] FactorArray = FactorString.Split(' ');
                int[] myInts = FactorArray.Select(int.Parse).ToArray();
                return myInts;
            }
        }
    }
}