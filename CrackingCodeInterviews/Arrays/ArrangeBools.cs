using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeInterviews.Arrays
{
    public static class ArrangeBools
    {

        public static int[] sortNegPos(int[] input)
        {
            if (input == null || input.Length < 2)
            {
                return input;
            }

            int left, right, temp = 0;
            left = 0;
            right = input.Length - 1;
            while (left < right)
            {

                if (input[left] == 1)
                {
                    while (right > left && input[right] != 0)
                    {
                        right--;
                    }
                    if (right > left)
                    {
                        temp = input[left];
                        input[left] = input[right];
                        input[right] = temp;
                        right--;
                    }

                }
                left++;
            }
            return input;


        }
    }
}
