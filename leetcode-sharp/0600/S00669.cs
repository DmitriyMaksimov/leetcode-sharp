namespace leetcode_sharp;

// 669. Trim a Binary Search Tree
// https://leetcode.com/problems/trim-a-binary-search-tree
public class S00669
{
    public TreeNode? TrimBST(TreeNode? root, int low, int high)
    {
        if (root == null)
        {
            return null;
        }

        if (root.val < low)
        {
            return TrimBST(root.right, low, high);
        }

        if (root.val > high)
        {
            return TrimBST(root.left, low, high);
        }

        root.left = TrimBST(root.left, low, high);
        root.right = TrimBST(root.right, low, high);

        return root;
    }
}
