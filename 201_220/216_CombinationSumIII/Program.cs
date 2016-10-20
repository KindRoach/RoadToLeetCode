using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _216_CombinationSumIII
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CombinationSum3(3, 9);
        }

        static IList<IList<int>> CombinationSum3(int k, int n)
        {
            var ans = new List<IList<int>>();
            Helper(ans, new List<int>(), k, n, 1);
            return ans;
        }

        static void Helper(List<IList<int>> ans, List<int> comb, int k, int n, int start)
        {
            if (n < 0) return;
            if (k == 0)
            {
                if (n == 0) ans.Add(new List<int>(comb));
                return;
            }

            for (int i = start; i <= 9; i++)
            {
                comb.Add(i);
                Helper(ans, comb, k - 1, n - i, i + 1);
                comb.Remove(i);
            }
        }
    }
}
