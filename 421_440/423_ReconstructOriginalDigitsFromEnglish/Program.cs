using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _423_ReconstructOriginalDigitsFromEnglish
{
    class Program
    {
        static void Main(string[] args)
        {
            FindLetter();
        }

        static void FindLetter()
        {
            var nums = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var dic = new Dictionary<char, int>();
            foreach (var str in nums)
            {
                foreach (var cha in str)
                {
                    if (!dic.Keys.Contains(cha))
                    {
                        dic.Add(cha, 1);
                    }
                    else
                    {
                        dic[cha]++;
                    }
                }
            }

            var ans = dic.OrderBy(x => x.Value);
            foreach (var item in ans)
            {
                Console.Write($"{item}:");
                for (int i = 0; i < 10; i++)
                {
                    if (nums[i].Contains(item.Key))
                    {
                        Console.Write(i);
                    }
                }
                Console.WriteLine();
            }
        }

        public string OriginalDigits(string s)
        {
            var count = new int[10];
            var letter_show = new int[26];
            foreach (var cha in s)
            {
                switch (cha)
                {
                    case 'z': count[0]++; break;
                    case 'w': count[2]++; break;
                    case 'u': count[4]++; break;
                    case 'x': count[6]++; break;
                    case 'g': count[8]++; break;
                    default:
                        letter_show[cha - 'a']++;
                        break;
                }
            }

            count[3] = letter_show['h' - 'a'] - count[8];
            count[5] = letter_show['f' - 'a'] - count[4];
            count[7] = letter_show['v' - 'a'] - count[5];
            count[6] = letter_show['s' - 'a'] - count[7];
            count[1] = letter_show['o' - 'a'] - count[4] - count[2] - count[0];
            count[9] = letter_show['i' - 'a'] - count[5] - count[6] - count[8];

            var ansString = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < count[i]; j++)
                {
                    ansString.Append(i);
                }
            }
            return ansString.ToString();
        }
    }
}
