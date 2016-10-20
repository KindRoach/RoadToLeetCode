using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_GenerateParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public IList<string> GenerateParenthesis(int n)
        {
            var ans = new List<string>();
            Helper(ans, "", n, 0);
            return ans;
        }

        public void Helper(List<string> list, string s, int l, int r)
        {
            if (l == 0 && r == 0)
            {
                list.Add(s);
                return;
            }

            if (l > 0) Helper(list, s + "(", l - 1, r + 1);
            if (r > 0) Helper(list, s + ")", l, r - 1);
        }
    }
}
