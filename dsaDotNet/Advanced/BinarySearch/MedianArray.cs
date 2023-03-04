using System;
namespace dsaDotNet.Advanced.BinarySearch
{
    public class MedianArray
    {

        public double findMedianSortedArrays(List<int> A, List<int> B)
        {
            List<int> res = new List<int>();
            int a = A.Count;
            int b = A.Count;

            int i = 0, j = 0;
            while (i < a && j < b)
            {
                if (A[i] < B[j])
                {
                    res.Add(A[i]);
                    i++;
                }
                else
                {
                    res.Add(B[j]);
                    j++;
                }
            }

            while (i < a)
            {
                res.Add(A[i]);
                i++;
            }
            while (j < b)
            {
                res.Add(B[j]);
                j++;
            }
            int n = res.Count;
            if (n % 2 == 0)
            {
                return (res[n / 2] + res[(n / 2) + 1]) / 2;
            }
            else
            {
                return res[n / 2];
            }

        }

        public double findMedianSortedArraysOptimised(List<int> A, List<int> B)
        {
            int countA = A.Count;
            int countB = B.Count;

            if (countA == 0)
            {
                return median(B, countB);
            }
            if (countB == 0)
            {
                return median(A, countA);
            }

            if (countA > countB)
            {
                return findMedianSortedArraysOptimised(B, A);
            }

            int maxSize = (countA + countB + 1) / 2;

            int l = 0, h = countA;
            double a = 0.0;
            double b = 0.0;
            while (l <= h)
            {
                int midLeft = l + (h - l) / 2;
                int midRight = maxSize - midLeft;

                int maxLeftA = (midLeft == 0) ? Int32.MinValue : A[midLeft - 1];
                int maxLeftB = (midRight == 0) ? Int32.MinValue : B[midRight - 1];

                int minRightA = (midLeft == countA) ? Int32.MaxValue : A[midLeft];
                int minRightB = (midRight == countB) ? Int32.MaxValue : B[midRight];


                if (maxLeftA <= minRightB && maxLeftB <= minRightA)
                {
                    a = Math.Max(maxLeftA, maxLeftB);
                    b = Math.Min(minRightA, minRightB);
                    break;
                }
                else if (maxLeftA > minRightB)
                {
                    h = midLeft - 1;
                }
                else
                {
                    l = midLeft + 1;
                }

            }
            if ((countA + countB) % 2 == 0)
            {
                return (a + b) / 2.0;
            }
            return a;
        }
        public double median(List<int> A, int c)
        {
            if (c % 2 == 0)
            {
                return (A[c / 2] + A[(c / 2) - 1]) / 2.0;
            }
            return A[c / 2];
        }
    }
}
