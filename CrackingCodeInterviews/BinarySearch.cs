using CrackingCodeInterviews.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeInterviews
{
    public static class BinarySearch
    {
       public static bool Search(int num, int[] arr)
        {
            if (arr.Length == 0)
                return false;
            arr = new MergeSortClass().Sort(arr);
            return BinSearch(arr, num, 0,  arr.Length - 1);
        }

        private static bool BinSearch(int[] arr, int num, int start, int end)
        {
            if (start > end)
                return false;
            int mid = (start + end) / 2;
            if (arr[mid] == num)
                return true;
            else if (arr[mid] > num)
                return BinSearch(arr, num, start, mid - 1);
            else
                return BinSearch(arr, num, mid + 1, end);
        }
    }
}
