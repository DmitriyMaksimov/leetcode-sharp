namespace leetcode_sharp;

// 99. Recover Binary Search Tree
// https://leetcode.com/problems/recover-binary-search-tree
public class S00099
{
    private TreeNode? _prev;
    private TreeNode? _first;
    private TreeNode? _second;

    public void RecoverTree(TreeNode? root)
    {
        if (root == null)
        {
            return;
        }

        InOrder(root);

        (_first!.val, _second!.val) = (_second.val, _first.val);
    }

    private void InOrder(TreeNode? root)
    {
        if (root == null)
        {
            return;
        }

        InOrder(root.left);

        if (_prev != null && root.val < _prev.val)
        {
            _first ??= _prev;
            _second = root;
        }

        _prev = root;
        InOrder(root.right);
    }
}
