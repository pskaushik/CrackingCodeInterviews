using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeInterviews.Arrays
{
    public static class TrapWater
    {
        public static  int Trap(int[] height)
        {


            if (height == null || height.Length < 3)
                return 0;

            int sum = 0;

            int[] leftMax = new int[height.Length];
            int[] rightMax = new int[height.Length];


            leftMax[0] = height[0];
            for (int i = 1; i < height.Length; i++)
            {
                leftMax[i] = Math.Max(leftMax[i - 1], height[i]);
            }

            rightMax[height.Length - 1] = height[height.Length - 1];
            for (int i = height.Length - 2; i >= 0; i--)
            {
                rightMax[i] = Math.Max(rightMax[i + 1], height[i]);
            }

            for (int i = 0; i < height.Length - 1; i++)
            {

                sum += Math.Abs(Math.Min(leftMax[i], rightMax[i]) - height[i]);
            }

            return sum;

        }
    }
    
}
