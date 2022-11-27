using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaDotNet.Advanced.Arrays
{
    class AddOneToNumber
    {
        public List<int> plusOne(List<int> A)
        {

            List<int> ans = new List<int>();
            int n = A.Count() - 1;
            int c = 1;
            while (n >= 0)
            {
                int x = A[n] + c;
                if (x >= 10)
                {
                    ans.Add(x % 10);
                    c = 1;
                }
                else
                {
                    ans.Add(x);
                    c = 0;
                }
                n--;
            }
            if (c == 1)
            {
                ans.Add(1);
            }
            n = ans.Count();
            // for( int i=0;i<n;i++)
            // {
            //     if(ans[i]==0) 
            //     {
            //         ans.RemoveAt(i);
            //         i--;
            //     }
            //     else
            //     {
            //         break;
            //     }
            // }
            for (int i = n - 1; i >= 0; i--)
            {
                if (ans[i] == 0)
                {
                    ans.RemoveAt(i);
                }
                else
                {
                    break;
                }
            }
            ans.Reverse();
            return ans;
        }
    }


}
