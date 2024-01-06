using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace leetcode_solve
{
    public class Es190_ReverseBits
    {
        public static void Main(String[] args)
        {
            string binString = "00000010100101000001111010011100";
            uint binStrToDec = Convert.ToUInt32(binString,2);
            Console.WriteLine(ReverseBits(binStrToDec));
        }

        public static uint ReverseBits(uint bits)
        {
            var str = Convert.ToString(bits, 2); string tmpBit = "";
            var count = 32-str.Count();

            while (count > 0)
            {
                tmpBit = String.Concat("0"+ tmpBit);
                count--;
            }
            str = tmpBit+Convert.ToString(bits, 2);
            var strRev = str.ToCharArray().Reverse();
            str = String.Concat(
            strRev.Where(c => strRev.Contains(c))
             );
            uint binStrToDec = Convert.ToUInt32(str, 2);

            return binStrToDec;
        }
          
        
    }
}
