using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaDotNet.Advanced.DP
{
    class CalculateMinimumHealth
    {
        public int calculateMinimumHP(List<List<int>> A)
        {
            int n = A.Count();
            int m = A[0].Count();

            int[,] dp = new int[n, m];
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = m - 1; j >= 0; j--)
                {
                    if (i == n - 1 && j == m - 1) dp[i, j] = Math.Max(1 - A[i][j], 1);
                    else if (i == n - 1) dp[i, j] = Math.Max(dp[i, j + 1] - A[i][j], 1);
                    else if (j == m - 1) dp[i, j] = Math.Max(dp[i + 1, j] - A[i][j], 1);
                    else dp[i, j] = Math.Max(1, Math.Min(dp[i + 1, j] - A[i][j], dp[i, j + 1] - A[i][j]));


                }
            }
            return dp[0, 0];

        }
    }
}
