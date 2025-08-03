namespace leetcode_sharp;

// 653. Two Sum IV - Input is a BST
// https://leetcode.com/problems/two-sum-iv-input-is-a-bst/
public class S00653
{
    private readonly HashSet<int> _hashSet = [];

    public bool FindTarget(TreeNode? root, int k)
    {
        inorderTraversal(root);
        return _hashSet.Any(n => n != k - n && _hashSet.Contains(k - n));
    }
    
    private void inorderTraversal(TreeNode? node)
    {
        if (node == null)
        {
            return;
        }

        inorderTraversal(node.left);
        _hashSet.Add(node.val);
        inorderTraversal(node.right);
    }
}