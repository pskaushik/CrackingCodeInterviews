using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeInterviews.Sorting
{
    public  class MergeSortClass
    {
        // Sort an integer Array

        public  int[] Sort(int[] input)
        {
            if (input.Length < 2)
                return input;
            MergeSort(input);
            return input;
        }

        private  void MergeSort(int[] input)
        {
            int length = input.Length;
            if (length < 2)
                return;
            int mid = length / 2;
            int[] left = new int[mid];
            int[] right = new int[length - mid];
            int i = 0;
            for (i = 0; i < mid; i++)
                left[i] = input[i];
            for (int j = 0; i < length;i++, j++)
                right[j] = input[i];
            MergeSort(left);
            MergeSort(right);
            Merge(input, left, right);
        }

        private static void Merge(int[] arr, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;
            int nL = left.Length;
            int nR = right.Length;
            while (i < nL && j < nR)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < nL)
            {
                arr[k] = left[i];
                i++; k++;
            }
            while (j < nR)
            {
                arr[k] = right[j];
                j++; k++;
            }

        }

    }
}
