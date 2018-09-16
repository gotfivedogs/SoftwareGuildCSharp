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
            throw new NotImplementedException();
        }

        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            throw new NotImplementedException();
        }

        public int SkipSum(int a, int b)
        {
            throw new NotImplementedException();
        }

        public string AlarmClock(int day, bool vacation)
        {
            throw new NotImplementedException();
        }

        public bool LoveSix(int a, int b)
        {
            throw new NotImplementedException();
        }

        public bool InRange(int n, bool outsideMode)
        {
            throw new NotImplementedException();
        }

        public bool SpecialEleven(int n)
        {
            throw new NotImplementedException();
        }

        public bool Mod20(int n)
        {
            throw new NotImplementedException();
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
