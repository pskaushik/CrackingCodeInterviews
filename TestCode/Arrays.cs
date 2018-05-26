using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackingCodeInterviews.Arrays;
using CrackingCodeInterviews.Sorting;
using CrackingCodeInterviews;

namespace TestCode
{
    [TestClass]
    public class Arrays
    {
        [TestMethod]
        public void Test_MedianOfTwoSortedArrays()
       { 
            int[] num1 = new int[2] {1,2 };
            int[] num2 = new int[2] {3,4 };
            double output=MedianOfTwoSortedArrays.FindMedianSortedArrays(num1, num2);
            Assert.AreEqual(2.5, output);
        }
       [TestMethod]
        public void Test_IntToRoman()

        {

            string op= RomanNumberOperation.IntToRoman(1994);
            Assert.AreEqual(op, "XX");
        }

        [TestMethod]
        public void Test_RomanToInt()

        {

            int op = RomanNumberOperation.RomanToInt("IV");
            Assert.AreEqual(op, 3);
        }

        [TestMethod]
        public void Test_ReverseInt()

        {
            int a = 1534236469;
           int op= ReverseAnInteger.Reverse(1534236469);
            Assert.AreEqual(op, -321);
        }
        [TestMethod]
        public void Test_ContainerWithMostWater()

        {
            int[] input = { 1, 2, 4, 3 };
            int result = ContainerWithMostWater.MaxArea(input);
            Assert.AreEqual(result, 4);

        }
        [TestMethod]
        public void Test_RainWaterTrap()

        {
            int[] input = { 0,1,0,2,1,0,1,3,2,1,2,1 };
            int result = TrapWater.Trap(input);
            Assert.AreEqual(result, 4);

        }
        [TestMethod]
        public void Test_NegativePositiveArrange()

        {
            int[] input = { 4, -3, 2, -5, 5, -1, 3 };
            int[] result = ArrangeNegativePositive.sortNegPos(input);
            

        }

        [TestMethod]
        public void Test_ArrangeBools()

        {
            int[] input = { 0, 1, 0, 1, 0, 0, 1, 1, 1, 0};
            int[] result = ArrangeBools.sortNegPos(input);


        }

        [TestMethod]
        public void Test_FindMinDiffPair()

        {
            int[] input = { 1, 19, -4, 31, 38, 25, 100 };
            int result = FindPairWithMinDiff.FindingMinDifference(input);


        }
        [TestMethod]
        public void Test_MergeSort()

        {
            int[] input = { 1, 9,5,2,11,15};
            int[] result = new MergeSortClass().Sort(input);


        }
        [TestMethod]
        public void Test_BinSearchPass()
        {
            int[] input = { 1, 9, 5, 2, 11, 15 };
            bool result = BinarySearch.Search(2,input);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Test_BinSearchFail()
        {
            int[] input = { 1, 9, 5, 2, 11, 15 };
            bool result = BinarySearch.Search(39, input);
            Assert.IsFalse(result);
        }

    }




}
