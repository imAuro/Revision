using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaDotNet.Advanced.DP
{
    class MinimumSquares
    {
        int[] dp = null;
        int max = 100001;
        public int countMinSquares(int A)
        {
            dp = new int[A + 1];
            for (int i = 0; i <= A; i++)
            {
                dp[i] = (i <= 3) ? i : max;
            }
            return calSquares(A);

        }
        public int calSquares(int A)
        {
            if (dp[A] != max) return dp[A];

            for (int i = 1; i * i <= A; i++)
            {
                dp[A] = Math.Min(dp[A], 1 + calSquares(A - i * i));
            }
            return dp[A];

        }
    }

}
