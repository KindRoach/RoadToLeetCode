using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _96_UniqueBinarySearchTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{i}---{NumTrees(i)}");
            }
        }

        //用来找规律的爆搜
        static int NumTrees2(int n)
        {
            return Helper(1, n);
        }
        static int Helper(int l, int r)
        {
            if (l >= r) return 1;
            int ans = 0;
            for (int i = l; i <= r; i++)
            {
                ans += Helper(l, i - 1) * Helper(i + 1, r);
            }
            return ans;
        }

        //使用数组优化
        static int NumTrees(int n)
        {
            var A = new int[n + 2];
            A[0] = A[1] = 1;
            A[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    A[i] += A[j] * A[i - j - 1];
                }
            }
            return A[n];
        }
    }
}
