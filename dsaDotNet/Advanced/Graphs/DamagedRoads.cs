using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaDotNet.Advanced.Graphs
{
    class DamagedRoads
    {
        public int solve(List<int> A, List<int> B)
        {
            int mod = 1000000007;
            List<Tuple<int, int>> edges = new List<Tuple<int, int>>();
            foreach (var item in A)
            {
                edges.Add(new Tuple<int, int>(0, item));
            }
            foreach (var item in B)
            {
                edges.Add(new Tuple<int, int>(1, item));
            }
            edges.Sort((Tuple<int, int> a, Tuple<int, int> b) => {
                if (a.Item2 < b.Item2) return -1;
                if (a.Item2 > b.Item2) return 1;
                return 0;
            });
            int n = A.Count() + 1;
            int m = B.Count() + 1;
            long ans = 0;
            for (int i = 0; i < edges.Count(); i++)
            {

                if (edges[i].Item1 == 0)
                {
                    ans = (ans + (edges[i].Item2) * m) % mod; n--;
                }
                if (edges[i].Item1 == 1)
                {
                    ans = (ans + (edges[i].Item2) * n) % mod; m--;
                }
            }
            return (int)(ans % mod);


        }
    }

    //create a list of all the edges pairs 0 meaning it's a vertical pair and 1 meaning it's a horizontal pair
    //arrange the pair of edges in increasing order of their weight
    //let n= col and m=rows
    //take the edges one by one, 
    //if the edge is horizontal then multiply the weight to m and do n--
    //if the edge is vertical then multiply the weight to n and do m-- 
    //add it to the ans
    // return the ans

}
