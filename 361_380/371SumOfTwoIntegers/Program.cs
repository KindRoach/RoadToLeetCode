using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _371SumOfTwoIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((12 + 9) == GetSum(12, 9));
        }

        static int GetSum(int a, int b)
        {
            int temp = a & b;
            while (temp != 0)
            {
                a = a ^ b;
                b = temp << 1;
                temp = a & b;
            }
            return a ^ b;
        }
    }
}
