using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202_HappyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"{i + 1}--{IsHappy(i + 1)}");
            }
        }

        static bool IsHappy(int n)
        {
            var set = new HashSet<int>();
            int sum = 0;
            while (n != 1)
            {
                while (n != 0)
                {
                    sum += (n % 10) * (n % 10);
                    n /= 10;
                }
                n = sum;
                sum = 0;
                if (!set.Add(n)) return false;
            }
            return true;
        }
    }
}
