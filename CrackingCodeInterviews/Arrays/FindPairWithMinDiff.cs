using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeInterviews.Arrays
{
   public static class FindPairWithMinDiff
    {
       public static int FindingMinDifference (int[] input)
        {
            Array.Sort(input);
            int min = Int32.MaxValue;
            for(int i = 0,j=1; j < input.Length; i++,j++)
            {
              int curDiff = input[j] - input[i];
              if (curDiff<min)
                {
                    min = curDiff;
                }
            }
            return min;
        }

    }
}
