using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample504
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            foreach (int i in nums)     // for(int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0} ", nums[i]);
            }
        }
    }
}