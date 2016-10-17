using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _287_FindTheDuplicateNumber
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public int FindDuplicate(int[] nums)
        {
            int l = 1, r = nums.Length - 1;
            int count, mid;
            while (l < r)
            {
                mid = (l + r) / 2;
                count = 0;
                foreach (var item in nums)
                {
                    if (item <= mid)
                    {
                        count++;
                    }
                }
                if (count <= mid)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid;
                }
            }
            return l;
        }
    }
}
