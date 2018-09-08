using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Television
    {
        private bool _isOn = false;
        public void Power()
        {
            if (_isOn)
            {
                _isOn = false;
            }
            else
            {
                _isOn = true;
            }
        }
        private int _channel = 2;
        public void Tune(int number)
        {
            _channel = number;
        }


    }
    public class Scheduler
    {
        public bool IsFederalHoliday(int month, int day)
        {
            if (day == 1 && month == 1)
                return true;
            if (day == 18 && month == 1)
                return true;
            if (day == 15 && month == 2)
                return true;
            return false;
        }
    }
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
    public class PersonEvents
    {
        public static void HappyBirthday(Person p)
        {
            p.Age++;
        }

    }
    public class Person
    {
        public byte Age { get; set; }
        public string Name { get; set; }

        public static void PassingValues(int valueType, Person referenceType)
        {
            valueType = 5;
            referenceType.Name = "Jane";
        }
    }
    public class Parsing
    {
        public static bool TryParse(string s, out int value)
        {
            // check if each character is a digit
            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsDigit(s[i]))
                {
                    // found a non-digit character, fail
                    value = int.MinValue;
                    return false;
                }
            }

            // all characters are digits, set the output param
            value = int.Parse(s);

            // return success
            return true;
        }

    }
    public class Adding
    {
        public static int Add(int x, int y = 0, int z = 0)
        {
            return x + y + z;
        }

        public static int Sum(params int[] numbers)
        {
            // no numbers? 0
            if (numbers.Length < 1)
                return 0;

            int sum = 0;
            // loop the array indexes
            for (int i = 0; i < numbers.Length; i++)
            {
                // add the current number to sum
                sum += numbers[i];
            }

            return sum;
        }
        public static int Factorial(int number)
        {
            int product = number;
            number--;

            // keep multiplying until we hit zero
            while (number > 0)
            {
                product *= number;
                number--;
            }

            return product;
        }
        public static int Factorial2(int number)
        {
            if (number <= 1)
            {
                return number; // stop recursion
            }
            else
            {
                // next recursive step
                return number * Factorial2(number - 1);
            }
        }
    }
}
