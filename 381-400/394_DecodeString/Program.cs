using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _394_DecodeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DecodeString("3[a2[c]]"));
            Console.WriteLine(DecodeString("a4[d2[c]e]2[f]"));
        }

        static string DecodeString(string s)
        {
            var intStack = new Stack<int>();
            var strStack = new Stack<StringBuilder>();
            var ans = new StringBuilder();
            int k = 0;
            foreach (var ch in s)
            {
                if (ch >= '0' && ch <= '9')
                {
                    k = k * 10 + ch - '0';
                }
                else if (ch == '[')
                {
                    intStack.Push(k);
                    strStack.Push(ans);
                    ans = new StringBuilder();
                    k = 0;
                }
                else if (ch == ']')
                {
                    var temp = ans;
                    ans = strStack.Pop();
                    for (k = intStack.Pop(); k > 0; k--)
                        ans.Append(temp);
                }
                else
                {
                    ans.Append(ch);
                }
            }
            return ans.ToString();
        }
    }
}
