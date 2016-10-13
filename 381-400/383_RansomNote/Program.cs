using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _383_RansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public bool CanConstruct(string ransomNote, string magazine)
        {
            var charNum = new int[26];
            foreach (var item in ransomNote)
            {
                charNum[item - 'a']--;
            }
            foreach (var item in magazine)
            {
                charNum[item - 'a']++;
            }
            for (int i = 0; i < 26; i++)
            {
                if (charNum[i] < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
