using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaDotNet.Advanced.Maths
{
     class ExcelColumnTitle
    {
        public string convertToTitle(int A)
        {
            StringBuilder s = new StringBuilder();
            while (A > 0)
            {
                s.Insert(0,(char)((A % 26) + 'A' - 1));
                A = A / 26;
            }

            string ans = s.ToString();
            ans.Reverse();
            //string res = new string(ans.ToCharArray().Reverse().ToString());
            return ans;


        }
    }
}
