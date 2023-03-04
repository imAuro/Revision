using System;
namespace dsaDotNet.Advanced.Arrays
{
	public class NumberofDigitOne
	{
        public int solve(int A)
        {
            int c = 0;

            for (int i = 1; i <= A; i = i * 10)
            {
                c += ((A / (10 * i)) * i) + Math.Min(Math.Max(((A % (10 * i)) - (i - 1)), 0), i); 
            }
            return c;

        }
    }
}

