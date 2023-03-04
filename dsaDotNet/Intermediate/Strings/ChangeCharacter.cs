using System;
namespace dsaDotNet.Intermediate.Strings
{
	public class ChangeCharacter
	{
        public int solve(string A, int B)
        {
            int[] alphabets = new int[27];
            int ans = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int a = A[i];
                alphabets[a]++;
            }
            Array.Sort(alphabets);

            for (int i = 1; i < 27; i++)
            {

                if (A[i] > 0 && B > 0)
                {
                    alphabets[i] = alphabets[i]--;
                    B--;
                }
            }
            for (int i = 1; i < 27; i++)
            {

                if (A[i] > 0)
                {
                    ans++;
                }
            }
            return ans;


        }
    }
}

