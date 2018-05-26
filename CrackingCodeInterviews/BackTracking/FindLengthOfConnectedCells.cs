using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeInterviews.BackTracking
{
    public static class FindLengthOfConnectedCells
    {

        public static int FindMaxConnectedCells(int[,] mat, int rows, int cols)
        {
            int maxCount = 0;
            bool[,] V = new bool[rows,cols];
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    if (mat[i,j] == 1)
                    {
                        FindMaxCountForRegion(mat, rows, cols, V, i, j, 0,ref maxCount);
                    }
                }
            }
            return maxCount;
        }

        private static void FindMaxCountForRegion(int[,] mat, int rows, int cols, bool[,] V, int i, int j,int size, ref int maxCount)
        {
            if (i >= rows || j >= cols)
                return;

            V[i,j] = true;
            size++;
            if (size > maxCount)
                maxCount = size;
           
            int[,] directions = new int[,] {
                 {0,-1}, {-1,-1}, {-1,0}, {-1,1}, {0,1}, {1,1}, {1,0}, {1,-1}
                };
            for (int k = 0; k < directions.GetLength(0); k++)
            {
                int newI = directions[k,0]+i;
                int newJ = directions[k,1]+j;
                int value = getValue(newI, newJ, rows, cols, mat);
                if(value==1 && V[newI,newJ]==false)
                {
                    FindMaxCountForRegion(mat, rows, cols, V, newI, newJ,size, ref maxCount);
                }
            }

            V[i,j] = false;
        }

        private static int getValue(int newI, int newJ, int rows, int cols, int[,] mat)
        {
           if(newI>=rows|| newI<0 || newJ>=cols || newJ<0)
            {
                return 0;
            }
            return mat[newI,newJ];
        }
    }
}
