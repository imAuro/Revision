using System;
namespace dsaDotNet.Advanced.Stacks
{
	public class MaximumRectangle
	{
        public int solve(List<List<int>> A)
        {
            int n = A.Count();
            int m = A[0].Count;
            int ans = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (A[i][j] != 0)
                    {
                        int prev = (i - 1 > 0) ? A[i - 1][j] : 0;
                        A[i][j] = A[i - 1][j] + 1;
                    }

                    ans = Math.Max(ans, calculateMax(A[i], i, m));
                }

            }
            return ans;
        }
        public int calculateMax(List<int> A, int i, int m)
        {

            int[] nearestMinLeft = new int[m];
            initialize(nearestMinLeft, -1);
            Stack<int> st = new Stack<int>();
            st.Push(A[0]);

            for (int j = 0; j < m; j++)
            {
                while (st.Count > 0 && A[st.Peek()] >= A[i])
                {
                    st.Pop();
                }
                if (st.Count > 0)
                {
                    nearestMinLeft[i] = st.Peek();
                }
                st.Push(j);
            }

            int[] nearestMinRight = new int[m];
            initialize(nearestMinRight, m);
            st = new Stack<int>();
            st.Push(0);

            for (int j = m - 1; j >= 0; j--)
            {
                while (st.Count > 0 && A[st.Peek()] >= A[i])
                {
                    st.Pop();
                }
                if (st.Count > 0)
                {
                    nearestMinRight[i] = st.Peek();
                }
                st.Push(j);
            }

            int ans = 0;
            for (int k = 0; i < m; i++)
            {

                ans += A[k] * (nearestMinRight[k] - nearestMinLeft[k] + 2);
            }
            return ans;
        }

        public void initialize(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                A[i] = n;
            }
        }
    }
}

