using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _122_BestTimeToBuyAndSellStockII
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public int MaxProfit(int[] prices)
        {
            int sum = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] < prices[i + 1])
                {
                    sum += prices[i + 1] - prices[i];
                }
            }
            return sum;
        }
    }
}
