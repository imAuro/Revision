using System;
using System.Collections.Generic;

namespace dsaDotNet.Advanced.Arrays
{
    public class MergeIntervals
    {
        public List<List<int>> solve(List<List<int>> A, int B, int C)
        {
            int n = A.Count;
            List<List<int>> ans = new List<List<int>>();
            int min = B;
            int max = C;
            int f = 0;
            if (A.Count == 0)
            {
                A.Add(new List<int> { B, C });
                return A;
            }
            if (C < A[0][0])
            {
                A.Insert(0, new List<int> { B, C });
                return A;
            }
            else if (B > A[n - 1][1])
            {
                A.Add(new List<int> { B, C });
                return A;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (isOverLap(A[i][0], A[i][1], min, max))
                    {
                        min = Math.Min(A[i][0], min);
                        max = Math.Max(A[i][1], max);
                    }
                    else
                    {
                        if (max < A[i][0] && f == 0)
                        {
                            f = 1;
                            ans.Add(new List<int> { min, max });
                        }

                        ans.Add(A[i]);
                    }
                }
                if (f == 0)
                {
                    ans.Add(new List<int> { min, max });
                }
            }
            return ans;
        }
        public bool isOverLap(int aS, int aE, int B, int C)
        {
            if (C < aS || B > aE)
            {
                return false;
            }
            return true;
        }
    }
}

