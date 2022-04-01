using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_solve
{
    // not yet done
    class RomanToInteger
    {
        public static void Main(string[] args)
        {
            Console.Write("s= ");
            string inpString = Console.ReadLine();
            Console.WriteLine(RomanToInt(inpString));
        }

        public static int RomanToInt(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                result += ConvertRomanToInt(s[i]);
            }
          

            return result;
        }

        public static int ConvertRomanToInt(char s)
        {
            int Value = 0;
            if (s.Equals('I'))
            {
                Value = 1;
            }
            else if (s.Equals('V'))
            {
                Value = 5;
            }
            else if (s.Equals('X'))
            {
                Value = 10;
            }
            else if (s.Equals('L'))
            {
                Value = 50;
            }
            else if (s.Equals('C'))
            {
                Value = 100;
            }

            else if (s.Equals('D'))
            {
                Value = 500;
            }
            else if (s.Equals('M'))
            {
                Value = 1000;
            }
            else
            {
                Value = 0;
            }

            return Value;
        }
    }
}
