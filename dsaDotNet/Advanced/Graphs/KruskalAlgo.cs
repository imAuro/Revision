using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaDotNet.Advanced.Graphs
{
    class KruskalAlgo
    {
        int[] sections = null;
        public int solve(int A, List<List<int>> B)
        {
            int m = B.Count();
            B.Sort((List<int> a, List<int> b) => {
                if (a[2] < b[2]) return -1;
                if (a[2] > b[2]) return 1;
                return 0;
            });

            sections = new int[A + 1];
            for (int i = 0; i <= A; i++)
            {
                sections[i] = i;
            }
            int[] size = new int[A + 1];
            for (int i = 0; i <= A; i++)
            {
                size[i] = 1;
            }
            int cost = 0;
            for (int i = 0; i < m; i++)
            {
                int n1 = B[i][0];
                int n2 = B[i][1];
                int x = getComp(n1);
                int y = getComp(n2);
                if (x != y)
                {
                    if (size[x] > size[y])
                    {
                        int t = x;
                        x = y;
                        y = t;
                    }
                    sections[x] = sections[y];
                    size[y] = size[x] + 1;
                    cost += B[i][2];
                }
            }
            return cost;
        }

        public int getComp(int x)
        {
            if (x == sections[x]) return sections[x];
            sections[x] = getComp(sections[x]);
            return sections[x];
        }
    }

}




// need to find the minimum spanning tree
        //how? Krushkal's algo
        // 1. sort the array by increasing order of weights
        // after adding each edge, check if that forms a cycle if cycle then don't add
        //sum the weights ina a variable, return the sum

        //optimise the cycle detection How?
        //1. initially keep all the sections are different i.e keep it same as the node
        // whenever we are adding an edge, if it is of different section then we are okay
        //it doesn't form any cycle, but if it is of same node, we should not add int

        // if it is of different cycle, we need to add the smaller section size to the larger section,
        //and the smaller section's section to the larger section
