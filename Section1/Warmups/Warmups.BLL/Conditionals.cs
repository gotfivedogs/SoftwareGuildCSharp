using System;
using System.Linq;

namespace Warmups.BLL
{
    public class Conditionals
    {
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if ((aSmile == false) && (bSmile == false) || (aSmile == true && (bSmile == true)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            if ((isWeekday == false) || (isVacation == true))
            {
                return true;
            }
            return false;
        }

        public int SumDouble(int a, int b)
        {
            if (a == b)
            {
                return (a + b) * 2;
            }
            return a + b;
        }

        public int Diff21(int n)
        {
            if (n > 21)
            {
                return Math.Abs(21 - n) * 2;
            }
            return 21 - n;
        }

        public bool ParrotTrouble(bool isTalking, int hour)
        {
            if ((hour < 7 || hour > 20) && (isTalking.Equals(true)))
            {
                return true;
            }
            return false;
        }

        public bool Makes10(int a, int b)
        {
            if (a == 10 || (b == 10 || (a + b == 10)))
            {
                return true;
            }
            return false;
        }

        public bool NearHundred(int n)
        {
            if ((Math.Abs(n - 100) <= 10) || (Math.Abs(n - 200) <= 10))
            {
                return true;
            }
            return false;
        }

        public bool PosNeg(int a, int b, bool negative)
        {
            if (negative)
            {
                return a < 0 || b < 0;
            }
            else
            {
                return a < 0 ^ b < 0;
            }
        }

        public string NotString(string s)
        {
            if (s.StartsWith("not"))
            {
                return s;
            }
            return "not " + s;
        }

        public string MissingChar(string str, int n)
        {
            return str = str.Remove(n, 1);
        }
        public string FrontBack(string str)
        {
            if (str.Length < 2)
            {
                return str;
            }
            return str = str.Substring(str.Length - 1, 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1);
        }

        public string Front3(string str)
        {
            if (str.Length < 3)
            {
                return str + str + str;
            }
            return str.Substring(0, 3) + str.Substring(0, 3) + str.Substring(0, 3);
        }

        public string BackAround(string str)
        {
            return str.Substring(str.Length - 1) + str + str.Substring(str.Length - 1);
        }

        public bool Multiple3or5(int number)
        {
            if ((number % 3 == 0) || (number % 5 == 0))
            {
                return true;
            }
            return false;
        }

        public bool StartHi(string str)
        {
            if (str.Length < 2)
            {
                return false;
            }
            if ((str.Length == 2) && (str.Substring(0, 2) == "hi"))
            {
                return true;
            }
            if (((str.Substring(0, 3) == "hi ") || (str.Substring(0, 3) == "hi,")))
            {
                return true;
            }
            return false;
        }

        public bool IcyHot(int temp1, int temp2)
        {
            if (((temp1 >= 120) && (temp2 <= 0)) || ((temp2 >= 120) && (temp1 <= 0)))
            {
                return true;
            }
            return false;
        }

        public bool Between10and20(int a, int b)
        {
            if (((a >= 10) && (a <= 20)) || (b >= 10) && (b <= 20))
            {
                return true;
            }
            return false;
        }

        public bool HasTeen(int a, int b, int c)
        {
            if (((a >= 13) && (a <= 19))
                ||
                ((b >= 13) && (b <= 19))
                ||
                ((b >= 13) && (b <= 19)))
            {
                return true;
            }
            return false;
        }

        public bool SoAlone(int a, int b)
        {
            if (((a >= 13) && (a <= 19)) && (b >= 13) && (b <= 19))
            {
                return false;
            }
            else if (((a >= 13) && (a <= 19)) || (b >= 13) && (b <= 19))
            {
                return true;
            }
            return false;
        }

        public string RemoveDel(string str)
        {
            if (str.Contains("del"))
            {
                return str.Replace("del", "");
            }
            return str;
        }

        public bool IxStart(string str)
        {
            if (str.Substring(1, 2) == "ix")
            {
                return true;
            }
            return false;
        }

        public string StartOz(string str)
        {
            if (str.Length <= 1)
            {
                return "";
            }
            if ((str.Substring(0, 1) == "o") && (str.Substring(1, 1) == "z"))
            {
                return "oz";
            }
            else if (str.Substring(0, 1) == "o")
            {
                return str.Substring(0, 1);
            }
            else if (str.Substring(1, 1) == "z")
            {
                return str.Substring(1, 1);
            }
            return str.Substring(0, 2);
        }

        public int Max(int a, int b, int c)
        {
            int d = Math.Max(a, b);
            return Math.Max(d, c);
        }

        public int Closer(int a, int b)
        {
            if (Math.Abs(10 - a) > Math.Abs(10 - b))
            {
                return b;
            }
            if (Math.Abs(10 - a) < Math.Abs(10 - b))
            {
                return a;
            }
            return 0;
        }

        public bool GotE(string str)
        {
            var counted = str.GroupBy(c => c)
                   .Select(g => new { g.Key, Count = g.Count() });

            foreach (var result in counted)
            {
                Console.WriteLine("{0} = {1}", result.Key, result.Count);
            }
        }

        public string EndUp(string str)
        {
            throw new NotImplementedException();
        }

        public string EveryNth(string str, int n)
        {
            throw new NotImplementedException();
        }
    }
}
