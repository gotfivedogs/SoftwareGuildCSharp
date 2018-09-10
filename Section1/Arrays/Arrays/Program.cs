using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            for (int i = 0; i < 255; i++)
            {
                char symbol = (char) i;
                Console.WriteLine("{0}  {1}", i, symbol);

            }
            Console.Read();
        }
    }
}