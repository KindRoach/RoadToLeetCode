using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _319_BulbSwitcher
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"{i + 1}-{BulbSwitch(i + 1)}");
            }
        }

        static int BulbSwitch(int n)
        {
            var bulbs = new bool[n];
            int ans = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i - 1; j < n; j += i)
                {
                    bulbs[j] = !bulbs[j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (bulbs[i]) ans++;
            }
            //return ans;
            return (int)Math.Floor(Math.Sqrt(n));
        }

    }
}
