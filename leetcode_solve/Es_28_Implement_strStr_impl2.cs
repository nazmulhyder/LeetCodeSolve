using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_solve
{
    internal class Es_28_Implement_strStr_impl2
    {
        public static void Main(string[] args)
        {
            string haystack = "mississippi";
            string needle = "issip";
            Console.WriteLine("Result: {0}", StrStr(haystack, needle));
        }
        public static int StrStr(string haystack, string needle)
        {
            if (String.IsNullOrWhiteSpace(needle) || String.IsNullOrWhiteSpace(needle)) return -1;
            return haystack.IndexOf(needle);
        }
    }
}
