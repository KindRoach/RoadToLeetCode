using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_SameTree
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null || q == null)
            {
                return p == q;
            }

            return p.val == q.val &&
                   IsSameTree(p.left, q.left) &&
                   IsSameTree(p.right, q.right);
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
