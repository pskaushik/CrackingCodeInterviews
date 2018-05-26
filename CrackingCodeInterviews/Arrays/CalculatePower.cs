using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeInterviews.Arrays
{
    public static class CalculatePower
    {

        /// <summary>
        /// Do not handles negative case
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static  double MyPow(double x, int n)
        {
            double result = 1;
            while (n>0)
            {
                //Checj if power is odd number using bitwise operator
                //Explaination  - only last bit will be set of 1. so if number is odd it's last will be set as well. e.g. 5-->00000101, 3-->00000011
                if ((n & 1) == 1)
                {
                    result = result * x;
                }

                n = n >> 1; //divide by 2
                x = x * x;  //calculate square 
            }
            return result;
        }

      


    }
}
