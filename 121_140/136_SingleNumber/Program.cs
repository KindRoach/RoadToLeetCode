using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _136_SingleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((2 ^ 1 ^ 3) == (2 ^ 3 ^ 1));
        }

        static int SingleNumber(int[] nums)
        {
            for (int i = 1; i < nums.Count(); i++)
            {
                nums[0] = nums[0] ^ nums[i];
            }
            return nums[0];
        }
    }
}
