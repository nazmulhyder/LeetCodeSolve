using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_solve
{
    public class Es121_MaxProfit
    {
        public static void Main(string[] args)
        {
            int[] prices = new int[] { 1, 4, 2 };
            Console.WriteLine(MaxProfit(prices)); 
        }

        public static int MaxProfit(int[] prices)
        {
           int buyIndex = 0; int minValue = prices[0]; int[] minInd = new int[1]; int[] maxInd = new int[1];
           int maxVal = -999999; int sellIndex = 0;

            for (int i = 0; i< prices.Length; i++)
            {
                //minValue = minValue>= prices[i] ? prices[i] :  minValue; 
                buyIndex = (i== prices.Length-1? i: i+1);

                if (minValue > prices[buyIndex])
                {
                    minValue = prices[buyIndex];
                    minInd[0] = minValue;
                }
                else
                {
                    minInd[0] = minValue;
                }
            }

            for (int i =  Array.FindIndex(prices, c => c.Equals(minInd[0])) +1; i < prices.Length; i++)
            {
                maxVal = maxVal < prices[i]? prices[i] : maxVal ; 
                sellIndex = (i == prices.Length - 1 ? i : i + 1);

                if (maxVal < prices[sellIndex])
                {
                    maxVal = prices[sellIndex];
                    maxInd[0] = prices[sellIndex];
                }
                else
                {
                    maxInd[0] = maxVal;
                }
            }

            return  maxInd[0] - minInd[0] <= 0? 0 : maxInd[0] - minInd[0];
        }
    }
}
