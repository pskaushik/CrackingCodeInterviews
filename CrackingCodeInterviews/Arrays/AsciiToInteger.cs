using System;

namespace CrackingCodeInterviews.Arrays
{
    class AsciiToInteger
    {
        public int MyAtoi(string str)
        {

            if (string.IsNullOrEmpty(str))
                return 0;

            // return value type double so that it can accomodate overflow buffer
            double result = 0;

            bool isNegative = false;

            int startIndex = 0;
            str = str.Trim();
            if (str.Length == 0)
                return 0;
            if (str[0] == '-' || str[0] == '+')
                startIndex++;

            if (str[0] == '-')
            {
                isNegative = true;
            }

            for (int i = startIndex; i < str.Length; i++)
            {
                int temp = (int)(str[i] - '0');
                //break if non numerical character found
                if (temp < 0 || temp > 9)
                    break;
                result = result * 10 + temp;
            }

            if (isNegative)
                result = -result;

            //Handle Overflow interger case
            if (result > Int32.MaxValue)
                return Int32.MaxValue;

            if (result < Int32.MinValue)
                return Int32.MinValue;

            return (int)result;

        }
    }
}
