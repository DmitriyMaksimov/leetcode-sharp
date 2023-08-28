namespace leetcode_sharp;

// 110. Balanced Binary Tree
// https://leetcode.com/problems/balanced-binary-tree/
public class S00110
{
    public bool IsBalanced(TreeNode? root)
    {
        if (root == null)
        {
            return true;
        }

        return Math.Abs(GetHeight(root.left) - GetHeight(root.right)) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
    }

    private static int GetHeight(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        return Math.Max(GetHeight(root.left), GetHeight(root.right)) + 1;
    }
}