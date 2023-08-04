using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

namespace leetcode_solve
{
    public class Es67_AddBinary
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(CalculateBinary("1","111"));
        }

        
        public static string CalculateBinary(string a, string b)
        {
            var resString = string.Empty;
            char[] carry = new[] { '0' };
            List<char> result = new List<char>();

            var list1 = new List<char>(); var list2 = new List<char>();
            int ind = 0;

            ind = a.Length;
            while (ind < b?.Length)
            {
                list1.Add('0');
                ind++;
            }

            ind = 0;
            while (ind < a?.Length)
            {
                list1.Add(a.ElementAt(ind));
                ind++;
            }


            ind = b.Length;
            while (ind < a?.Length)
            {
                list2.Add('0');
                ind++;
            }

            ind = 0;
            while (ind < b?.Length)
            {
                list2.Add(b.ElementAt(ind));
                ind++;
            }

            for (int i = list1.Count-1; i >= 0; i--)
            {
                //var test1 = list1.ElementAt(i);
                //var test2 = list2.ElementAt(i);
                //var test3 = carry[0];


                if (list1.ElementAt(i) == '1' && list2.ElementAt(i) == '1' && carry[0] == '1')
                {
                    result.Add('1');  carry[0] = '1';
                }

                else if (list1.ElementAt(i) == '1' && list2.ElementAt(i) == '1' && carry[0] == '0')
                {
                    result.Add('0'); carry[0] = '1';
                }

                else if (list1.ElementAt(i) == '1' && list2.ElementAt(i) == '0' && carry[0] == '0')
                {
                    result.Add('1'); carry[0] = '0';
                }

                else if (list1.ElementAt(i) == '1' && list2.ElementAt(i) == '0' && carry[0] == '1')
                {
                    result.Add('0'); carry[0] = '1';
                }

                else if (list1.ElementAt(i) == '0' && list2.ElementAt(i) == '1' && carry[0] == '1')
                {
                    result.Add('0'); carry[0] = '1';
                }
                else if (list1.ElementAt(i) == '0' && list2.ElementAt(i) == '1' && carry[0] == '0')
                {
                    result.Add('1'); carry[0] = '0';
                }
                
                else if (list1.ElementAt(i) == '0' && list2.ElementAt(i) == '0' && carry[0] == '0')
                {
                    result.Add('0'); carry[0] = '0';
                }
                else if (list1.ElementAt(i) == '0' && list2.ElementAt(i) == '0' && carry[0] == '1')
                {
                    result.Add('1'); carry[0] = '0';
                }

                
            }

            if(carry[0] == '1') { result.Add(carry[0]); }
           
            result.Reverse();
           
            foreach (var item in result)
            {
                resString += item;
            }

            return resString;
        }

        
    }
}
