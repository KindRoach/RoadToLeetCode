using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _344_ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "aaaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbbbbbbbbcccccccccccccccccccccsssssssssssssssssss";
            var before = new DateTime();
            var after = new DateTime();
            before = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                ReverseString(s);
            }
            after = DateTime.Now;
            Console.WriteLine(after - before);

            before = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                ReverseString2(s);
            }
            after = DateTime.Now;
            Console.WriteLine(after - before);

            before = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                ReverseString3(s);
            }
            after = DateTime.Now;
            Console.WriteLine(after - before);
        }

        static string ReverseString(string s)
        {
            var ans = new StringBuilder(s.Length);
            var rs = s.Reverse();
            foreach (var item in rs)
            {
                ans.Append(item);
            }
            return ans.ToString();
        }


        static string ReverseString2(string s)
        {
            return new string(s.Reverse().ToArray());
        }

        // 这个最快……
        static string ReverseString3(string s)
        {
            var rs = s.ToCharArray();
            Array.Reverse(rs);
            return new string(rs);
        }
    }
}
