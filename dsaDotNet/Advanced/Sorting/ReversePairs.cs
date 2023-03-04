using System;
namespace dsaDotNet.Advanced.Sorting
{
    public class ReversePairs
    {

        int c = 0;
        int[] sorted = null;
        public int solve(List<int> A)
        {
            sorted = new int[A.Count];
            MergeSort(A, 0, A.Count - 1);
            return c;

        }

        public void MergeSort(List<int> A, int s, int e)
        {
            if (s >= e) return;

            int m = s + (e - s) / 2;

            MergeSort(A, s, m);
            MergeSort(A, m + 1, e);
            Merge(A, s, m, e);
        }

        public void Merge(List<int> A, int s, int m, int e)
        {
            List<int> temp = new List<int>();
            int m1 = m + 1;
            int s1 = s;

            // count the number of pairs
            int k = s, l = m + 1;
            while (k <= m && l <= e)
            {
                if (((long)A[k]) > ((long)2 * A[l]))
                {
                    c = c + (m + 1 - k);
                    l++;
                }
                else
                {
                    k++;
                }
            }

            while (s1 <= m && m1 <= e)
            {
                if (A[s1] <= A[m1])
                {

                    temp.Add(A[s1]);
                    s1++;
                }
                else
                {
                    temp.Add(A[m1]);
                    m1++;
                }
            }
            while (s1 <= m)
            {
                temp.Add(A[s1]);
                s1++;
            }
            while (m1 <= e)
            {
                temp.Add(A[m1]);
                m1++;
            }

            int i = 0;
            while (s <= e)
            {
                A[s] = temp[i];
                i++;
                s++;
            }

        }
    }
}
