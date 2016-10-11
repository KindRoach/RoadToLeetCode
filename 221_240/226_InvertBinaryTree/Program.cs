using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226_InvertBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public TreeNode InvertTree(TreeNode root)
        {
            if (root != null)
            {
                root.left = InvertTree(root.left);
                root.right = InvertTree(root.right);

                var temp = root.left;
                root.left = root.right;
                root.right = temp;
            }
            return root;
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
