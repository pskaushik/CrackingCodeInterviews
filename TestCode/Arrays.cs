using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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



    }




}
