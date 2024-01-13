using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode_solve
{
    public class Es205_IsomorphicStrings
    {   
        public static void Main(string[] args)
        {
            Console.WriteLine(IsIsomorphic("badc", "baba"));
        }

        public static bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();

            if (s.Count() != t.Count())
            {
                return false;
            }

            else
            {
                char[] a = s.ToCharArray();
                char[] b = t.ToCharArray();
                bool IsIsoporphic = true;

                for(int i=0; i< a.Length; i++)
                {
                    for (int j = i; j <= i ; j++)
                    {
                        if (dict.ContainsKey(a[i]))
                        {
                            char check1 = b[j]; char check2 = 'A';
                            dict.TryGetValue(a[i], out check2);

                            if (check1 != check2)
                            {
                                IsIsoporphic = false;
                                break;
                            }

                            if (!IsIsoporphic)
                                break;
                        }
                        else
                            dict.Add(a[i], b[j]);
                    }
                }

                dict = new Dictionary<char, char>();
                for (int i = 0; i < b.Length; i++)
                {
                    for (int j = i; j <= i; j++)
                    {
                        if (dict.ContainsKey(b[i]))
                        {
                            char check1 = a[j]; char check2 = 'A';
                            dict.TryGetValue(b[i], out check2);

                            if (check1 != check2)
                            {
                                IsIsoporphic = false;
                                break;
                            }

                            if (!IsIsoporphic)
                                break;
                        }
                        else
                            dict.Add(b[i], a[j]);
                    }
                }

                return IsIsoporphic;
            }
        }
    }
}
