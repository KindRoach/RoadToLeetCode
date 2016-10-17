using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt2("MCMLXXX"));
        }

        static int RomanToInt(string s)
        {
            var dic = new Dictionary<string, int>(30);
            var nums = new int[]
            {
                1,2,3,4,5,6,7,8,9,
                10,20,30,40,50,60,70,80,90,
                100,200,300,400,500,600,700,800,900,
                1000,2000,3000
            };
            var strings = new string[]
            {
                "I","II","III","IV","V","VI","VII","VIII","IX",
                "X","XX","XXX","XL","L","LX","LXX","LXXX","XC",
                "C","CC","CCC","CD","D","DC","DCC","DCCC","CM",
                "M","MM","MMM"
            };
            for (int i = 0; i < 30; i++)
            {
                dic.Add(strings[i], nums[i]);
            }
            int ans = 0;
            string roman;
            int subLen = 1;
            while (s.Length != 0)
            {
                while (subLen < s.Length && dic.Keys.Contains(s.Substring(0, subLen + 1)))
                {
                    subLen++;
                }
                roman = s.Substring(0, subLen);
                ans += dic[roman];
                s = s.Remove(0, subLen);
                subLen = 1;
            }
            return ans;
        }

        static int RomanToInt2(string s)
        {
            var dic = new Dictionary<char, int>()
            {
                {'I',1}, {'V',5}, {'X',10}, {'L',50}, {'C',100}, {'D',500}, {'M',1000}
            };

            int ans = 0;
            int roman;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                roman = dic[s[i]];
                ans += ans >= roman * 5 ? -roman : roman;
            }
            return ans;
        }
    }
}
