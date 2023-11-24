using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_solve
{
    internal class Es509_Fibonacci
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Fib(0));
        }


        public static int Fib(int n)
        {
            int[] nArr = new int[n+1];
            nArr[0] = 0; 
            if(n>0)
            nArr[1] = 1;
            int i = 2;
            while (n >= i)
            {
                nArr[i] = nArr[i - 1] + nArr[i - 2];
                i++;
            }

            return nArr[n];
        }
    }


}
