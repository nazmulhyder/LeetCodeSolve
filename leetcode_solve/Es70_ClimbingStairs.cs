using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_solve
{
    public class Es70_ClimbingStairs
    {
        public static void Main(string[] args)
        {
         
            Console.WriteLine(ClimbStairs(3));        
          
        }

        public static int ClimbStairs(int n)
        {
            int[] nArr = new int[n+1];
            nArr[0] = 1; nArr[1] = 2;
            int i = 2;
            while(n>=i) 
            {
                nArr[i] = nArr[i-1] + nArr[i-2];
                i++;
            }
            
            return nArr[n-1];
        }
    }
}
