using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _137_SingleNumberII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SingleNumber(new int[] { 1, 1, 2, 2, 3, 2, 3, 3 }));
        }

        static int SingleNumber(int[] nums)
        {
            int ans = 0, sum = 0;
            for (int p = 0; p < 32; p++)
            {
                sum = 0;
                for (int i = 0; i < nums.Count(); i++)
                {
                    if ((nums[i] >> p & 1) == 1)
                    {
                        sum++;
                    }
                }
                sum = sum % 3;
                ans = ans | (sum / 2 << p);
            }
            return ans;
        }
    }
}
