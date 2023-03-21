namespace leetcode_sharp;

// 104. Maximum Depth of Binary Tree
// https://leetcode.com/problems/maximum-depth-of-binary-tree/
public class S00104
{
    public int MaxDepth(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
    }
}