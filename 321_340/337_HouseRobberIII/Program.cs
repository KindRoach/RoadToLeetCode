using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _337_HouseRobberIII
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public int Rob(TreeNode root)
        {
            var ans = Helper(root);
            return Math.Max(ans.Item1, ans.Item2);
        }

        public Tuple<int, int> Helper(TreeNode root)
        {
            if (root == null) return Tuple.Create(0, 0);
            var left = Helper(root.left);
            var right = Helper(root.right);
            return Tuple.Create(root.val + left.Item2 + right.Item2, Math.Max(left.Item1, left.Item2) + Math.Max(right.Item1, right.Item2));
        }


    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
