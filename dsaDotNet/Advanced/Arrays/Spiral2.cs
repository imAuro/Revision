using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaDotNet.Advanced.Arrays
{
     
    class Spiral2
    {
        public List<List<int>> generateMatrix(int A)
        {
            int c = 1;
            List<List<int>> result = new List<List<int>>();
            fillList(result);
            int top = 0, bottom = A, left = 0, right = A;
            while (top < bottom || left < right)
            {
                for (int i = left; i < right; i++)
                {
                    result[i][ top] = c;
                    c++;
                }
                top++;
                for (int i = top; i < bottom; i++)
                {
                    result[i][right] = c;
                    c++;
                }
                right--;
                for (int i = right - 2; i >= left; i--)
                {
                    result[bottom][i] = c;
                    c++;
                }
                bottom--;
                for (int i = bottom - 2; i >= top; i--)
                {
                    result[i][left] = c;
                    c++;
                }
                left++;
            }

            return result;
        }
        public void fillList(List<List<int>> A)
        {
            for (int i = 0; i < A.Count; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < A[0].Count; j++)
                {
                    row.Add(0);

                }
                A.Add(row);
            }
        }
    }


}
