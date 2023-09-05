namespace leetcode_sharp;

// 965. Univalued Binary Tree
// https://leetcode.com/problems/univalued-binary-tree/
public class S00965
{
    public bool IsUnivalTree(TreeNode? root)
    {
        return helper(root, root!.val);
    }

    private static bool helper(TreeNode? root, int x)
    {
        if (root == null)
        {
            return true;
        }

        if (root.val != x)
        {
            return false;
        }

        return helper(root.left, x) && helper(root.right, x);
    }
}