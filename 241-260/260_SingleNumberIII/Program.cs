using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260_SingleNumberIII
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int[] SingleNumber(int[] nums)
        {
            int res = 0;
            foreach (var item in nums)
            {
                res = res ^ item;
            }
            int flag = 1;
            while ((res & flag) == 0)
            {
                flag = flag << 1;
            }
            int res1 = 0, res2 = 0;
            foreach (var item in nums)
            {
                if ((item & flag) == 0)
                {
                    res1 = res1 ^ item;
                }
                else
                {
                    res2 = res2 ^ item;
                }
            }
            return new int[] { res1, res2 };
        }
    }
}
