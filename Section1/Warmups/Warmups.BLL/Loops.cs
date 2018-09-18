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
            bool amIDoubleX = false;
            int count = 0;
            while (true)
            {

            }
            for (int i = 0; i < str.Length-1; i++)
            {
              

            }
            return amIDoubleX;
        }

        public string EveryOther(string str)
        {
            throw new NotImplementedException();
        }

        public string StringSplosion(string str)
        {
            throw new NotImplementedException();
        }

        public int CountLast2(string str)
        {
            throw new NotImplementedException();
        }

        public int Count9(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool ArrayFront9(int[] numbers)
        {
            throw new NotImplementedException();
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
