using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_IntegerToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IntToRoman(3000));
        }

        static string IntToRoman(int num)
        {
            var dic = new Dictionary<int, string>()
            {
                { 0, "" },
                { 1, "I" }, { 2, "II" }, { 3, "III" }, { 4, "IV" }, { 5, "V" }, { 6, "VI" }, { 7, "VII" }, { 8, "VIII" }, { 9, "IX" },
                { 10, "X" }, { 20, "XX" }, { 30, "XXX" }, { 40, "XL" }, { 50, "L" }, { 60, "LX" }, { 70, "LXX" }, { 80, "LXXX" }, { 90, "XC" },
                { 100, "C" }, { 200, "CC" }, { 300, "CCC" }, { 400, "CD" }, { 500, "D" }, { 600, "DC" }, { 700, "DCC" }, { 800, "DCCC" }, { 900, "CM" },
                { 1000, "M" }, { 2000, "MM" }, { 3000, "MMM" }
            };
            string ans = "";
            int times = 1;
            while (num != 0)
            {
                ans = dic[num % 10 * times] + ans;
                times *= 10;
                num /= 10;
            }
            return ans;
        }

        public string IntToRoman2(int num)
        {
            var M = new string[] { "", "M", "MM", "MMM" };
            var C = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            var X = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            var I = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            return M[num / 1000] + C[(num % 1000) / 100] + X[(num % 100) / 10] + I[num % 10];
        }
    }
}
