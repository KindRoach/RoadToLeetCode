using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _238_ProductOfArrayExceptSelf
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Count();
            var ans = new int[n];
            int product = 1;
            for (int i = 0; i < n; i++)
            {
                ans[i] = product;
                product = product * nums[i];
            }
            product = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                ans[i] = ans[i] * product;
                product = product * nums[i];
            }
            return ans;
        }
    }
}
