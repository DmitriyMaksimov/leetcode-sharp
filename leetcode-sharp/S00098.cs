namespace leetcode_sharp;

// 98. Validate Binary Search Tree
// https://leetcode.com/problems/validate-binary-search-tree/
public class S00098
{
    private TreeNode? _previous = null;
    
    public bool IsValidBST(TreeNode? root)
    {
        if (root == null) return true;
        if (!IsValidBST(root.left))
        {
            return false;
        }

        if (_previous != null && root.val <= _previous.val)
        {
            return false;
        }

        _previous = root;

        return IsValidBST(root.right);
    }
}