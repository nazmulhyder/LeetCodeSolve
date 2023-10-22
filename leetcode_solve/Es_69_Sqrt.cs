using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_solve
{
    public class Es_69_Sqrt
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MySqrt(2025));
        }

        public static int MySqrt(int x)
        {

            long i = 1;
            long sqr = i*i;

            while (x >= sqr)
            {
                i++;
                sqr = i*i;
            }


            return Convert.ToInt32(i-1);
        }

        //public static List<int> FindSecisif

    }
}
