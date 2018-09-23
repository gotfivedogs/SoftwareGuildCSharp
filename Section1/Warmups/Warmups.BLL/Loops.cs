using System;

namespace Warmups.BLL
{
    public class Loops
    {
        public string StringTimes(string str, int n)
        {
            string newString = "";
            for (int i = 0; i < n; i++)
            {
                newString += str;
            }
            return newString;
        }

        public string FrontTimes(string str, int n)
        {
            string frontThree = str.Substring(0, 3);
            string newString = "";
            for (int i = 0; i < n; i++)
            {
                newString += frontThree;
            }
            return newString;
        }
        public int CountXX(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if ((str.Substring(i, 1) + str.Substring(i + 1, 1) == "xx"))
                {
                    count += 1;
                }
            }
            return count;
        }

        public bool DoubleX(string str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i].Equals('x'))
                {
                    if (str[i + 1].Equals('x'))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public string EveryOther(string str)
        {
            string CompressedString = "";

            for (int i = 0; i < str.Length; i += 2)
            {
                CompressedString += str[i];
            }
            return CompressedString;
        }

        public string StringSplosion(string str)
        {
            string StringExplosion = "";
            string NewString = "";
            for (int i = 0; i < str.Length; i++)
            {
                StringExplosion = StringExplosion += str[i];
                NewString = NewString + StringExplosion;
            }
            return NewString;
        }

        public int CountLast2(string str)
        {
            int SubStringCount = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if ((str.Substring(i, 2) == str.Substring(str.Length - 2, 2)))
                {
                    SubStringCount += 1;
                }
            }
            return SubStringCount - 1;
        }

        public int Count9(int[] numbers)
        {
            int NumberOfNines = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 9)
                {
                    NumberOfNines += 1;
                }
            }
            return NumberOfNines;
        }

        public bool ArrayFront9(int[] numbers)
        {
            int NineCount = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if ((numbers[i] == 9))
                {
                    NineCount += 1;
                }
            }
            return (NineCount >= 1);
        }

        public bool Array123(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 2; i++)
                if (numbers[i] + numbers[i + 1] + numbers[i + 2] == 6)
                    return true;

            return false;
        }
        public int SubStringMatch(string a, string b)
        {
            int HowManyMatch = 0;

            for (int i = 0; i < b.Length - 1; i++)
            {
                if ((a[i] + a[i + 1]) == b[i] + b[i + 1])
                {
                    HowManyMatch++;
                }
            }
            return HowManyMatch;
        }

        public string StringX(string str)
        {
            string First = "";
            string Last = "";
            string WithoutAnX = "";
            if (str.StartsWith("x"))
            {
                First = "x";
            }
            if (str.EndsWith("x"))
            {
                Last = "x";
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != 'x')
                {
                    WithoutAnX = WithoutAnX + str[i];
                }
            }
            return First + WithoutAnX + Last;
        }

        public string AltPairs(string str)
        {
            string CompactedString = "";
            int counter = 0;
            if (str.Length < 2)
                return str;
            else
            {
                for (int i = 0; i < str.Length; i += 2)
                {
                    if (counter % 2 == 0)
                    {
                        if (i + 1 == str.Length)
                            CompactedString += str[i];
                        else if (i + 2 <= str.Length)
                            CompactedString += str.Substring(i, 2);
                    }
                    counter++;
                }
                return CompactedString;
            }


            for (int i = 0; i < str.Length - 1; i += 3)
            {
                CompactedString = CompactedString + str[i] + str[i + 1];
            }
            return CompactedString;
        }

        public string DoNotYak(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Equals('y') && str[i + 1].Equals('a') && str[i + 2].Equals('k'))
                    return str.Substring(3);
                else
                {
                    if (str[i + 3].Equals('y') && str[i + 4].Equals('a') && str[i + 5].Equals('k'))
                        return str.Substring(0, 3);
                }
            }
            return str;
        }

        public int Array667(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if ((numbers[i] == 6 && numbers[i + 1] == 6) || (numbers[i + 1]) == 7)
                {
                    count++;
                }
            }
            return count;
        }

        public bool NoTriples(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] == numbers[i + 1] && numbers[i + 1] == numbers[i + 2])
                {
                    count++;
                }
            }
            return count == 0;
        }

        public bool Pattern51(int[] numbers)
        {
            bool Pattern = false;
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if ((numbers[i] + 5) == (numbers[i + 1]) && (numbers[i] - 1) == (numbers[i + 2]))
                {
                    Pattern = true;
                }
            }
            return Pattern;
        }
    }
}