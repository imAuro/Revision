using System;
namespace dsaDotNet.Advanced.Sorting
{
	public class MaximunAndMinimumMagic
	{
        public List<int> solve(List<int> A)
        {
            long max1 = 0;
            long max2 = 0;
            long min = 0;
            int mod = 1000000007;
            A.Sort();
            int n = A.Count;
            for (int i = 0; i < n / 2; i++)
            {
                max1 = (max1 + Math.Abs(A[n - 1 - i] - A[i])) % mod;
                max2 = (max2 + Math.Abs(A[i + (n / 2)] - A[i])) % mod;
            }
            for (int i = 0; i < n; i = i + 2)
            {
                min = (min + Math.Abs(A[i] - A[i - 1])) % mod;
            }

            return new List<int> { Math.Max((int)max1, (int)max2), (int)min };

        }
    }
}

