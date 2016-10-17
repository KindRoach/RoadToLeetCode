using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _94_BinaryTreeInorderTraversal
{
    // 二叉树的非递归中序遍历
    class Program
    {
        static void Main(string[] args)
        {
        }

        public IList<int> InorderTraversal(TreeNode root)
        {
            var ans = new List<int>();
            var stack = new Stack<Tuple<TreeNode, bool>>();
            stack.Push(Tuple.Create(root, false));
            TreeNode node;
            bool Visted;
            while (stack.Count != 0)
            {
                node = stack.Peek().Item1;
                Visted = stack.Pop().Item2;
                if (node == null) continue;
                if (Visted)
                {
                    ans.Add(node.val);
                }
                else
                {
                    // 若为先序/后序修改以下三句的顺序就可以
                    stack.Push(Tuple.Create(node.right, false));
                    stack.Push(Tuple.Create(node, true));
                    stack.Push(Tuple.Create(node.left, false));
                }
            }
            return ans;
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
