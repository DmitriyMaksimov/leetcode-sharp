namespace leetcode_sharp;

// 530. Minimum Absolute Difference in BST
// https://leetcode.com/problems/minimum-absolute-difference-in-bst/
public class S00530
{
    private readonly List<int> _result = new();

    public int GetMinimumDifference(TreeNode? root)
    {
        inorderTraversal(root);
        var diff = int.MaxValue;
        for (var i = 0; i < _result.Count - 1; i++)
        {
            diff = Math.Min(diff, Math.Abs(_result[i] - _result[i + 1]));
        }

        return diff;
    }

    private void inorderTraversal(TreeNode? node)
    {
        if (node == null)
        {
            return;
        }

        inorderTraversal(node.left);
        _result.Add(node.val);
        inorderTraversal(node.right);
    }
}