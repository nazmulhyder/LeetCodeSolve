using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_solve
{
    class LongestCommonPrefix
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] inpStrings = new string[n];
            for (int i = 0; i < n; i++)
            {
                inpStrings[i] = Console.ReadLine();
            }

            Console.WriteLine(LCP(inpStrings));

        }

        public static string LCP(string[] arr)
        {
            int counter = 0;
            string lcp = "";

            
         
        }
    }
}
