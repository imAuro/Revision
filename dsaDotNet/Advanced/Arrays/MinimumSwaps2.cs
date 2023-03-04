using System;
namespace dsaDotNet.Advanced.Arrays
{
	public class MinimumSwaps2
	{
        public int solve(List<int> A)
        {
            int jumps = 0, curEnd = 0, curFarthest = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (curFarthest < i) return -1;
                curFarthest = Math.Max(curFarthest, i + A[i]);
                if (i == curEnd && curEnd < A.Count - 1)
                {
                    jumps++;
                    curEnd = curFarthest;
                }
            }
            return jumps;
        }
    }
}

