using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _349_IntersectionOfTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var ans = new HashSet<int>();
            var set = new HashSet<int>();
            foreach (var item in nums1)
            {
                set.Add(item);
            }
            foreach (var item in nums2)
            {
                if (set.Contains(item))
                {
                    ans.Add(item);
                }
            }
            return ans.ToArray();
        }
    }
}
