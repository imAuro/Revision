using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaDotNet.Advanced.Graphs.LeetCode
{
     class CheapestFlightWithKStops
    {
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
        {

            int max = 4950000;
            int[] ans = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i != src) ans[i] = max;
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    ans[flights[i][ 1]] = Math.Min(ans[flights[i][1]], ans[flights[i][0]] + flights[i][2]);

                }
            }
            return (ans[dst]==max)?-1: ans[dst];
        }
    }
}
