using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _283_MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = new int[] { 0, 0, 1 };
            MoveZeroes(ints);
        }

        static void MoveZeroes(int[] nums)
        {
            int last0 = nums.Count();
            for (int i = 0; i < last0; i++)
            {
                if (nums[i] == 0)
                {
                    last0--;
                    i--;
                    for (int j = i; j < last0; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    nums[last0] = 0;
                }
            }
        }

        // O(N)!!!!!!!!
        static void MoveZeroes2(int[] nums)
        {
            int numZeroes = 0;
            for (int i = 0; i < nums.Count(); i++)
            {
                if (nums[i] == 0)
                {
                    numZeroes++;
                }
                else
                {
                    nums[i - numZeroes] = nums[i];
                }
            }
            for (int i = nums.Count() - numZeroes; i < nums.Count(); i++)
            {
                nums[i] = 0;
            }
        }
    }
}
