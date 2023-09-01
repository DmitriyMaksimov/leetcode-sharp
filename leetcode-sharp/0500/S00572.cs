namespace leetcode_sharp;

// 572. Subtree of Another Tree
// https://leetcode.com/problems/subtree-of-another-tree/
public class S00572
{
    public bool IsSubtree(TreeNode? root, TreeNode? subRoot)
    {
        if (root == null || subRoot == null) return false;
        if (isSameTree(root, subRoot)) return true;
        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    private static bool isSameTree(TreeNode? root, TreeNode? subRoot)
    {
        if (root == null && subRoot == null) return true;
        if (root == null || subRoot == null) return false;
        if (root.val != subRoot.val) return false;
        return isSameTree(root.left, subRoot.left) && isSameTree(root.right, subRoot.right);
    }
}