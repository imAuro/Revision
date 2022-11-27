using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaDotNet.Advanced.Graphs
{
     class FloydWarshall
    {
        class Solution
        {
            public List<List<int>> solve(List<List<int>> A)
            {
                int n = A.Count();
                long[,] ans = new long[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (A[i][j] == -1) ans[i,j] = Int32.MaxValue;
                        if (i == j) ans[i,j] = 0;
                        else ans[i,j] = A[i][j];
                    }
                }

                for (int k = 0; k < n; k++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (i == j) continue;

                            else
                            {
                                ans[i,j] = Math.Min(ans[i,k] + ans[k,j], ans[i,j]);
                            }
                        }
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (ans[i, j] == Int32.MaxValue) A[i][j] = -1;
                        else A[i][j] =(int) ans[i, j];
                    }
                }

                return A;   
            }
        }

    }
}
