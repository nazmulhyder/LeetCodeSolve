using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace leetcode_solve
{
    public class Es125_ValidPalindrome
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter string.");
            string str = Console.ReadLine();
            Console.WriteLine(IsValidPalindrome(str));
        }

        public static bool IsValidPalindrome(string palindrome)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            palindrome = rgx.Replace(palindrome, "");
            palindrome= palindrome.Replace(" ", ""); palindrome = palindrome.Replace("-", "");
            var res =  palindrome.ToLower().Equals(StringReverse(palindrome).ToLower()) ? true : false;
            return res;
        }

        public static string StringReverse(string str)

        {
            char[] convCharArray = str.ToCharArray();
            Array.Reverse(convCharArray);
            return new string(convCharArray);
        }
    }
}
