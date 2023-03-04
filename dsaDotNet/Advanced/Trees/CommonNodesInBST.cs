using System;
using static dsaDotNet.Advanced.LinkedList.LinkList;

namespace dsaDotNet.Advanced.Trees
{
	public class CommonNodesInBST
	{
        Dictionary<int, int> hm;
        int ans;
        public int solve(TreeNode A, TreeNode B)
        {

            hm = new Dictionary<int, int>();
            ans = 0;
            int mod = 1000000007;

            preOrder(A);
            preOrder(B);

            foreach (var item in hm)
            {
                if (item.Value > 1)
                {
                    ans = (ans + item.Key) % mod;
                }
            }
            return ans;
        }

        public void preOrder(TreeNode A)
        {
            if (A == null) return;

            if (hm.ContainsKey(A.val))
            {
                hm[A.val]++;
            }
            else
            {
                hm.Add(A.val, 1);
            }
        }
    }
}

