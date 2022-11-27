using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaDotNet.Advanced.Graphs
{
    class TopologySort
    {
        /// <summary>
        /// Doesn't sort it lexicographically
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public List<int> solve(int A, List<List<int>> B)
        {
            int[] dependencies = new int[A + 1];
            List<List<int>> edges = new List<List<int>>();
            int m = B.Count();
            for (int i = 0; i <= A; i++)
            {
                edges.Add(new List<int>());
            }
            for (int i = 0; i < m; i++)
            {
                edges[B[i][0]].Add(B[i][1]);
                dependencies[B[i][1]]++;
            }
            //insert all the elements with 0 dependencies in the queue
            Queue<int> q = new Queue<int>();
            for (int i = 1; i <= A; i++)
            {
                if (dependencies[i] == 0) q.Enqueue(i);
            }

            List<int> result = new List<int>();
            while (q.Count() > 0)
            {
                var p = q.Dequeue();
                result.Add(p);
                var cur = edges[p];
                for (int i = 0; i < cur.Count; i++)
                {
                    dependencies[cur[i]]--;
                    if (dependencies[cur[i]] == 0) q.Enqueue(cur[i]);
                }
            }
            return result;
        }
    }


}
