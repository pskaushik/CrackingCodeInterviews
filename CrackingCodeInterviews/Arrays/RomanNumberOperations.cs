using System;
using System.Collections.Generic;
using System.Text;

public static class RomanNumberOperation
{

    public static readonly Dictionary<int, string> NumberRomanDictionary;
    public static readonly Dictionary<string, int> RomanToNumberDict;
    static RomanNumberOperation()
    {

        NumberRomanDictionary = new Dictionary<int, string>()
        {

            {1000,"M" },
            {900,"CM" },
            {500,"D" },
            {400,"CD" },
            {100,"C" },
            {90,"XC" },
            {50,"L" },
            {40,"XL" },
            {10,"X" },
            {9,"IX" },
            {5,"V" },
            {4,"IV" },
            {1,"I" }
        };

        RomanToNumberDict = new Dictionary<string, int>()
         {
             {"M", 1000 },
             {"D", 500 },
             {"C",100 },
             {"L",50 },
             {"X",10 },
             {"V",5 },
             {"I",1 }

         };


    }

    private static string GetRomanCode(int n, int val)
    {
        StringBuilder sb = new StringBuilder();
        while (n > 0)
        {
            sb.Append(NumberRomanDictionary[val]);
            n--;
        }
        return sb.ToString();
    }
    public static string IntToRoman(int num)
    {

        if (num < 1)
            return string.Empty;

        StringBuilder sb = new StringBuilder();
        while (num != 0)
        {
            if (num >= 1000)
            {
                sb.Append(GetRomanCode(num / 1000, 1000));
                num = num % 1000;
            }
            else if (num >= 900)
            {
                sb.Append(GetRomanCode(1, 900));
                num = num % 100;
            }
            else if (num >= 500)
            {
                sb.Append(GetRomanCode(num / 500, 500));
                num = num % 500;
            }
            else if (num >= 400)
            {
                sb.Append(GetRomanCode(1, 400));
                num = num % 400;
            }
            else if (num >= 100)
            {
                sb.Append(GetRomanCode(num / 100, 100));
                num = num % 100;
            }
            else if (num >= 90)
            {
                sb.Append(GetRomanCode(1, 90));
                num = num % 10;
            }
            else if (num >= 50)
            {
                sb.Append(GetRomanCode(num / 50, 50));
                num = num % 50;
            }
            else if (num >= 40)
            {
                sb.Append(GetRomanCode(1, 40));
                num = num % 10;
            }
            else if (num >= 10)
            {
                sb.Append(GetRomanCode(num / 10, 10));
                num = num % 10;
            }
            else if (num >= 9)
            {
                sb.Append(GetRomanCode(1, 9));
                num = 0;
            }
            else if (num >= 5)
            {
                sb.Append(GetRomanCode(1, 5));
                num = num % 5;
            }
            else if (num >= 4)
            {
                sb.Append(GetRomanCode(1, 4));
                num = 0;
            }
            else if (num >= 1)
            {
                sb.Append(GetRomanCode(num, 1));
                num = 0;
            }

        }
        return sb.ToString();

    }

    public static int RomanToInt(string roman)
    {
        if (roman == null || roman.Length < 1)
            return 0;

        int res = 0;
        for(int i = 0; i < roman.Length; i++)
        {
            int value = RomanToNumberDict[roman[i].ToString()];
            if(i+1 < roman.Length)
            {
                int v2 = RomanToNumberDict[roman[i+1].ToString()];
                if (value >= v2)
                {
                    res += value;
                }
                else
                {
                    res = res + v2 - value;
                    i++;
                }

            }
            else
            {
                res += value;
            }

           
        }

        return res;
    }

}