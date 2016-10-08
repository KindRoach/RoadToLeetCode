using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _389_FindTheDifference
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public char FindTheDifference(string s, string t)
        {
            var appearS = new int[26];
            var appearT = new int[26];
            char ans = ' ';
            for (int i = 0; i < s.Length; i++)
            {
                appearS[s[i] - 'a']++;
            }
            for (int i = 0; i < t.Length; i++)
            {
                appearT[t[i] - 'a']++;
            }
            for (int i = 0; i < 26; i++)
            {
                if (appearS[i] < appearT[i])
                {
                    ans = (char)('a' + i);
                }
            }
            return ans;
        }

        public char FindTheDifference2(string s, string t)
        {
            int ans = 0;
            for (int i = 0; i < s.Length; i++)
            {
                ans = ans ^ s[i];
            }
            for (int i = 0; i < t.Length; i++)
            {
                ans = ans ^ t[i];
            }
            return (char)ans;
        }
    }
}
