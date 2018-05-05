using System;

public static class MedianOfTwoSortedArrays
{
    public static  double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        double output = 0D;
        if (nums1.Length == 0 && nums2.Length == 0)
            return 0;
        int[] mergedArray = MergeArrays(nums1, nums2);

        int mid = mergedArray.Length / 2;
        if (mergedArray.Length % 2 == 0)
        {
            output = (mergedArray[mid - 1] + mergedArray[mid]) / 2D;
           
        }
        else
            output = (mergedArray[mid]);
        return output;
    }

    public static int[] MergeArrays(int[] arr1, int[] arr2)
    {
        if (arr1.Length == 0)
            return arr2;
        if (arr2.Length == 0)
            return arr1;
        int m = arr1.Length;
        int n = arr2.Length;
        int i = 0, j = 0;
        int[] mergedArray = new int[m + n];
        int index = 0;
        while (i < m && j < n)
        {

            if (arr1[i] < arr2[j])
                mergedArray[index++] = arr1[i++];
            else
                mergedArray[index++] = arr2[j++];

        }

        while (i < m)
        {
            mergedArray[index++] = arr1[i++];

        }
        while (j < n)
        {
            mergedArray[index++] = arr2[j++];

        }
        return mergedArray;
    }

}
