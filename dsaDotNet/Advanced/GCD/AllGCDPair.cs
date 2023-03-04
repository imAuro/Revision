using System;
namespace dsaDotNet.Advanced.GCD
{
    public class AllGCDPair
    {

        public List<int> solve(List<int> A)
        {
            int n = A.Count;//25
            int s = (int)Math.Sqrt(n);//5

            List<int> res = new List<int>();
            for (int i = 0; i < n; i += s)
            {
                int m = 0;
                for (int j = i; j < i+s; j++)
                {
                    m = Math.Max(m, A[j]);
                }
                res.Add(m);
            }
            return res;
        }


    }
}

