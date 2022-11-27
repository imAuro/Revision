using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaDotNet.Advanced.Arrays
{
    class NoOfOpenDoors
    {
        /// <summary>
        /// TC:O(n^3/2) 
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int solve(int A)
        {
            //need to find the number of composite number from 1 to A
            int count = 1;
            for (int i = 2; i <= A; i++)
            {
                if (!isEvenFactors(i)) count++;
            }
            return count;
        }
        public bool isEvenFactors(int A)
        {
            int count = 0;
            for (int i = 1; i * i <= A; i++)
            {
                if (A % i == 0) count += 2;
                if (A == (i * i)) count -= 1;
            }
            return (count % 2 == 0) ? true : false; ;
        }
    }
}
