using System;

namespace Warmups.BLL
{
    public class Arrays
    {
        public bool FirstLast6(int[] numbers)
        {
            return ((numbers[0] == 6) || (numbers[numbers.Length - 1]) == 6);
        }
        public bool SameFirstLast(int[] numbers)
        {
            return ((numbers.Length >= 1) && (numbers[0]) == (numbers[numbers.Length - 1]));
        }
        public int[] MakePi(int n)
        {
            int[] PiArray = new int[n];
            string PiMaker = Convert.ToString(Math.PI).Replace(".", "");
            for (int i = 0; i < n; i++)
            {
                PiArray[i] = Int32.Parse(PiMaker[i].ToString());
            }
            return PiArray;
        }
        public bool CommonEnd(int[] a, int[] b)
        {
            if ((a[0]) == (b[0]) || ((a[a.Length - 1]) == (b[b.Length - 1])))
            {
                return true;
            }
            return false;
        }
        public int Sum(int[] numbers)
        {
            int Sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Sum += numbers[i];
            }
            return Sum;
        }
        public int[] RotateLeft(int[] numbers)
        {
            throw new NotImplementedException();
        }
        public int[] Reverse(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int[] HigherWins(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int[] GetMiddle(int[] a, int[] b)
        {
            throw new NotImplementedException();
        }

        public bool HasEven(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int[] KeepLast(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool Double23(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int[] Fix23(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool Unlucky1(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int[] Make2(int[] a, int[] b)
        {
            throw new NotImplementedException();
        }

    }
}
