using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaDotNet.Advanced.DP
{
    class Ndigitnumbers
    {
        public int solve(int A, int B)
        {
            int mod = 1000000007;
            long[,] dp = new long[B + 1, A + 1];
            //B=sum
            //A=no of digits`
            //dp[i,j]== no of ways to have sum i using j digits

            for (int i = 0; i <= B; i++)
            {
                if (i <= 9) dp[i, 1] = 1;
            }
            for (int i = 1; i <= B; i++)
            {
                for (int j = 1; j <= A; j++)
                {
                    for (int k = 1; k <= i; k++)
                    {
                        dp[i, j] = (dp[i, j] + dp[k, j - 1]) % mod;
                    }

                }
            }
            return (int)(dp[B, A] % mod);
        }
    }
}
