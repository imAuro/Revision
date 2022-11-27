using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaDotNet.Advanced.Graphs
{
    class ValidPath
    {
        bool[,] visited = null;
        int x, y;
        public string solve(int A, int B, int C, int D, List<int> E, List<int> F)
        {
            x = A;
            y = B;
            int[,] ans = new int[A + 1, B + 1];
            for (int a = 0; a <= A; a++)
            {
                for (int b = 0; b <= B; b++)
                {
                    for (int i = 0; i < C; i++)
                    {
                        //check if ans[a,b] lies between E[i],F[i]'s circle with radius D
                        if (((E[i] - a) * (E[i] - a) + (F[i] - b) * (F[i] - b)) <= (D * D))
                        {
                            ans[a, b] = 1;
                            break;
                        }
                    }

                }

            }

            visited = new bool[A + 1, B + 1];
            dfs(ans, 0, 0);
            if (visited[A, B] == true) return "YES";
            return "NO";
        }
        public void dfs(int[,] ans, int i, int j)
        {
            //base condition
            if (i < 0 || j < 0 || i > x || j > y || ans[i, j] == 1 || visited[i, j] == true)
            {
                return;
            }
            visited[i, j] = true;

            //traverse on the 8 sides
            dfs(ans, i + 1, j);
            dfs(ans, i, j + 1);
            dfs(ans, i + 1, j + 1);
            dfs(ans, i - 1, j);
            dfs(ans, i, j - 1);
            dfs(ans, i - 1, j - 1);
            dfs(ans, i - 1, j + 1);
            dfs(ans, i + 1, j - 1);
        }



    }

}
