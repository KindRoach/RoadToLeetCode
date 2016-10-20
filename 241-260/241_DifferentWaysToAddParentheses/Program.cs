using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241_DifferentWaysToAddParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var ans = DiffWaysToCompute("2-1-1");
        }

        static IList<int> DiffWaysToCompute(string input)
        {
            var ans = new List<int>();
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == '+' || input[i] == '-' || input[i] == '*')
                {
                    var leftVals = DiffWaysToCompute(input.Substring(0, i));
                    var rightVals = DiffWaysToCompute(input.Substring(i + 1));
                    foreach (var leftVal in leftVals)
                    {
                        foreach (var rightVal in rightVals)
                        {
                            switch (input[i])
                            {
                                case '+':
                                    ans.Add(leftVal + rightVal);
                                    break;
                                case '-':
                                    ans.Add(leftVal - rightVal);
                                    break;
                                case '*':
                                    ans.Add(leftVal * rightVal);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
            }
            if (ans.Count == 0) ans.Add(Convert.ToInt32(input));
            return ans;
        }
    }
}
