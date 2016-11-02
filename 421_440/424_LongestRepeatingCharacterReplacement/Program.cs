using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _424_LongestRepeatingCharacterReplacement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CharacterReplacement("ABBAAC", 2));
        }

        static int CharacterReplacement(string s, int k)
        {
            var count = new int[26];
            int max_len = 0, max_occur = 0, start = 0;
            for (int end = 0; end < s.Length; end++)
            {
                int index = s[end] - 'A';
                count[index]++;
                max_occur = Math.Max(max_occur, count[index]);
                if (end - start - max_occur + 1 > k)
                {
                    count[s[start] - 'A']--;
                    start++;
                }
                max_len = end - start + 1;
            }
            return max_len;
        }

        static int CharacterReplacement2(string s, int k)
        {
            var count = new int[26];
            int start = 0;
            int maxOccur, maxLen;
            maxLen = 0;
            for (int end = 0; end < s.Length; end++)
            {
                count[s[end] - 'A']++;
                maxOccur = count.Max();
                if (end - start + 1 - maxOccur > k)
                {
                    count[s[start]]--;
                    start++;
                }
                else
                {
                    maxLen = Math.Max(maxLen, end - start + 1);
                }
            }
            return maxLen;
        }
    }
}
