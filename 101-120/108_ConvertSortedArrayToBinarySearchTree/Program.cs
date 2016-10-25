using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _108_ConvertSortedArrayToBinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = SortedArrayToBST(new int[] { 1, 2, 3 });
        }

        static TreeNode SortedArrayToBST(int[] nums)
        {
            return Helper(nums, 0, nums.Count() - 1);
        }

        static TreeNode Helper(int[] nums, int left, int right)
        {
            if (left > right) return null;
            if (left == right) return new TreeNode(nums[left]);
            int mid = (left + right) / 2;
            var node = new TreeNode(nums[mid]);
            node.left = Helper(nums, left, mid - 1);
            node.right = Helper(nums, mid + 1, right);
            return node;
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
