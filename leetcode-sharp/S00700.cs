namespace leetcode_sharp;

// 700. Search in a Binary Search Tree
// https://leetcode.com/problems/search-in-a-binary-search-tree/
public class S00700
{
    public TreeNode? SearchBST(TreeNode? root, int val)
    {
        if (root == null) return null;

        return root.val == val ? root : SearchBST(root.val > val ? root.left : root.right, val);
    }
}