using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_solve
{
    class Es_LongestCommonPrefix
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

            //foreach (string inp in inpStrings)
            Console.WriteLine("LCP is :{0}", LongestCommonPrefix(inpStrings));

        }

        public static string LongestCommonPrefix(string[] strs)
        {
            var prefix = strs[0];
            if (strs.Length == 0)
            return "";

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length -1);
                }
            }
            return prefix;
        }
            
    }
 }
