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
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if ((numbers[i] == 9))
                {
                    NineCount += 1;
                }
            }
           return (NineCount >= 1) ;    
        }

    public bool Array123(int[] numbers)
    {
        throw new NotImplementedException();
    }

    public int SubStringMatch(string a, string b)
    {
        throw new NotImplementedException();
    }

    public string StringX(string str)
    {
        throw new NotImplementedException();
    }

    public string AltPairs(string str)
    {
        throw new NotImplementedException();
    }

    public string DoNotYak(string str)
    {
        throw new NotImplementedException();
    }

    public int Array667(int[] numbers)
    {
        throw new NotImplementedException();
    }

    public bool NoTriples(int[] numbers)
    {
        throw new NotImplementedException();
    }

    public bool Pattern51(int[] numbers)
    {
        throw new NotImplementedException();
    }

}
}
