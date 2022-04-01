using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode_solve
{
    //compile time error
    class reverseInteger
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            Int32 inpNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Reverse(inpNumber));
        }
        public static int Reverse(int x)
        {
            string resultStr = "";
            string tmpString = x.ToString();
            for (int i = tmpString.Length-1; i >= 0; i--)
            {
                resultStr += tmpString[i];
            }

            if (resultStr.Contains('-'))
            {
                resultStr = '-'+ resultStr.Substring(0, resultStr.Length - 1);
            }

            return Convert.ToInt32(resultStr);
        }
    }
}
