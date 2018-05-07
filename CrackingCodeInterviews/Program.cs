using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeInterviews
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a= new int[] { 6, 1, 3, 46, 1, 3, 5, 47 };
            long k=0;
            //int pc= numberOfPairs(a, k);
            int c = LengthOfLongestSubstring("qwnfenpglqdq");

            Console.Write(c);
            Console.ReadKey();
        }

        public static int LengthOfLongestSubstring(string s)
        {

            if (s.Length == 0)
                return 0;
            if (s.Length == 1)
                return 1;
            int max = 1,  start = 0;
            Dictionary<char, int> lookup = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (lookup.ContainsKey(s[i]) && lookup[s[i]] >= start)
                {
                    start = lookup[s[i]] + 1;
                    //Start over
                }
                    lookup[s[i]] = i;
                    max = Math.Max(max, i - start+1);
                
            }
            return max;
        }
        static int numberOfPairs(int[] a, long k)
        {

            int totalArrayCount = 0;
            int pairCount = 0;
            if (a.Length == 0)
                return 0;
            totalArrayCount = a[0];
            k = a[a.Length - 1];
            HashSet<long> buffer = new HashSet<long>();
            for (int number = 1; number <= a.Length - 2; number++)
            {

                if (buffer.Contains((Math.Abs(k - a[number]))))
                {
                    pairCount++;
                }
                buffer.Add(a[number]);

            }
            return pairCount;
        }
    }
}
