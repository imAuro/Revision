using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaDotNet.Advanced.SubsetsAndSubSequences
{
    class SumTheDifference
    {
        public int solve(List<int> A)
        {
            int n = A.Count;
            int p = (int)Math.Pow(2, n - 1);
            int max = A.Max();
            int min = A.Min();
            return (max - min) * (p - 1);
        }
    }
}
