using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _404_SumOfLeftLeaves
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftSum;
            if (root.left != null && root.left.left == null && root.left.right == null)
            {
                leftSum = root.left.val;
            }
            else
            {
                leftSum = SumOfLeftLeaves(root.left);
            }

            return leftSum + SumOfLeftLeaves(root.right);
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
