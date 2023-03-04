using System;
namespace dsaDotNet.Advanced.Sorting
{
	public class UniqueElements
	{
        public int solve(List<int> A)
        {
            A.Sort();
            int n = A.Count;
            int c = 0;
            for (int i = 1; i < n; i++)
            {
                if (A[i - 1] >= A[i])
                {
                    int t = A[i];
                    A[i] = A[i - 1] + 1;
                    c += A[i] - t;
                }
            }
            return c;
        }
    }
}

