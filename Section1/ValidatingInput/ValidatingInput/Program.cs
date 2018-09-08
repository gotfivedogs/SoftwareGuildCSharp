using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatingInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = GetIntFromUser("Enter first number: ");
            int num2 = GetIntFromUser("Enter second number: ");
            Console.WriteLine("The sum is: {0}", num1 + num2);
            Console.ReadLine();
            //while (true)
            //{
            //    Console.Write("Enter a number: ");
            //    string input = Console.ReadLine();
            //    int number;
            //    if (int.TryParse(input, out number))
            //    {
            //        number++;
            //        Console.WriteLine("The number plus one is: {0}", number);
            //        Console.ReadLine();
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("That was not a valid number ");
            //    }
                
               
            }
        static int GetIntFromUser(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                int number;
                if(int.TryParse(input, out number))
                {
                    return number;
                }
                Console.WriteLine("That was not a valid integer.");
            }
        }
        }
    }
