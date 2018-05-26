using CrackingCodeInterviews.BackTracking;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{[TestClass]
    public class backTracking
    {
        [TestMethod]
        public void Test_FindLengthOfConnectedCells()
        {
            int[,] mat = new int[5, 5]
            {
                { 1,1,0,0,0 },
                { 0,1,1,0,0 },
                { 0,0,1,0,1 },
                { 1,0,0,0,1 },
                { 0,1,0,1,1 }
            };
            //int[,] mat = new int[2, 3]
            //{
            //    { 1,0,1},
            //    { 0,1,0}

            //};


            int max = FindLengthOfConnectedCells.FindMaxConnectedCells(mat,5,5);
            Assert.Equals(3, max);
        }
    }
}
