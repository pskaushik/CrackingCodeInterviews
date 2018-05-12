using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeInterviews.Arrays
{
    public static class ReverseAnInteger
    {
        public  static int Reverse(int x)
        {
            int result = 0;
            while (x != 0)
            {
                int temp = (x % 10) + result * 10;
                //As  temp is nothing but previous temp value multiplied by 10 + Remainder (which will always be smaller than 10).
                //It means in normal case, temp/10, will always be equal to previous temp which is result.
                //If a overflow happens, then current temp will become a small number after over flow truncation, which will break the equation.
                if (temp / 10 != result)
                   return 0;
                result = temp;
                x = x / 10;
            }
            return result;
        }
    }
}
