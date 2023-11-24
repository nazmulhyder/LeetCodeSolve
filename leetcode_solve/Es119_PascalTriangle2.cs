﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode_solve
{
    public class Es119_PascalTriangle2
    {

        public static void Main(string[] args)
        {
            var result = PascalTriangle(3);
  
            foreach (var item2 in result)
            {
                Console.Write(item2);
            }
            Console.WriteLine();
            
        }

        public static IList<int> PascalTriangle(int rows)
        {

            IList<int> values = new List<int>(); var defaultVal = 1;
            IList<IList<int>> finalList = new List<IList<int>>();

            for (int i = 0; i <= rows; i++)
            {
                int pointer = 0;
                values = new List<int>();
                while (pointer <= i)
                {
                    if (i >= 2 && (pointer > 0 && pointer != i))
                    {
                        var val2 = finalList[i - 1];
                        var val1 = val2.ElementAt(pointer - 1) + val2.ElementAt(pointer);
                        values.Add(val1);
                    }
                    else
                    {
                        values.Add(defaultVal);
                    }

                    pointer++;
                }

                finalList.Add(values);
            }

            return finalList[rows];
        }
    }
}
