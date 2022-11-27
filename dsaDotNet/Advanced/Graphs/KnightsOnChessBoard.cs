using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaDotNet.Advanced.Graphs
{
    class KnightsOnChessBoard
    {
        int[,] visited = null;
        int g, h;
        public int knight(int A, int B, int C, int D, int E, int F)
        {
            g = A;
            h = B;
            visited = new int[A + 1, B + 1];
            for (int i = 0; i <= A; i++)
            {
                for (int j = 0; j <= B; j++)
                {
                    visited[i, j] = -1;
                }
            }
            Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
            q.Enqueue(new Tuple<int, int>(C, D));
            visited[C, D] = 0;
            while (q.Count() > 0)
            {
                var p = q.Dequeue();
                int i = p.Item1;
                int j = p.Item2;
                if (valid(i + 2, j + 1))
                {
                    visited[i + 2, j + 1] = visited[i, j] + 1;
                    q.Enqueue(new Tuple<int, int>(i + 2, j + 1));
                }
                if (valid(i + 1, j + 2))
                {
                    visited[i + 1, j + 2] = visited[i, j] + 1;
                    q.Enqueue(new Tuple<int, int>(i + 1, j + 2));
                }
                if (valid(i + 2, j - 1))
                {
                    visited[i + 2, j - 1] = visited[i, j] + 1;
                    q.Enqueue(new Tuple<int, int>(i + 2, j - 1));
                }
                if (valid(i + 1, j - 2))
                {
                    visited[i + 1, j - 2] = visited[i, j] + 1;
                    q.Enqueue(new Tuple<int, int>(i + 1, j - 2));
                }
                if (valid(i - 1, j - 2))
                {
                    visited[i - 1, j - 2] = visited[i, j] + 1;
                    q.Enqueue(new Tuple<int, int>(i - 1, j - 2));
                }
                if (valid(i - 2, j - 1))
                {
                    visited[i - 2, j - 1] = visited[i, j] + 1;
                    q.Enqueue(new Tuple<int, int>(i - 2, j - 1));
                }
                if (valid(i - 2, j + 1))
                {
                    visited[i - 2, j + 1] = visited[i, j] + 1;
                    q.Enqueue(new Tuple<int, int>(i - 2, j + 1));
                }
                if (valid(i - 1, j + 2))
                {
                    visited[i - 1, j + 2] = visited[i, j] + 1;
                    q.Enqueue(new Tuple<int, int>(i - 1, j + 2));
                }
            }
            return visited[E, F];

        }
        public bool valid(int i, int j)
        {
            if (i > 0 && j > 0 && i <= g && j <= h && visited[i, j] == -1) return true;
            return false;
        }
    }

}
