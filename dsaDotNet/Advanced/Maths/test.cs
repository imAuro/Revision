using System;
namespace dsaDotNet.Advanced.Maths
{
	public class test
	{
		public void m1()
		{
            int inp = Int32.Parse(Console.ReadLine().Trim());
            int[] input = Console.ReadLine().Trim().Split(" ").Select(x => Int32.Parse(x.ToString())).ToArray();
            int d = Int32.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < input.Length; i++)
            {
                if (i != d)
                {
                    Console.Write((int)input[i] + " ");
                }
            }
        }

    }

}

