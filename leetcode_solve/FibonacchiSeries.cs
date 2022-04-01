using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace leetcode_solve
{
    class FibonacchiSeries
    {
        // 0 1 1 2 3 5 8 13
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter N");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i)+" ");
            }
        }

        public static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
