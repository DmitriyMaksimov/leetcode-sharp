namespace leetcode_sharp;

// 111. Minimum Depth of Binary Tree
// https://leetcode.com/problems/minimum-depth-of-binary-tree/
public class S00111
{
    public int MinDepth(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        if (root.left == null || root.right == null)
        {
            return Math.Max(MinDepth(root.left), MinDepth(root.right)) + 1;
        }
        
        return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
    }
}