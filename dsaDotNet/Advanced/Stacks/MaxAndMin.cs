using System;
namespace dsaDotNet.Advanced.Stacks
{
    public class MaxaMaxAndMin
    {
        public int solve(List<int> A)
        {
            int mod = 1000000007;

            // get the index of the nearest max on the left
            // get the index of the nearest max on the right;
            int n = A.Count;
            int[] lMax = new int[n];
            int[] rMax = new int[n];
            int[] lMin = new int[n];
            int[] rMin = new int[n];

            initializeAll(lMax, n);
            initializeAll(rMax, n);
            initializeAll(lMin, n);
            initializeAll(rMin, n);

            getLeftMax(lMax, n, A);
            getRightMax(rMax, n, A);
            getLeftMin(lMin, n, A);
            getRightMin(rMin, n, A);

            //get the index of the nearest min on the left
            // get the index of the nearest min on the right 
            long ans = 0;
            for (int i = 0; i < n; i++)
            {
                int leftMax = (lMax[i] == -1) ? -1 : lMax[i];
                int rightMax = (rMax[i] == -1) ? n : rMax[i];

                int leftMin = (lMin[i] == -1) ? -1 : lMin[i];
                int rightMin = (rMin[i] == -1) ? n : rMin[i];
                long max = (1L * A[i] * (i - leftMax) * (rightMax - i)) % mod;
                long min = (1L * A[i] * (i - leftMin) * (rightMin - i)) % mod;
                ans = (ans + (max - min) % mod + mod) % mod;
            }

            return (int)ans % mod;
        }

        public void getLeftMax(int[] lMax, int n, List<int> A)
        {
            Stack<int> st = new Stack<int>();
            st.Push(0);
            for (int i = 1; i < n; i++)
            {

                while (st.Count > 0 && A[st.Peek()] <= A[i])
                {
                    st.Pop();

                }
                if (st.Count > 0)
                {
                    lMax[i] = st.Peek();
                }
                st.Push(i);
            }
        }

        public void getRightMax(int[] rMax, int n, List<int> A)
        {
            Stack<int> st = new Stack<int>();
            st.Push(n - 1);
            for (int i = n - 2; i >= 0; i--)
            {
                while (st.Count > 0 && A[st.Peek()] <= A[i])
                {
                    st.Pop();

                }
                if (st.Count > 0)
                {
                    rMax[i] = st.Peek();
                }
                st.Push(i);
            }
        }

        public void getLeftMin(int[] lMin, int n, List<int> A)
        {
            Stack<int> st = new Stack<int>();
            st.Push(0);
            for (int i = 1; i < n; i++)
            {
                while (st.Count > 0 && A[st.Peek()] >= A[i])
                {
                    st.Pop();

                }
                if (st.Count > 0)
                {
                    lMin[i] = st.Peek();
                }
                st.Push(i);
            }
        }

        public void getRightMin(int[] rMin, int n, List<int> A)
        {
            Stack<int> st = new Stack<int>();
            st.Push(n - 1);
            for (int i = n - 2; i >= 0; i--)
            {
                while (st.Count > 0 && A[st.Peek()] >= A[i])
                {
                    st.Pop();

                }
                if (st.Count > 0)
                {
                    rMin[i] = st.Peek();
                }
                st.Push(i);
            }
        }

        public void initializeAll(int[] lMax, int n)
        {
            for (int i = 0; i < n; i++)
            {
                lMax[i] = -1;
            }
        }
    }
    }

