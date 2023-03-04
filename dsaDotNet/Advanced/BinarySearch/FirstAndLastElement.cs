using System;
namespace dsaDotNet.Advanced.BinarySearch
{
    public class FirstAndLastElement
    {
        public int[] SearchRange(int[] nums, int target)
        {

            int s = findFirst(nums, target);
            int e = findLast(nums, target);
            return new int[] { s, e };
        }

        public int findLast(int[] A, int t)
        {
            int s = 0;
            int e = A.Length;
            while (s <= e)
            {
                int m = s + (e - s) / 2;
                int next = (m >= A.Length-1) ? Int32.MaxValue : A[m + 1];
                if (t == A[m] && A[m] < next)// first occurrence
                {
                    return m;
                }
                else if (A[m] < t || (A[m] == t && A[m] == next))
                {
                    s = m + 1;
                }
                else
                {
                    e = m - 1;
                }

            }
            return -1;
        }

        public int findFirst(int[] A, int t)
        {
            int s = 0;
            int e = A.Length - 1;
            while (s <= e)
            {
                int m = s + (e - s) / 2;
                int prev = (m == 0) ? Int32.MinValue : A[m - 1];
                if (t == A[m] && A[m] > prev)// first occurrence
                {
                    return m;
                }
                else if ((A[m]==t && A[m]==prev)|| A[m]>t)
                {
                    e = m - 1;

                }
                else
                {
                    s = m + 1;
                }

            }
            return -1;
        }
    }
}

