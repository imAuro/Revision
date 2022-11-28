using System;
namespace dsaDotNet.Advanced.Maths
{
	public class DivisorGame
	{
        public int solve(int A, int B, int C)
        {
            int gcd = GetGCD(B, C);
            long b = B;
            long lcm = (b * C) / gcd;

            int ans = (int)(A / lcm);
            return ans;

        }
        public int GetGCD(int a, int b)
        {
            if (b == 0) return a;
            return GetGCD(b, a % b);
        }
    }
}

