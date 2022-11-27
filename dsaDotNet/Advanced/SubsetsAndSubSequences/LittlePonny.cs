using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaDotNet.Advanced.SubsetsAndSubSequences
{
     class LittlePonny
    {
        public string solve(string A)
        {
            char[] inp = A.ToCharArray();
            int n = (int)Math.Pow(2, A.Length);
            String ans = A;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= A.Length; j++)
                {
                    StringBuilder s = new StringBuilder();
                    if (((1 << j) & i) > 0)
                    {
                        s.Append(A[j]);
                    }

                    if (s.Length >= 2 && ans.CompareTo(s) <= 0)
                    {
                        ans = s.ToString();
                    }

                }
            }
            return ans;
        }
    }
}
