using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_solve
{
    class Palindrome
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(checkPalindrome(number));
        }

        public static bool checkPalindrome(int x)
        {
            string tmpNo1 = x.ToString();
            string tmpNo2 = "";

            for (int i = tmpNo1.Length-1; i >= 0; i--)
            {
                tmpNo2 += tmpNo1[i];
            }

            return tmpNo1 == tmpNo2 ? true : false;
        }
    }
}
