using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Television tv = new Television();
            //tv.Power();
            //tv.Tune(5);
            //Console.ReadLine();

            //Scheduler s1 = new Scheduler();
            //if (s1.IsFederalHoliday(1, 2))
            //{
            //    Console.WriteLine("This is a federal holiday");
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("This is NOT a federal holiday");
            //}
            //Console.ReadLine();

            // Calculator calc = new Calculator();
            //Console.WriteLine(calc.Add(1, 5));
            // Console.ReadLine();
            //Person mary = new Person();
            //mary.Age = 20;
            //mary.Name = "Mary";
            //Console.WriteLine(mary.Name, mary.Age);
            //PersonEvents.HappyBirthday(mary);
            //Console.WriteLine(mary.Name, mary.Age);

            //double t = Math.Pow(2, 5);
            //Console.WriteLine(t);

            //int x = 1;

            //Person p = new Person();
            //p.Name = "Samantha";
            //Console.WriteLine(p.Name);

            //Person.PassingValues(x, p);
            //Console.WriteLine(x);
            //Console.WriteLine(p.Name);


            //string input = "hello";
            //int output;

            //if (!Parsing.TryParse(input, out output))
            //{
            //    Console.WriteLine($"{input} could not be converted.");
            //    Console.ReadLine();
            //}

            //input = "52";

            //if (Parsing.TryParse(input, out output))
            //{
            //    Console.WriteLine($"{input} was converted to {output}");
            //    Console.ReadLine();
            //}
            //Console.WriteLine(Adding.Add(5));
            //Console.WriteLine(Adding.Add(5, 10));
            //Console.WriteLine(Adding.Add(5, 10, 15));
            //Console.WriteLine(Adding.Sum(5));
            //Console.WriteLine(Adding.Sum(5, 10));
            //Console.WriteLine(Adding.Sum(5, 10, 15, 25, 520));
            Console.WriteLine(Adding.Factorial(4));
            Console.WriteLine(Adding.Factorial2(4));


            Console.ReadLine();
        }
    }
}