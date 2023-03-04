using System;
namespace dsaDotNet.Advanced.Hashing
{
	public class SortArrayInGivenOrder
	{
        public List<int> solve(List<int> A, List<int> B)
        {
            Dictionary<int, int> hm = new Dictionary<int, int>();
            for (int i = 0; i < B.Count; i++)
            {
                hm.Add(B[i], i);
            }
            A.Sort((x, y) => {
                if (hm.ContainsKey(x) && hm.ContainsKey(y))
                {
                    if (hm[x] < hm[y]) return -1;
                    if (hm[x] > hm[y]) return 1;
                    else
                    {
                        return 0;
                    }
                }
                else if (hm.ContainsKey(x)) return -1;
                else if (hm.ContainsKey(y)) return 1;
                else
                {
                    if (x < y) return -1;
                    if (x > y) return 1;
                    else
                    {
                        return 0;
                    }
                }

        });
            return A;
        }
    }
}

