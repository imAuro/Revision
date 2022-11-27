using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaDotNet.Advanced.SubsetsAndSubSequences
{
     class SpecialSubSequencesAG
    {
            public int solve(string A)
            {
                int a = 0;
                int ans = 0;
                int mod = 1000000007;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].Equals('A'))
                    {
                        a++;
                    }
                    else if (A[i].Equals('G'))
                    {
                        ans = (ans + a) % mod;
                    }
                }
                return ans;
        }
    }
}
