using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_solve
{
    internal class Es_28_Implement_strStr
    {
        public static void Main(string[] args)
        {
            string haystack = "a";
            string needle = "a";
            Console.WriteLine("Result: {0}", StrStr(haystack,needle));
        }
        public static int StrStr(string haystack, string needle)
        {

            var test = haystack.IndexOf(needle);

            int index = 0;
            int storeIndex = 0;
            bool flag = false;
            var tempNeedle = needle;

            if (haystack.Length == 1 && needle.Length == 1 && haystack[0] == needle[0]) return 0;
            if (haystack.Length == 1 && needle.Length == 1 && haystack[0] != needle[0]) return -1;
            if (needle.Length == 1 && haystack[0] == needle[0]) return 0;
            if (haystack.Equals(needle)) return 0;
            if(needle.Length == 1 && !haystack.Contains(needle)) return -1;
            if (needle.Length > haystack.Length) return -1;

            for (int i = 0; i < haystack.Length; i++)
            {        
                if (String.IsNullOrWhiteSpace(needle) || String.IsNullOrWhiteSpace(needle)) return -1;

                //var tracIndex = index;
                //var tracNeedleLen = needle.Length - 1;
                //var tracHaystackChar = haystack[i];
                //var tracNeedleChar = needle[index];
                //var tracTempNeedle = tempNeedle;

                if (!String.IsNullOrEmpty(tempNeedle) && haystack[i] == needle[index] && index <= needle.Length-1)
                {
                    if(index == 0)
                    storeIndex = i;
                    tempNeedle = tempNeedle.Substring(0, (needle.Length - 1) - index);
                    index = index < needle.Length-1 ? index+1 : index;
                }
                else
                {
                    index = 0;
                }

                if (index == (needle.Length - 1))
                {
                    flag = true;
                }
            } 
            return index >= 0 && flag ? storeIndex : -1;
        }
    }
}
