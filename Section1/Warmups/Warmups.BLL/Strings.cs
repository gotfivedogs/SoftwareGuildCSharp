﻿using System;

namespace Warmups.BLL
{
    public class Strings
    {
        public string SayHi(string name)
        {
            return "Hello " + name + "!";
        }

        public string Abba(string a, string b)
        {
            return a + b + b + a;
        }

        public string MakeTags(string tag, string content)
        {
            return "<" + tag + ">" + content + "</" + tag + ">";
        }

        public string InsertWord(string container, string word)
        {
            return container.Substring(0, 2) + word + container.Substring(2, 2);
        }

        public string MultipleEndings(string str)
        {
            return str.Substring(str.Length - 2, 2) + str.Substring(str.Length - 2, 2) + str.Substring(str.Length - 2, 2);
        }

        public string FirstHalf(string str)
        {
            return str.Substring(0, str.Length / 2);
        }

        public string TrimOne(string str)
        {
            return str.Substring(1, str.Length - 2);
        }

        public string LongInMiddle(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return b + a + b;
            }
            else
            {
                return a + b + a;
            }
        }

        public string RotateLeft2(string str)
        {
            return str.Substring(2, str.Length - 2) + str.Substring(0, 2);
        }

        public string RotateRight2(string str)
        {
            return str.Substring(str.Length - 2, 2) + str.Substring(0, str.Length - 2);
        }

        public string TakeOne(string str, bool fromFront)
        {
            if (fromFront == true)
            {
                return str.Substring(0, 1);
            }
            else
            {
                return str.Substring(str.Length - 1, 1);
            }
        }

        public string MiddleTwo(string str)
        {
            return str.Substring(str.Length / 2 - 1, 2);
        }

        public bool EndsWithLy(string str)
        {
            if (str.Length >= 2 && str.Substring(str.Length - 2, 2) == "ly")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string FrontAndBack(string str, int n)
        {
            return str.Substring(0, n) + str.Substring(str.Length - n, n);
        }

        public string TakeTwoFromPosition(string str, int n)
        {
            if (n <= 2)
            {
                return str.Substring(n, 2);
            }
            else
            {
                return str.Substring(0, 2);
            }

        }

        public bool HasBad(string str)
        {
            if (str.Length >= 3)
            {
                if (str.Substring(0, 3) == "bad" || (str.Substring(1, 3)) == "bad")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public string AtFirst(string str)
        {
            if (str.Length < 1)
            {
                return "@@";
            }
            else if (str.Length < 2)
            {
                return str.Substring(0, 1) + "@";
            }
            else
            {
                return str.Substring(0, 2);
            }
        }

        public string LastChars(string a, string b)
        {
            string first = "";
            string last = "";

            if (a.Length <= 1)
            {
                first = "@";
            }
            else
            {
                first = a.Substring(0, 1);
            }
            if (b.Length < 1)
            {
                last = "@";
            }
            else
            {
                last = b.Substring(b.Length - 1);
            }
            return first + last;
        }

        public string ConCat(string a, string b)
        {
            if (a.Length == 0 || b.Length == 0)
                return a + b;
            if (a.Substring(a.Length - 1) == b.Substring(0, 1))
            {
                return a + b.Substring(1);
            }
            else
            {
                return a + b;
            }
        }

        public string SwapLast(string str)
        {
            if (str.Length < 2)
            {
                return str;
            }
            else
            {
                return str.Substring(0, str.Length - 2) + str.Substring(str.Length - 1, 1) + str.Substring(str.Length - 2, 1);
            }
        }

        public bool FrontAgain(string str)
        {
            if (str.Length < 2)
            {
                return false;
            }
            else
            {
                if (str.Substring(0, 2) == str.Substring(str.Length - 2, 2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string MinCat(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return a.Substring(a.Length - b.Length, b.Length) + b;
            }
            else
            if (a.Length < b.Length)
            {
                return a + b.Substring(b.Length - a.Length, a.Length);
            }
            else
            {
                return a + b;
            }
        }

        public string TweakFront(string str)
        {
            if (str.Length > 0)
            {
                if (str.Substring(0, 2) == "ab")
                {
                    return str;
                }
                if (str.Substring(0, 1) == "a")
                {
                    return str.Remove(1, 1);
                }
                else if (str.Substring(1, 1) == "b")
                {
                    return str.Remove(0, 1);
                }
                else
                {
                    return str.Substring(2);
                }
            }
            return str;
        }

        public string StripX(string str)
        {
            str = str.TrimStart('x');
            return str.TrimEnd('x');
        }
    }
}