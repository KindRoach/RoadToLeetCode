using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _153_FindMinimumInRotatedSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindMin(new int[] { 4, 5, 6, 7, 8, 10, 11, 0, 1, 2 }));
        }

        static int FindMin(int[] nums)
        {
            int low = 0, up = nums.Count() - 1;
            int mid;
            while (low < up)
            {
                mid = (low + up) / 2;
                if (nums[up] > nums[mid])
                    up = mid;
                else
                    low = mid + 1;
            }
            return nums[low];
        }
    }
}
