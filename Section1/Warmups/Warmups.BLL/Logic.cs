using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Logic
    {

        public bool GreatParty(int cigars, bool isWeekend)
        {
            if (cigars >= 40)
            {
                return ((cigars <= 60) || (isWeekend = true));
            }
            return false;
        }

        public int CanHazTable(int yourStyle, int dateStyle)
        {
            if ((yourStyle >= 8) || (dateStyle >= 8))
            {
                return 2;
            }
            else if ((yourStyle <= 2) || (dateStyle <= 2))
            {
                return 0;
            }
            return 1;
        }

        public bool PlayOutside(int temp, bool isSummer)
        {
            if (temp >= 60)
            {
                return ((temp <= 90) || (isSummer));
            }
            return false;
        }

        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            int Ticket = 0;
            if (isBirthday)
            {
                speed = speed - 5;
            }
            if (speed >= 85)
            {
                Ticket = 2;
            }
            else if ((speed >= 61) && (speed <= 80))
            {
                Ticket = 1;
            }
            return Ticket;
        }
        public int SkipSum(int a, int b)
        {
            int Sum = a + b;
            if ((Sum >= 10) && (Sum <= 19))
            {
                Sum = 20;
            }
            return Sum;
        }

        public string AlarmClock(int day, bool vacation)
        {
            String Alarm = "7:00";
            if (vacation)
            {
                if ((day > 0) && (day <= 6))
                {
                    Alarm = "10:00";
                }
                else
                {
                    Alarm = "Off";
                }
            }
            else
            {
                if ((day == 0) || (day == 6))
                {
                    Alarm = "10:00";
                }
            }
            return Alarm;
        }

        public bool LoveSix(int a, int b)
        {
            bool EqualsSix = false;
            if (a == 6 || b == 6)
            {
                EqualsSix = true;
            }
            else if ((Math.Abs(a + b) == 6) || (Math.Abs(a - b) == 6))
            {
                EqualsSix = true;
            }
            else
            {
                EqualsSix = false;
            }
            return EqualsSix;
        }

        public bool InRange(int n, bool outsideMode)
        {
            bool isCorrectMode = true;
            if (outsideMode)
            {
                if ((n >= 1) && (n <= 10))
                {
                    isCorrectMode = false;
                }
            }
            else
            {
                if ((n <= 1) || (n >= 10))
                {
                    isCorrectMode = false;
                }
            }
            return isCorrectMode;
        }
        public bool SpecialEleven(int n)
        {
            bool special = false;
            if ((n % 11 == 0) || (n - 1) % 11 == 0)
            {
                special = true;
            }
            return special;
        }

        public bool Mod20(int n)
        {
            if ((((n - 1) % 20 == 0))|| ((n - 2) % 20 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Mod35(int n)
        {
            throw new NotImplementedException();
        }

        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            throw new NotImplementedException();
        }

        public bool TwoIsOne(int a, int b, int c)
        {
            throw new NotImplementedException();
        }

        public bool AreInOrder(int a, int b, int c, bool bOk)
        {
            throw new NotImplementedException();
        }

        public bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            throw new NotImplementedException();
        }

        public bool LastDigit(int a, int b, int c)
        {
            throw new NotImplementedException();
        }

        public int RollDice(int die1, int die2, bool noDoubles)
        {
            throw new NotImplementedException();
        }

    }
}
