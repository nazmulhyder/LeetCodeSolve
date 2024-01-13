using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode_solve
{
    public class Es202_HappyNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(HappyNumber(19));
        }
        public static bool HappyNumber(int n)
        {         
            var tmpSum = 0.0; var IsHappyNumber = false;
            string happyNumber = n.ToString(); var counter = 0;
            List<int> numbers = new List<int>();    
            
            while (!IsHappyNumber  && !(numbers.Where(x => x == tmpSum).Count()==2))
            {
                var chars = ConvertNumberToCharArray(n); 
                counter = 0; tmpSum = 0.0;
                foreach (char c in chars)
                {
                    var ss = Math.Pow(c - 48, 2);
                    tmpSum += Math.Pow(c - 48, 2);
                    counter++;
                    if (tmpSum == 1 && counter == chars.Count())
                    {
                        IsHappyNumber = true;
                        break;
                    }
                    
                }

                numbers.Add(Convert.ToInt16(tmpSum));
                n = Convert.ToInt16(tmpSum);
            }
            
            return IsHappyNumber;
        }


        public static char[] ConvertNumberToCharArray(int n)
        {
             return n.ToString().ToCharArray();
        }

    }
}
