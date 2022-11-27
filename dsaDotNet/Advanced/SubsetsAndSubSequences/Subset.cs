using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaDotNet.Advanced.SubsetsAndSubSequences
{
     
    class Subset
    {
        public List<List<int>> subsets(List<int> A)
        {
            A.Sort();
            int n = (int)Math.Pow(2, A.Count);
            List<List<int>> ans = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                List<int> li = new List<int>();
                for (int j = 0; j < A.Count; j++)
                {
                    if (((i) & (1 << j)) > 0) li.Add(A[j]);
                }
                ans.Add(li);
            }
            ans.Sort((x, y) => {
                int r = 0;
                for (int i = 0; i < Math.Min(x.Count, y.Count); i++)
                {
                    r=x[i].CompareTo(y[i]);
                    if(r!=0) return r;
                }
                r=x.Count.CompareTo(y.Count);
                return r;
                
            });
            return ans;
        }
    }

}
