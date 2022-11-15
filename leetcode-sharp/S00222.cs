namespace leetcode_sharp;

// 1929. Concatenation of Array
// https://leetcode.com/problems/count-complete-tree-nodes/
public class S00222
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public int CountNodes(TreeNode root)
    {
        if (root is null) return 0;

        return CountNodes(root.left) + CountNodes(root.right) + 1;
    }
}