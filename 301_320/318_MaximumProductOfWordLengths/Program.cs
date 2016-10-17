using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _318_MaximumProductOfWordLengths
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int MaxProduct(string[] words)
        {
            var val = new int[words.Count()];
            for (int i = 0; i < words.Count(); i++)
            {
                foreach (var item in words[i])
                {
                    val[i] |= 1 << (item - 'a');
                }
            }
            int maxPro = 0;
            for (int i = 0; i < words.Count(); i++)
            {
                for (int j = 0; j < words.Count(); j++)
                {
                    if ((val[i] & val[j]) == 0)
                    {
                        maxPro = Math.Max(maxPro, words[i].Length * words[j].Length);
                    }
                }
            }
            return maxPro;
        }
    }
}
