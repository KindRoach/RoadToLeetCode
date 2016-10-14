using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _357_CountNumbersWithUniqueDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            CountNumbersWithUniqueDigits(4);
        }

        static int CountNumbersWithUniqueDigits(int n)
        {
            if (n == 0) return 1;
            if (n == 1) return 10;
            if (n == 2) return 91;
            int sum = 9;
            int an = 9;
            for (int i = 2; i < n; i++)
            {
                an = an * 10 + (9 * (int)Math.Pow(10, i - 1) - an) * i;
                sum = sum + an;
                Console.WriteLine($"{an}  {sum}");
            }
            return (int)Math.Pow(10, n) - sum;
        }
    }
}
