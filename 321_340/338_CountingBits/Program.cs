using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _338_CountingBits
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in CountBits(18))
            {
                Console.WriteLine(item);
            }
        }

        static int[] CountBits(int num)
        {
            var ans = new int[num + 1];
            ans[0] = 0;
            int adjust = 1;
            for (int count = 1; count <= num; count++)
            {
                ans[count] = 1 + ans[count - adjust];
                if (count + 1 == adjust * 2)
                {
                    adjust *= 2;
                }
            }
            return ans;
        }
    }
}
