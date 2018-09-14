using System;

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
            throw new NotImplementedException();
        }

        public string MissingChar(string str, int n)
        {
            throw new NotImplementedException();
        }

        public string FrontBack(string str)
        {
            throw new NotImplementedException();
        }

        public string Front3(string str)
        {
            throw new NotImplementedException();
        }

        public string BackAround(string str)
        {
            throw new NotImplementedException();
        }

        public bool Multiple3or5(int number)
        {
            throw new NotImplementedException();
        }

        public bool StartHi(string str)
        {
            throw new NotImplementedException();
        }

        public bool IcyHot(int temp1, int temp2)
        {
            throw new NotImplementedException();
        }

        public bool Between10and20(int a, int b)
        {
            throw new NotImplementedException();
        }

        public bool HasTeen(int a, int b, int c)
        {
            throw new NotImplementedException();
        }

        public bool SoAlone(int a, int b)
        {
            throw new NotImplementedException();
        }

        public string RemoveDel(string str)
        {
            throw new NotImplementedException();
        }

        public bool IxStart(string str)
        {
            throw new NotImplementedException();
        }

        public string StartOz(string str)
        {
            throw new NotImplementedException();
        }

        public int Max(int a, int b, int c)
        {
            throw new NotImplementedException();
        }

        public int Closer(int a, int b)
        {
            throw new NotImplementedException();
        }

        public bool GotE(string str)
        {
            throw new NotImplementedException();
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
