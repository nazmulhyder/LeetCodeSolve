using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode_solve
{
    public class Es136_SingleNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(SingleNumber(new int[] {1,1,2}));
        }

        public static int SingleNumber(int[] number)
        {
           List<int> list = new List<int>();

            foreach (int i in number)
            {
                 if (!list.Contains(i))
                    list.Add(i);
                 else
                    list.Remove(i);
            }

            return list.ElementAt(0);

        }
    }
}
