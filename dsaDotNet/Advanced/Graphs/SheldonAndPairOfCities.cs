using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaDotNet.Advanced.Graphs
{
    class SheldonAndPairOfCities
    {
        public List<int> solve(int A, int B, int C, List<int> D, List<int> E, List<int> F, List<int> G, List<int> H)
        {
            int max = 200000001;
            //form the adjacency List
            int[,] weights = new int[A + 1, A + 1];
            for (int i = 1; i <= A; i++)
            {
                for (int j = 1; j <= A; j++)
                {
                    if (i == j) weights[i, j] = 0;
                    else
                    {
                        weights[i, j] = max;
                    }
                }
            }
            for (int i = 0; i < B; i++)
            {
                weights[D[i], E[i]] = F[i];
                weights[E[i], D[i]] = F[i];
            }

            for (int k = 1; k <= A; k++)
            {
                for (int i = 1; i <= A; i++)
                {
                    for (int j = 1; j <= A; j++)
                    {

                        
                        weights[i, j] = Math.Min(weights[i, j], weights[i, k] + weights[k, j]);
                    }
                }
            }
            List<int> ans = new List<int>();
            for (int i = 0; i < C; i++)
            {
                ans.Add(weights[G[i], H[i]]);
            }
            return ans;






        }
    }

}
