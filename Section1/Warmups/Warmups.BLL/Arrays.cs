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
            int Temp = numbers[0];
            int[] Rotated = { numbers[1], numbers[2], Temp };
            return Rotated;

        }
        public int[] Reverse(int[] numbers)
        {
            if (numbers.Length == 1)
            {
                return numbers;
            }
            Array.Reverse(numbers);
            return numbers;
        }

        public int[] HigherWins(int[] numbers)
        {
            int Temp = 0;

            if (numbers[0] > numbers[numbers.Length - 1])
            {
                Temp = numbers[0];
            }
            else
            {
                Temp = numbers[numbers.Length - 1];
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Temp;
            }
            return numbers;
        }

        public int[] GetMiddle(int[] a, int[] b)
        {
            int[] Middle2 = { a[1], b[1] };
            return Middle2;
        }

        public bool HasEven(int[] numbers)
        {
            if ((numbers[0] % 2 == 0) || (numbers[1] % 2 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int[] KeepLast(int[] numbers)
        {
            int[] DoubleTheLength = new int[numbers.Length * 2];
            DoubleTheLength[DoubleTheLength.Length - 1] = numbers[numbers.Length - 1];
            return DoubleTheLength;
        }

        public bool Double23(int[] numbers)
        {
            int Count2 = 0;
            int Count3 = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 2)
                {
                    Count2++;
                }
                else
                if (numbers[i] == 3)
                {
                    Count3++;
                }
            }
            return Count2 == 2 || Count3 == 2;
        }

        public int[] Fix23(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 2 && numbers[i + 1] == 3)
                {
                    numbers[i + 1] = 0;
                }
            }
            return numbers;
        }

        public bool Unlucky1(int[] numbers)
        {
            if ((numbers[0] == 1 && numbers[1] == 3)
                || numbers[1] == 1 && numbers[2] == 3
                || (numbers[numbers.Length - 2] == 1
                && numbers[numbers.Length - 1] == 3))
                return true;
            else
                return false;
        }

        public int[] Make2(int[] a, int[] b)
        {
            int Temp1 = 0;
            int Temp2 = 0;

            if (a.Length >= 2)
            {
                Temp1 = a[0];
                Temp2 = a[1];
            }
            else
            if (a.Length == 1)
            {
                Temp1 = a[0];
                Temp2 = b[0];
            }
            else
        if (a.Length == 0)
            {
                Temp1 = b[0];
                Temp2 = b[1];
            }
           int[] NewTwoArray = { Temp1, Temp2 };
            return NewTwoArray;
        }
    }
}