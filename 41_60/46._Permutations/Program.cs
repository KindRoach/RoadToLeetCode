using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46._Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            var ans = Permute(new int[] { 1, 2, 3 });
        }

        static List<IList<int>> Ans { get; set; }
        static List<int> Temp { get; set; }
        static Dictionary<int, bool> Dic { get; set; }

        static IList<IList<int>> Permute(int[] nums)
        {
            Ans = new List<IList<int>>();
            Temp = new List<int>();
            Dic = new Dictionary<int, bool>();
            foreach (var item in nums) Dic.Add(item, false);
            Helper(nums, 1, nums.Count());
            return Ans;
        }

        static void Helper(int[] nums, int k, int n)
        {
            if (k > n) Ans.Add(new List<int>(Temp));
            foreach (var item in nums)
            {
                if (!Dic[item])
                {
                    Dic[item] = true;
                    Temp.Add(item);
                    Helper(nums, k + 1, n);
                    Temp.RemoveAt(Temp.Count() - 1);
                    Dic[item] = false;
                }
            }
        }
    }
}
