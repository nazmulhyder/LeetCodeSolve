using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_solve
{
    public class Es_PalindromeNumber
    {
        public static void Main(string[] args)
        {
            bool isPalindrome = false;
            string revString;
            Console.WriteLine("Enter N");
            int n = Convert.ToInt32(Console.ReadLine());

            Char[] array = n.ToString().ToCharArray();
            Array.Reverse(array);

            revString = new string(array);

            isPalindrome = (n.ToString() == revString)? true : false;
           

            Console.WriteLine(isPalindrome);



        }
    }
}
