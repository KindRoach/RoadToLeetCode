using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _415_AddStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddStrings2("123456789", "987654321"));
        }

        static string AddStrings(string num1, string num2)
        {
            double max = Math.Max(num1.Length, num2.Length);
            int n = Convert.ToInt32(Math.Ceiling(max / 9));
            var int1 = new int[n + 1];
            var int2 = new int[n + 1];

            int start = num1.Length - 9;
            int index = 0;
            string s;
            while (start >= 0)
            {
                s = num1.Substring(start, 9);
                int1[index] = Convert.ToInt32(s);
                start = start - 9;
                index++;
            }
            if (start > -9)
            {
                int1[index] = Convert.ToInt32(num1.Substring(0, start + 9));
            }

            start = num2.Length - 9;
            index = 0;
            while (start >= 0)
            {
                s = num2.Substring(start, 9);
                int2[index] = Convert.ToInt32(s);
                start = start - 9;
                index++;
            }
            if (start > -9)
            {
                int2[index] = Convert.ToInt32(num2.Substring(0, start + 9));
            }

            var sum = new int[n + 1];
            for (int i = 0; i < n + 1; i++)
            {
                sum[i] = sum[i] + int1[i] + int2[i];
                if (sum[i] > 999999999)
                {
                    sum[i + 1] = sum[i] / 1000000000;
                    sum[i] = sum[i] % 1000000000;
                }
            }

            var ansString = new StringBuilder((int)max);
            for (int i = n; i >= 0; i--)
            {
                s = sum[i].ToString();
                while (s.Length < 9)
                {
                    s = "0" + s;
                }
                ansString.Append(s);
            }
            var ans = ansString.ToString();
            while (ans.Length != 1 && ans[0] == '0')
            {
                ans = ans.Remove(0, 1);
            }
            return ans;
        }

        static string AddStrings2(string num1, string num2)
        {
            int i = num1.Length - 1;
            int j = num2.Length - 1;
            int carry = 0;
            var ans = new StringBuilder(Math.Max(i, j) + 2);
            while (i >= 0 || j >= 0)
            {
                if (i >= 0) carry += num1[i--] - '0';
                if (j >= 0) carry += num2[j--] - '0';
                ans.Insert(0, carry % 10);
                carry /= 10;
            }
            if (carry != 0) ans.Insert(0, carry);
            return ans.ToString();
        }
    }
}
