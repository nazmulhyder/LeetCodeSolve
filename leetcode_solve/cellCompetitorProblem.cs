using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_solve
{
    class cellCompetitorProblem
    {
        public static void Main(string[] args)
        {
            int[] myNum = { 1, 1, 0, 0, 0, 1, 1, 0 };
            int days = 8;
            int[] resultArr;
            resultArr = cellCompetitor(myNum, days);
            foreach (var item in resultArr)
            {
                Console.Write(' ');
                Console.Write(item);
            }
        }

        public static int[] cellCompetitor(int[] arr,int days)
        {
            while (days > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == 0)
                    {
                        if (matchedAdj(arr[i], arr[i + 1]))
                        {
                            arr[i] = 1;
                        }
                        else
                        {
                            arr[i] = 0;
                        }
                    }

                    else if (i == arr.Length - 1)
                    {
                        if (matchedAdj(arr[i], arr[i - 1]))
                        {
                            arr[i] = 1;
                        }
                        else
                        {
                            arr[i] = 0;
                        }
                    }

                    else 
                    {
                        if (matchedAdj(arr[i - 1], arr[i + 1]))
                        {
                            arr[i] = 1;
                        }
                        else
                        {
                            arr[i] = 0;
                        }
                    }
                }

                days--;

            }

            return arr;
        }

        public static bool matchedAdj(int a,int b)
        {
            if (a == b)
                return true;
            else 
                return false;
        }
    }
}
