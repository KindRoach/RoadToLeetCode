using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191_NumberOf1Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HammingWeight(UInt32.MaxValue));
        }

        static int HammingWeight(uint n)
        {
            uint count = 0;
            while (n != 0)
            {
                count += n & 1;
                n >>= 1;
            }
            return (int)count;
        }
    }
}
