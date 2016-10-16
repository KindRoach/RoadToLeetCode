using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _401_BinaryWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadBinaryWatch(1);
        }

        static IList<string> ReadBinaryWatch(int num)
        {
            var ans = new List<string>();
            for (int h = 0; h < 12; h++)
            {
                for (int m = 0; m < 60; m++)
                {
                    if (BitCount(h) + BitCount(m) == num)
                    {
                        ans.Add(string.Format("{0}:{1,2:D2}", h, m));
                    }
                }
            }
            return ans;
        }

        static int BitCount(int x)
        {
            int ans = 0;
            while (x != 0)
            {
                if ((x & 1) == 1)
                {
                    ans++;
                }
                x = x >> 1;
            }
            return ans;
        }
    }
}
