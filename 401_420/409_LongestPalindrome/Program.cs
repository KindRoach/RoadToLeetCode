using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _409_LongestPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public int LongestPalindrome(string s)
        {
            var charNums = new int[255];
            for (int i = 0; i < s.Length; i++)
            {
                charNums[s[i]]++;
            }
            int ans = 0;
            bool hasOdd = false;
            for (int i = 0; i < 255; i++)
            {
                if (charNums[i] % 2 == 0)
                {
                    ans = ans + charNums[i];
                }
                else
                {
                    ans = ans + charNums[i] - 1;
                    hasOdd = true;
                }
            }
            if (hasOdd)
            {
                ans++;
            }
            return ans;
        }
    }
}
