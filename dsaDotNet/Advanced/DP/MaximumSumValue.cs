using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaDotNet.Advanced.DP
{
    class MaximumSumValue
    {
        public int solve(List<int> A, int B, int C, int D)
        {
            int n = A.Count();
            int[] preMax1 = new int[n];
            int[] preMax2 = new int[n];
            int[] preMax3 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int prev = (i - 1 < 0) ? Int32.MinValue : preMax1[i - 1];
                preMax1[i] = Math.Max(prev, B * A[i]);
                //Console.Write(preMax1[i]+" ");
            }
            //Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                int prev = (i - 1 < 0) ? Int32.MinValue : preMax2[i - 1];
                preMax2[i] = Math.Max(preMax1[i] + C * A[i], prev);
                //Console.Write(preMax2[i]+" ");

            }
            //Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                int prev = (i - 1 < 0) ? Int32.MinValue : preMax3[i - 1];
                preMax3[i] = Math.Max(preMax2[i] + D * A[i], prev);
                //Console.Write(preMax3[i]+" ");
            }
            //Console.WriteLine();
            return preMax3[n - 1];
        }
    }

}
