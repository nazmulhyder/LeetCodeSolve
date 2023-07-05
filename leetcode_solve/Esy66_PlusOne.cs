using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Channels;

namespace leetcode_solve
{
    public class Esy66_PlusOne
    {
        public static void Main(String[] args)
        {
            int[] arr = new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 };
            var result  = PlusOne(arr);
            Console.Write("[");
            int counter = 0;
            foreach (var item in result)
            {
                
                Console.Write(item+(counter == result.Length-1? "":","));
                counter++;
            }
            Console.Write("]");
        }

        public static int[] PlusOne(int[] digits)
        {
            var joinString = BigInteger.Parse(String.Join("", digits)) + 1;
            int[] resultArr = new int[joinString.ToString().Length];

            for (int i=0; i< joinString.ToString().Length; i++)
            {
                //var test = int.Parse(tempStr.Substring(i, 1));
                resultArr[i] =  int.Parse(joinString.ToString().Substring(i, 1));
            }

            return resultArr;
        }
    }
}
