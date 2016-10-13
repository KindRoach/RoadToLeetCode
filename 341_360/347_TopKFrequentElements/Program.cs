using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _347_TopKFrequentElements
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime before, after;
            var nums = GetNumbers(10000);
            before = DateTime.Now;
            var ans1 = TopKFrequent(nums, 100);
            after = DateTime.Now;
            Console.WriteLine(after-before);

            before = DateTime.Now;
            var ans2 = TopKFrequent(nums, 100);
            after = DateTime.Now;
            Console.WriteLine(after - before);
        }

        static int[] GetNumbers(int size)
        {
            int[] numbers = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(size / 10);
            }
            return numbers;
        }

        static IList<int> TopKFrequent(int[] nums, int k)
        {
            var dic = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (dic.Keys.Contains(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic.Add(item, 1);
                }
            }
            return dic.OrderByDescending(x => x.Value).
                       Select(x => x.Key).Take(k).ToList();
        }

        static IList<int> TopKFrequent2(int[] nums, int k)
        {
            var dic = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (dic.Keys.Contains(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic.Add(item, 1);
                }
            }

            var arr = dic.ToArray();
            var ans = new List<int>(k);
            Array.Sort(arr, (x, y) => y.Value - x.Value);
            for (int i = 0; i < k; i++)
            {
                ans.Add(arr[i].Key);
            }
            return ans;
        }
    }
}
