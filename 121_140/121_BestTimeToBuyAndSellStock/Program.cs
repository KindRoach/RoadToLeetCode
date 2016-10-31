using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121_BestTimeToBuyAndSellStock
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public int MaxProfit(int[] prices)
        {
            int n = prices.Count();
            if (n == 0) return 0;
            var buy = -prices[0];
            var sell = 0;
            for (int i = 1; i < n; i++)
            {
                buy = Math.Max(buy, -prices[i]);
                sell = Math.Max(sell, prices[i] + buy);
            }
            return sell;
        }
    }
}
