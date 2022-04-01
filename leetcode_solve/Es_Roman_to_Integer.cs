using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_solve
{
    public class Es_Roman_to_Integer
    {
        public static void Main(string[] args)
        {
            Es_Roman_to_Integer ss = new Es_Roman_to_Integer();
            Console.WriteLine("Enter Input");
            string n = Console.ReadLine();
            Console.WriteLine("Result " + ss.RomanToInt(n));

        }
        public int RomanToInt(string s)
        {
            int result = 0;
            Dictionary<char, int> romanDictionary = new Dictionary<char, int>()
            {
                {'I',1 },
                 {'V',5 },
                  {'X',10 },
                   {'L',50 },
                    {'C',100 },
                     {'D',500 },
                      {'M',1000 },
            };

            for (int i = s.Length-1; i>=0 ; i--)
            {
                if(i == s.Length-1)
                {
                    result = romanDictionary[s[i]];
                }
                else
                {

                    var currentValue = romanDictionary[s[i]];
                    var afterCurrent = romanDictionary[s[i+1]];
                  
                    if (currentValue > afterCurrent)
                    {
                        result += currentValue;
                    }
                    else if (currentValue < afterCurrent)
                    {
                       result -= currentValue;
                    }
                    else
                    {
                        result += romanDictionary[s[i]];
                    }
                }
            }

           
           
            return result;
        }


    }
}
