using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _378_KthSmallestElementInSortedMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[3, 3] { { 1, 5, 9 }, { 10, 11, 13 }, { 12, 13, 15 } };
            Console.WriteLine(KthSmallest(nums, 8));
        }

        static int KthSmallest(int[,] matrix, int k)
        {
            int n = matrix.GetLength(0);
            int l = matrix[0, 0], r = matrix[n - 1, n - 1], mid;
            while (l < r)
            {
                mid = (l + r) / 2;
                int cnt = 0, j = n - 1;
                for (int i = 0; i < n; i++)
                {
                    while (j >= 0 && matrix[i, j] > mid)
                        j--;
                    cnt += j + 1;
                }
                if (cnt < k)
                    l = mid + 1;
                else
                    r = mid;
            }
            return l;
        }
    }
}
