using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeInterviews.Arrays
{
    public static class ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {

            if (height == null || height.Length < 2)
                return 0;

            int s = 0, sum = 0, maxIndex = 0, max = 0, index = 0,  sIndex = 0;
            while (index < height.Length)
            {

                if (s == 0)
                {
                    s = height[index];
                    sIndex = index;
                    index++;
                }
                else
                {

                    if (s <= height[index])
                    {
                        sum += Math.Min(s, height[index]);
                        s = height[index];
                        sIndex = index;
                        index++;
                    }
                    else
                    {
                        while (index < height.Length && height[index] < s)
                        {
                            if (max < height[index])
                            {
                                maxIndex = index;
                                max = height[index];
                            }
                            index++;
                        }

                        if (index < height.Length)
                        {
                            sum += Math.Min(s, height[index]) * (index - sIndex);
                            s = height[index];
                        }
                        else
                        {
                            sum += max * (maxIndex - sIndex);

                        }
                    }


                }



            }
            return sum;

        }
    }
}
